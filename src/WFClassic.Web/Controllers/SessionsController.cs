using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.SessionHandling;
using WFClassic.Web.Logic.Shared;

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
        [Route("/api/hostSession.php")]
        public string HostWarframeSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var request = Utils.GetRequestObject<HostSessionRequest>(this.HttpContext);
            request.HostIpAddress = this.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            request.AccountId = accountId;

            var response = this._sessionHandler.HandleHostSession(request);
            return response.SessionId;
        }

        [HttpPost]
        [Route("/api/aggregateSessions.php")]
        public ActionResult AggregateSessionsEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {

            AggregateSessionsRequest aggregateSessionsRequest = Utils.GetRequestObject<AggregateSessionsRequest>(this.HttpContext);
            aggregateSessionsRequest.AccountId = accountId;

            AggregateSessionsResult aggregateSessionsResult = this._sessionHandler.HandleAggregateSessions(aggregateSessionsRequest);

            return new JsonResult(aggregateSessionsResult, new JsonSerializerOptions { PropertyNamingPolicy = null });
        }
        [HttpPost]
        [Route("/api/findSessions.php")]
        public ActionResult FindSessions([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            FindSessionsRequest request = Utils.GetRequestObject<FindSessionsRequest>(this.HttpContext);
            request.AccountId = accountId;
            var response = this._sessionHandler.HandleFindSessions(request);

            return new JsonResult(response, new JsonSerializerOptions { PropertyNamingPolicy = null });
        }


        // why did they decide it was a good idea to have this as a 
        [HttpGet]
        [Route("/api/deleteSession.php")]
        public ActionResult DeleteSession([FromQuery] Guid accountId, [FromQuery] long nonce, [FromQuery] string sessionId)
        {
            this._sessionHandler.HandleDeleteSession(sessionId, accountId);
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
        public ActionResult UpdateWarframeSession([FromQuery] UpdateSession updateSession)
        {
            // wtf does this even do ? 
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/joinSession.php")]
        public ActionResult JoinSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Utils.GetRequestObjectAsString(this.HttpContext);
            return new JsonResult("{}");
        }


    }
}