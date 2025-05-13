using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class GuildController : ControllerBase
    {
        [HttpGet]
        [Route("/api/createGuild.php")]
        public ActionResult CreateGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return Ok();
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
        public string GetGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var cat = @"
{
""Name"" :""cats"",
            ""_id"": {
                ""$id"": ""522656733f9a5b1718f1b5ab""
            },
""MemberIds"": []
}

";

            return cat;
        }
    }
}

//Ranks
//Members
/*
     message: string;
    authorName: string;
    authorGuildName?: string;

 */

//GET http://localhost/api/getGuild.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=3245491210690471581&steamId=0 HTTP/1.1