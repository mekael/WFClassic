using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Add;
using WFClassic.Web.Logic.Credits.Get;
using WFClassic.Web.Logic.Foundry.Claim;

namespace WFClassic.Web.Logic.Foundry.Rush
{
    public class RushRecipeHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<RushRecipeHandler> _logger;
        private AddAccountTransactionHandler _addAccountTransactionHandler;
        private GetCreditsHandler _getCreditsHandler;
        private ClaimCompletedRecipeHandler _claimCompletedRecipeHandler;

          public RushRecipeHandler(ApplicationDbContext applicationDbContext, ILogger<RushRecipeHandler> logger,
            AddAccountTransactionHandler addAccountTransactionHandler, GetCreditsHandler getCreditsHandler,
            ClaimCompletedRecipeHandler claimCompletedRecipeHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _addAccountTransactionHandler = addAccountTransactionHandler;
            _claimCompletedRecipeHandler = claimCompletedRecipeHandler;
            _getCreditsHandler = getCreditsHandler;
        }


        public RushRecipeResult Handle(RushRecipe rushRecipe)
        {
            RushRecipeResult rushRecipeResult
                = new RushRecipeResult();
            var validationResults = new RushRecipeValidator().Validate(rushRecipe);

            if (!validationResults.IsValid)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", rushRecipe.AccountId, rushRecipe.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.ValidationErrors;
                return rushRecipeResult;
            }

            // get the recipe


            // get the current credit status for plat
            // check to see if the user has enough plat in their account
            // claim the item
            // decrement bank account


             Recipe recipe = null;
            try
            {
                _logger.LogInformation("RushRecipeHandler => accountId {AccountID} nonce {Nonce}  recipeName {RecipeName} => querying for recipe and player   ", rushRecipe.AccountId, rushRecipe.Nonce, rushRecipe.RecipeName);
                recipe = _applicationDbContext.Recipes.AsNoTracking()
                                                      .Include(i => i.RecipeComponentItems)
                                                      .FirstOrDefault(fod => fod.RecipeItemName == rushRecipe.RecipeName);

            }
            catch (Exception ex)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} recipeName {RecipeName} => Exception while searching for recipe definition  {Ex}", rushRecipe.AccountId, rushRecipe.RecipeName, rushRecipe.Nonce, ex);
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.DatabaseErrors;
                return rushRecipeResult;
            }




            if (recipe == null)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => No matching recipe definition found  ", rushRecipe.AccountId, rushRecipe.Nonce, rushRecipe.RecipeName);
                // we can't build due to not having a recipe
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.ValidationErrors;
                return rushRecipeResult;
            }


            var getCreditResult = _getCreditsHandler.Handle(new GetCredits() { AccountId = rushRecipe.AccountId, Nonce = rushRecipe.Nonce });
            if(getCreditResult.GetCreditsResultStatus != GetCreditsResultStatus.Success)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Unable to determine amount of plat  ", rushRecipe.AccountId, rushRecipe.Nonce, rushRecipe.RecipeName);
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.DatabaseErrors;
                return rushRecipeResult;
            }
             
            if(getCreditResult.GetCreditsResultDetails.PremiumCredits < recipe.SkipBuildPriceInPlatinum)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => Not enough plat to complete rush   ", rushRecipe.AccountId, rushRecipe.Nonce, rushRecipe.RecipeName);
                // we can't build due to not having a recipe
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.ValidationErrors;
                return rushRecipeResult;
            }


            var claimResult = _claimCompletedRecipeHandler.Handle(new ClaimCompletedRecipe() { Nonce = rushRecipe.Nonce, AccountId = rushRecipe.AccountId, RecipeName = rushRecipe.RecipeName });

            if(claimResult.ClaimCompletedRecipeResultStatus != ClaimCompletedRecipeResultStatus.Success)
            {
                _logger.LogError("RushRecipeHandler => accountId {AccountID} nonce {Nonce} recipe {RecipeName}  => unable to claim item ", rushRecipe.AccountId, rushRecipe.Nonce, rushRecipe.RecipeName);
                // we can't build due to not having a recipe
                rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.DatabaseErrors;
                return rushRecipeResult;
           }

            //TODO: fix this, or turn it into an atomic action.
            var addAccountTransactionResult = _addAccountTransactionHandler.Handle(new AddAccountTransaction() { AccountId =rushRecipe.AccountId, Amount = -1* recipe.SkipBuildPriceInPlatinum, BankAccountTransactionType = Data.Enums.BankAccountTransactionType.Debit, BankAccountType =Data.Enums.BankAccountType.Platinum, MemoCode=recipe.RecipeItemName});

            rushRecipeResult.RushRecipeResultStatus = RushRecipeResultStatus.Success;
            return rushRecipeResult;
        }

    }
}
