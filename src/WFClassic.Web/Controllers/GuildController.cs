using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class GuildController : ControllerBase
    {

        [HttpPost]
        [Route("/api/createGuild.php")]
        public ActionResult CreateGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/removeFromGuild.php")]
        public ActionResult RemoveFromGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/addToGuild.php")]
        public ActionResult AddToGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/changeGuildRank.php")]
        public ActionResult ChangeGuildRank([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/confirmGuildInvitation.php")]
        public ActionResult ConfirmGuildInvitation([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
        [HttpGet]
        [Route("/api/getGuild.php")]
        public ActionResult GetGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
