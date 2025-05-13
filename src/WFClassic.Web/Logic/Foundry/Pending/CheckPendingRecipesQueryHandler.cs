using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Foundry.Pending
{
    public class CheckPendingRecipesQueryHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<CheckPendingRecipesQueryHandler> _logger;

        public CheckPendingRecipesQueryHandler(ApplicationDbContext applicationDbContext, ILogger<CheckPendingRecipesQueryHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public CheckPendingRecipesResult Handle(CheckPendingRecipesQuery getFriendsRequest)
        {
            CheckPendingRecipesResult checkPendingRecipesResult = new CheckPendingRecipesResult();
            var validationResults = new CheckPendingRecipesQueryValidator().Validate(getFriendsRequest);

            if (!validationResults.IsValid)
            {
                _logger.LogError("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                checkPendingRecipesResult.CheckPendingRecipesResultStatus = CheckPendingRecipesResultStatus.ValidationErrors;
                return checkPendingRecipesResult;
            }

            List<PendingRecipe> pendingRecipes = new List<PendingRecipe>();

            try
            {
                _logger.LogInformation("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} =>  Querying for pending recips ", getFriendsRequest.AccountId, getFriendsRequest.Nonce);

                pendingRecipes = _applicationDbContext.PendingRecipes.AsNoTracking()
                                                               .Include(i => i.Recipe)
                                                               .Where(w => w.Player.ApplicationUserId == getFriendsRequest.AccountId)
                                                               .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for pending recipes {Ex}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, ex);
                checkPendingRecipesResult.CheckPendingRecipesResultStatus = CheckPendingRecipesResultStatus.DatabaseErrors;
                return checkPendingRecipesResult;
            }

            _logger.LogInformation("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} => Found {Count} pending recipes", getFriendsRequest.AccountId, getFriendsRequest.Nonce, pendingRecipes.Count);

            try
            {
                _logger.LogInformation("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} => Mapping onto result", getFriendsRequest.AccountId, getFriendsRequest.Nonce);

                checkPendingRecipesResult.JsonCheckPendingRecipesResult = new JsonCheckPendingRecipesResult()
                {
                    PendingRecipes = pendingRecipes.Select(s => new JsonCheckPendingRecipesResultItem() { ItemType = s.Recipe.RecipeItemName, SecondsRemaining = Math.Max(0, (long)(s.EndingTime - DateTimeOffset.Now).TotalSeconds) }).ToList()
                };
                checkPendingRecipesResult.CheckPendingRecipesResultStatus = CheckPendingRecipesResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("CheckPendingRecipesQueryHandler => accountId {AccountID} nonce {Nonce} => Exception while searching for friends {Ex}", getFriendsRequest.AccountId, getFriendsRequest.Nonce, ex);
                checkPendingRecipesResult.CheckPendingRecipesResultStatus = CheckPendingRecipesResultStatus.MappingFailure;
            }

            return checkPendingRecipesResult;
        }
    }
}