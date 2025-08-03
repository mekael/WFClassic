using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Inventory.WarframeItemAddition;

namespace WFClassic.Web.Logic.Foundry.Claim
{
    public class ClaimCompletedRecipeHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<ClaimCompletedRecipeHandler> _logger;
        private readonly AddWarframeItemHandler _addWarframeItemHandler;

        public ClaimCompletedRecipeHandler(ApplicationDbContext applicationDbContext, ILogger<ClaimCompletedRecipeHandler> logger, AddWarframeItemHandler addWarframeItemHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addWarframeItemHandler = addWarframeItemHandler;
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

            Guid playerId = Guid.Empty;
            Recipe recipe = null;
            InventoryItem recipeItem = null;
            PendingRecipe pendingRecipe = null;

            try
            {
                _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce}  recipeName {RecipeName} => querying for recipe and player   ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                playerId = _applicationDbContext.Players.FirstOrDefault(fod => fod.ApplicationUserId == claimCompletedRecipe.AccountId).Id;
 
                recipeItem = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.ItemType == claimCompletedRecipe.RecipeName);

                recipe = _applicationDbContext.Recipes.AsNoTracking()
                                                      .FirstOrDefault(fod => fod.RecipeItemName == claimCompletedRecipe.RecipeName);

                pendingRecipe = _applicationDbContext.PendingRecipes.FirstOrDefault(fod => fod.PlayerId == playerId && fod.RecipeId == recipe.Id);
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
            else if (pendingRecipe== null)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No pending recipe found ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }
            else if (recipeItem == null || recipeItem.ItemCount==0)
            {
                _logger.LogError("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No matching blueprint found ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);
                claimCompletedRecipeResult.ClaimCompletedRecipeResultStatus = ClaimCompletedRecipeResultStatus.ValidationErrors;
                return claimCompletedRecipeResult;
            }

            _logger.LogInformation("ClaimCompletedRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName}  => Found blueprint item, pending item, and recipe ", claimCompletedRecipe.AccountId, claimCompletedRecipe.Nonce, claimCompletedRecipe.RecipeName);

            AddWarframeItemResult addWarframeItemResult = this._addWarframeItemHandler.Handle(new AddWarframeItem() { AccountId = claimCompletedRecipe.AccountId, ItemType = recipe.ResultItemName, WarframeItemLocation = WarframeItemLocation.Foundry });



            _applicationDbContext.Entry(pendingRecipe).State = EntityState.Deleted;
            // this deals with the fact that we need to retain the recipe/blueprint until we're done with teh build, else we can't display anything in the foundry.
            // im sure this was fixed at some point. 
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