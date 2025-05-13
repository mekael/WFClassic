using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;

namespace WFClassic.Web.Logic.Foundry.Start
{
    public class StartRecipeBuildHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<StartRecipeBuildHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;

        public StartRecipeBuildHandler(ApplicationDbContext applicationDbContext, ILogger<StartRecipeBuildHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
        }

        public StartRecipeBuildResult Handle(StartRecipeBuild startRecipeBuild)
        {
            StartRecipeBuildResult StartRecipeBuildResult = new StartRecipeBuildResult();
            var validationResults = new StartRecipeBuildValidator().Validate(startRecipeBuild);

            if (!validationResults.IsValid)
            {
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", startRecipeBuild.AccountId, startRecipeBuild.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                return StartRecipeBuildResult;
            }

            Player player = null;
            Recipe recipe = null;
            try
            {
                _logger.LogInformation("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} => querying for recipe {RecipeName}   ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);

                player = _applicationDbContext.Players.Include(i => i.PendingRecipes)
                                                      .Include(i => i.InventoryItems)
                                                      .FirstOrDefault(fod => fod.ApplicationUserId == startRecipeBuild.AccountId);

                recipe = _applicationDbContext.Recipes.AsNoTracking()
                                                      .Include(i => i.RecipeComponentItems)
                                                      .FirstOrDefault(fod => fod.RecipeItemName == startRecipeBuild.RecipeName);
            }
            catch (Exception ex)
            {
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for recipe definition {RecipeName} {Ex}", startRecipeBuild.AccountId, startRecipeBuild.RecipeName, startRecipeBuild.Nonce, ex);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.DatabaseErrors;
                return StartRecipeBuildResult;
            }

            if (recipe == null)
            {
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No matching recipe definition found  ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                // we can't build due to not having a recipe
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                return StartRecipeBuildResult;
            }
            else if (player.PendingRecipes.Count == 4)
            {
                // we can only have 4 pending recipes it looks like
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Already have 4 builds in process   ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                return StartRecipeBuildResult;
            }
            else if (player.PendingRecipes.Any(a => a.RecipeId == recipe.Id))
            {
                // we can only have 4 pending recipes it looks like
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Already have a pending build for recipe  ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                return StartRecipeBuildResult;
            }

            _logger.LogInformation("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Recipe found, checking component list ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
            List<InventoryItem> inventoryItemsToUpdate = new List<InventoryItem>();

            foreach (RecipeItem recipeItem in recipe.RecipeComponentItems)
            {
                InventoryItem inventoryItem = player.InventoryItems.Where(w => w.ItemType == recipeItem.ItemName).FirstOrDefault();
                if (inventoryItem == null || inventoryItem.ItemCount < recipeItem.ItemCountNeeded)
                {
                    // bail early with a validation error
                    _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName}  => Invalid number of {RecipeItemName} found ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName, recipeItem.ItemName);
                    StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                    return StartRecipeBuildResult;
                }
                _logger.LogInformation("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => User has correct number of  {RecipeItemName}  for build", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName, recipeItem.ItemName);

                inventoryItem.ItemCount -= recipeItem.ItemCountNeeded;
                inventoryItemsToUpdate.Add(inventoryItem);
            }

            PendingRecipe pendingRecipe = new PendingRecipe()
            {
                PlayerId = player.Id,
                RecipeId = recipe.Id,
                StartingTime = DateTimeOffset.Now,
                EndingTime = DateTimeOffset.Now.AddMinutes(recipe.BuildTimeInMinutes)
            };

            // add new bank account transaction
            // we will reverse this if our db save fails
            var addAccountTransactionResult = _addAccountTransactionHandler.Handle(new AddAccountTransaction()
            {
                AccountId = startRecipeBuild.AccountId,
                Amount = recipe.PriceInStandardCredits,
                BankAccountTransactionType = Data.Enums.BankAccountTransactionType.Debit,
                BankAccountType = Data.Enums.BankAccountType.StandardCredits,
                MemoCode = $"Build of {recipe.RecipeItemName}"
            });

            if (addAccountTransactionResult.AddAccountTransactionResultStatus != AddAccountTransactionResultStatus.Success)
            {
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName}  => Error while adding new bacnk account transaction ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.ValidationErrors;
                return StartRecipeBuildResult;
            }

            try
            {
                _logger.LogInformation("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Updating database ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                foreach (var inventoryItem in inventoryItemsToUpdate)
                {
                    _applicationDbContext.Entry(inventoryItem).State = EntityState.Modified;
                }
                _applicationDbContext.PendingRecipes.Add(pendingRecipe);
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Recipe set to pending and component counts updated ", startRecipeBuild.AccountId, startRecipeBuild.Nonce, startRecipeBuild.RecipeName);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("StartRecipeBuildHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for recipe definition {RecipeName} :  {Ex}", startRecipeBuild.AccountId, startRecipeBuild.RecipeName, startRecipeBuild.Nonce, ex);
                StartRecipeBuildResult.StartRecipeBuildResultStatus = StartRecipeBuildResultStatus.DatabaseErrors;
            }

            return StartRecipeBuildResult;
        }
    }
}