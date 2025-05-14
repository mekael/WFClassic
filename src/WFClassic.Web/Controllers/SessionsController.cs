using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Middleware;

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
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/aggregateSessions.php")]
        public string AggregateSessions([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            /*
             {
    "buildId" : 1324716850,
    "regionId" : 0
}
             */

            string resp = @"
{
  ""Results"": [
    {
      ""gameModeId"": 0,
      ""map"": ""caa"",
      ""count"" :111111
    }
  ]
}

";
            return resp;
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