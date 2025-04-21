using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.WFAuth.WFLogout
{
    public class WarframeLogoutHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<WarframeLogoutHandler> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public WarframeLogoutHandler(ApplicationDbContext applicationDbContext, ILogger<WarframeLogoutHandler> logger, UserManager<ApplicationUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<WarframeLogoutResult> Handle(WarframeLogoutRequest request)
        {
            WarframeLogoutResult warframeLogoutResult = new WarframeLogoutResult();


            var validationResult = new WarframeLogoutRequestValidator().Validate(request);
            if (!validationResult.IsValid) 
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => Validation Errors  {Errors}", request.accountId, string.Join("\n", validationResult.Errors.Select(s => $"{s.ErrorCode} : {s.ErrorMessage}")));
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.BadRequest;
                return warframeLogoutResult;
            }




            ApplicationUser applicationUser = null;


            try
            {
                _logger.LogInformation("WarframeLogoutRequestHandler =>  accountId {AccountId} => Searching for user", request.accountId);
                applicationUser = await _userManager.FindByIdAsync(request.accountId.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => Exception while searching for user {Ex}", request.accountId, ex);
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.Failure;
                return warframeLogoutResult;
            }


            if (applicationUser == null)
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => No user found", request.accountId);
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.NotFound;
                return warframeLogoutResult;

            }
            else if (applicationUser.CurrentNonce != request.nonce)
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => Provided Nonce does not match with ", request.accountId);
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.NonceDoesNotMatch;
                return warframeLogoutResult;
            }

            _logger.LogInformation("WarframeLogoutRequestHandler =>  accountId {AccountId} => User found.", request.accountId);


            applicationUser.CurrentlyLoggedIn = false;
            applicationUser.CurrentNonce = 0;

            IdentityResult identityResult = null;

            try
            {
                _logger.LogInformation("WarframeLogoutRequestHandler =>  accountId {AccountId} => Updating user for logout", request.accountId);
                identityResult = await _userManager.UpdateAsync(applicationUser);

            }
            catch (Exception ex)
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => Exception while updating user {Ex}", request.accountId, ex);
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.Failure;
                return warframeLogoutResult;
            }


            if (identityResult.Succeeded)
            {
                _logger.LogInformation("WarframeLogoutRequestHandler =>  accountId {AccountId} =>User updated and logged out", request.accountId);
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.Success;

            }
            else
            {
                _logger.LogError("WarframeLogoutRequestHandler =>  accountId {AccountId} => Errors while updating user  {Errors}", request.accountId, string.Join("\n", identityResult.Errors.Select(s => $"{s.Code} : {s.Description}")));
                warframeLogoutResult.WarframeLogoutResultStatus = WarframeLogoutResultStatus.Failure;
            }






            return warframeLogoutResult;
        }
    }
}
