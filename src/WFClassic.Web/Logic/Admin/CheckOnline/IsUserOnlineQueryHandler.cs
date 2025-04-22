using Microsoft.AspNetCore.Identity;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Admin.CheckOnline
{
    public class IsUserOnlineQueryHandler
    {

        private ILogger<IsUserOnlineQueryHandler> _logger;
        private readonly UserManager<ApplicationUser> _userManager;


        public IsUserOnlineQueryHandler(UserManager<ApplicationUser> userManager, ILogger<IsUserOnlineQueryHandler> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public IsUserOnlineQueryResult Handle(IsUserOnlineQuery isUserOnlineQuery)
        {
            IsUserOnlineQueryResult result = new IsUserOnlineQueryResult();

            ApplicationUser applicationUser = null;
            try
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Querying for user ", isUserOnlineQuery.AccountId, isUserOnlineQuery.Nonce);
                applicationUser =   _userManager.FindByIdAsync(isUserOnlineQuery.AccountId.ToString()).Result;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for user {Ex}", isUserOnlineQuery.AccountId, isUserOnlineQuery.Nonce,ex);
                result.IsUserOnlineQueryResultStatus = IsUserOnlineQueryResultStatus.UserNotFound;
                return result;
            }

            if (applicationUser == null)
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => No user found", isUserOnlineQuery.AccountId, isUserOnlineQuery.Nonce);
                result.IsUserOnlineQueryResultStatus = IsUserOnlineQueryResultStatus.UserNotFound;
            }
            else if (applicationUser.CurrentNonce == isUserOnlineQuery.Nonce && applicationUser.CurrentlyLoggedIn)
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => User is logged in", isUserOnlineQuery.AccountId, isUserOnlineQuery.Nonce);
                result.IsUserOnlineQueryResultStatus = IsUserOnlineQueryResultStatus.IsLoggedIn;
            }
            else if(applicationUser.CurrentNonce != isUserOnlineQuery.Nonce  || !applicationUser.CurrentlyLoggedIn)
            {
                _logger.LogInformation("GetCreditsHandler => accountId {AccountID} nonce {Nonce} => User is not currently logged in.", isUserOnlineQuery.AccountId, isUserOnlineQuery.Nonce);
                result.IsUserOnlineQueryResultStatus = IsUserOnlineQueryResultStatus.UserNotLoggedIn;
            }
            
            return result;
        }
    }
}
