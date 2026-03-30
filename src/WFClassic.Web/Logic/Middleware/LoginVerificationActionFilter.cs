using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Logic.Middleware
{
    public class LoginVerificationActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<LoginVerificationActionFilter> _logger;
        private readonly InMemoryLoginTracking _inMemoryLoginTracking;
        private readonly ServerConfiguration _serverConfiguration;

        public LoginVerificationActionFilter(ILogger<LoginVerificationActionFilter> logger, InMemoryLoginTracking inMemoryLoginTracking,
                                             ServerConfiguration serverConfiguration)
        {
            this._inMemoryLoginTracking = inMemoryLoginTracking;
            this._logger = logger;
            this._serverConfiguration = serverConfiguration;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this._logger.LogInformation("Verifying call => {RouteValues}", context.HttpContext.Request.RouteValues);

            Guid accountId = Guid.Parse(context.HttpContext.Request.Query["accountId"].First());
            long nonce = long.Parse(context.HttpContext.Request.Query["nonce"].First());
            string ipAddress = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();




            this._logger.LogInformation("LoginVerificationActionFilter=> accountId {accountId} nonce {nonce} ipAddress {ipAddress} ", accountId, nonce, ipAddress);

            bool userFound = this._inMemoryLoginTracking.LoggedInUserListing.TryGetValue(accountId, out InMemoryLoginTrackingItem foundUser);


            if (!userFound)
            {
                context.Result = new StatusCodeResult(404);
                return;
            }


            string buildVersion = context.HttpContext.Request.Query["buildVersion"].FirstOrDefault() ?? foundUser.BuildLabel;

            if (buildVersion != foundUser.BuildLabel || buildVersion != this._serverConfiguration.BuildLabel)
            {
                context.Result = new StatusCodeResult(400);
            }
            else if (foundUser.Nonce != nonce || foundUser.UserIpAddress != ipAddress)
            {
                context.Result = new StatusCodeResult(403);
                return;
            }
        }
    }
}