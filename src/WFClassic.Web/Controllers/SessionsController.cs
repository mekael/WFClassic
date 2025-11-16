using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.SessionHandling;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class SessionsController : ControllerBase
    {
        private readonly SessionHandler _sessionHandler;


        public SessionsController(SessionHandler sessionHandler)
        {
            this._sessionHandler = sessionHandler;
        }


        [HttpPost]
        [Route("/api/deleteSession.php")]
        public ActionResult DeleteSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/leaveSession.php")]
        public ActionResult LeaveSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/removeFromSession.php")]
        public ActionResult RemoveFromSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/updateSession.php")]
        public ActionResult UpdateSession([FromQuery] Guid accountId, [FromQuery] long nonce, [FromQuery] string sessionID, [FromQuery] bool fullReset, [FromQuery] int gameModeId)
        {
            // http://127.0.0.1/api/updateSession.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=8434711716736183556&sessionId=&fullReset=1&regionId=4&gameModeId=40030 

            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/hostSession.php")]
        public ActionResult HostWarframeSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var request = Utils.GetRequestObject<HostSessionRequest>(this.HttpContext);
            request.HostIpAddress = this.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            request.AccountId = accountId;

            var response = this._sessionHandler.HandleHostSession(request);

            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult(new { Results = new{id =response.SessionId.ToString() } } );
        }

        [HttpPost]
        [Route("/api/aggregateSessions.php")]
        public ActionResult AggregateSessionsEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {

            AggregateSessionsRequest aggregateSessionsRequest = Utils.GetRequestObject<AggregateSessionsRequest>(this.HttpContext);

            AggregateSessionsResult aggregateSessionsResult = this._sessionHandler.HandleFindSessions(aggregateSessionsRequest);


            return new JsonResult(aggregateSessionsResult, new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [HttpPost]
        [Route("/api/joinSession.php")]
        public ActionResult JoinSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/findSessions.php")]
        public ActionResult FindSessions([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            //http://127.0.0.1/api/findSessions.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=8434711716736183556
            //{"buildId":859816754,"gameModeId":40030,"regionId":4}
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }
    }
}