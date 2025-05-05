using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using WFClassic.Web.Data;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Inventory.Get;

namespace WFClassic.Web.Logic.Middleware
{
    public class LoginVerificationActionFilter : ActionFilterAttribute
    {

        private ILogger<LoginVerificationActionFilter> _logger;
        private IsUserOnlineQueryHandler _isUserOnlineQueryHandler;

        public LoginVerificationActionFilter(ILogger<LoginVerificationActionFilter> logger, IsUserOnlineQueryHandler isUserOnlineQueryHandler ) 
        {
            _isUserOnlineQueryHandler = isUserOnlineQueryHandler;
            _logger = logger;   
         }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("CASFDASDASD");
             var accountId = Guid.Parse(context.HttpContext.Request.Query["accountId"].First());
            var nonce = long.Parse(context.HttpContext.Request.Query["nonce"].First());

            IsUserOnlineQuery isUserOnlineQuery = new IsUserOnlineQuery(accountId, nonce);

            var isUserOnlineResult = _isUserOnlineQueryHandler.Handle(isUserOnlineQuery);

            if (isUserOnlineResult.IsUserOnlineQueryResultStatus == IsUserOnlineQueryResultStatus.DatabaseIssues)
            {
                context.Result = new StatusCodeResult(500);
                return;
            }
            else if(isUserOnlineResult.IsUserOnlineQueryResultStatus == IsUserOnlineQueryResultStatus.UserNotFound)
            {
                context.Result = new StatusCodeResult(404);
                return;
            }
            else if (isUserOnlineResult.IsUserOnlineQueryResultStatus == IsUserOnlineQueryResultStatus.UserNotLoggedIn)
            {
                context.Result = new StatusCodeResult(403); 
                return;
            }


        }
 
    }
}
