using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;

namespace WFClassic.Web.Logic.Foundry.Claim
{
    public class ClaimCompletedRecipeHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<ClaimCompletedRecipeHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;

        private List<InternalInventoryItemType> _uniqueTypes = new List<InternalInventoryItemType>() {
                InternalInventoryItemType.Suits,
                InternalInventoryItemType.LongGuns,
                InternalInventoryItemType.Melee,
                InternalInventoryItemType.Pistols,
                InternalInventoryItemType.Sentinels,
                InternalInventoryItemType.SentinelWeapons
            };

        public ClaimCompletedRecipeHandler(ApplicationDbContext applicationDbContext, ILogger<ClaimCompletedRecipeHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
        }

        public ClaimCompletedRecipeResult Handle(ClaimCompletedRecipe claimCompletedRecipe)
        {
            ClaimCompletedRecipeResult claimCompletedRecipeResult = new ClaimCompletedRecipeResult();
            var validationResults = new ClaimCompletedRecipeValidator().Validate(claimCompletedRecipe);

            if (!validationResults.IsValid)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }

            Player player = null;
            Recipe recipe = null;
            try
            {
                _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce}  recipeName {RecipeName} => querying for recipe and player   ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);

                player = _applicationDbContext.Players.Include(i => i.PendingRecipes)
                                                      .Include(i => i.InventoryItems)
                                                      .FirstOrDefault(fod => fod.ApplicationUserId == claimCompletedRecipe.AccountId);

                recipe = _applicationDbContext.Recipes.AsNoTracking()
                                                      .Include(i => i.RecipeComponentItems)
                                                      .FirstOrDefault(fod => fod.RecipeItemName == claimCompletedRecipe.RecipeName);
            }
            catch (Exception ex)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Exception while searching for recipe definition  {Ex}", claimCompletedRecipe.AccountId, claimCompletedRecipe.RecipeName, claimCompletedRecipe.Nonce, ex);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.DatabaseErrors;
                return claimCompletedRecipeResult;
            }

            if (recipe == null)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No matching recipe definition found  ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                // we can't build due to not having a recipe
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }
            else if (!player.PendingRecipes.Any(a => a.RecipeId == recipe.Id))
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No pending recipe found ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }
            else if (!player.InventoryItems.Any(a => a.ItemType == claimCompletedRecipe.RecipeName && a.ItemCount > 0))
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No matching blueprint found ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }

            _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName}  => Found inventory item, found pending recipe f  ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);

            InventoryItem recipeItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == recipe.RecipeItemName);
            PendingRecipe pendingRecipe = player.PendingRecipes.FirstOrDefault(fod => fod.RecipeId == recipe.Id);

            InventoryItem builtItem = null;

            if (_uniqueTypes.Contains(recipe.InternalInventoryItemType))
            {
                builtItem = new InventoryItem()
                {
                    ItemCount = 1,
                    ItemType = recipe.ResultItemName,
                    ItemName = recipe.ResultItemPrettyName,
                    PlayerId = player.Id,
                    InternalInventoryItemType = recipe.InternalInventoryItemType,
                    UpgradeVer = 100
                };
                _applicationDbContext.InventoryItems.Add(builtItem);
            }
            else
            {
                builtItem = player.InventoryItems.FirstOrDefault(fod => fod.ItemType == recipe.ResultItemName);

                if (builtItem == null)
                {
                    _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Built item does not already exist creating new record    ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);

                    builtItem = new InventoryItem()
                    {
                        ItemCount = 1,
                        ItemType = recipe.ResultItemName,
                        ItemName = recipe.ResultItemPrettyName,
                        PlayerId = player.Id,
                        InternalInventoryItemType = recipe.InternalInventoryItemType
                    };
                    _applicationDbContext.InventoryItems.Add(builtItem);
                }
                else
                {
                    _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Built item exists incrementing counter    ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                    builtItem.ItemCount++;
                    _applicationDbContext.Entry(builtItem).State = EntityState.Modified;
                }
            }

            _applicationDbContext.Entry(pendingRecipe).State = EntityState.Deleted;
            recipeItem.ItemCount--;
            _applicationDbContext.Entry(recipeItem).State = EntityState.Modified;

            try
            {
                _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Updating database   ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                _applicationDbContext.SaveChanges();
                _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Database update successful ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.Success;
                claimCompletedRecipeResult.BuiltItem = recipe.ResultItemName;
            }
            catch (Exception ex)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Exception while searching for recipe definition  {Ex}", claimCompletedRecipe.AccountId, claimCompletedRecipe.RecipeName, claimCompletedRecipe.Nonce, ex);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.DatabaseErrors;
                return claimCompletedRecipeResult;
            }

            return claimCompletedRecipeResult;
        }
    }
}