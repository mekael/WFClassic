using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("/api/getIgnoredUsers.php")]
        public ActionResult GetIgnoredUsers([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/addIgnoredUser.php")]
        public ActionResult AddIgnoredUser([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/removeIgnoredUser.php")]
        public ActionResult RemoveIgnoredUser([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}