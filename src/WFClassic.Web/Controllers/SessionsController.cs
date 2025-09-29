using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Sessions.Aggregate;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class SessionsController : ControllerBase
    {
        [HttpPost]
        [Route("/api/deleteSession.php")]
        public ActionResult DeleteSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/leaveSession.php")]
        public ActionResult LeaveSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/removeFromSession.php")]
        public ActionResult RemoveFromSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/updateSession.php")]
        public ActionResult UpdateSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/hostSession.php")]
        public ActionResult HostSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult(new { id = new MongoId(Guid.NewGuid()), sessionId = new MongoId(Guid.NewGuid()) });
        }

        [HttpPost]
        [Route("/api/aggregateSessions.php")]
        public ActionResult AggregateSessionsEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            AggregateSessions aggregateSessions = new AggregateSessions()
            {
                AccountId = accountId,
                Nonce = nonce,
                AggregateSessionsJson = Utils.GetRequestObject<AggregateSessionsJson>(this.HttpContext)
            };

            var result = new AggregateSessionsResult();
            return new JsonResult(result, new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

        [HttpPost]
        [Route("/api/joinSession.php")]
        public ActionResult JoinSession([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/findSessions.php")]
        public ActionResult FindSessions([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}