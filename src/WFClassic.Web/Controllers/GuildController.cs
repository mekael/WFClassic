using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class GuildController : ControllerBase
    {
        [HttpGet]
        [Route("/api/createGuild.php")]
        public ActionResult CreateGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In CreateGuild");

            return Ok();
        }

        [HttpPost]
        [Route("/api/removeFromGuild.php")]
        public ActionResult RemoveFromGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In removeFromGuild");

            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/customizeGuildRanks.php")]
        public ActionResult CustomizeGuildRanks([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In customizeGuildRanks");

            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/donateToGuild.php")]
        public ActionResult DonateToGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In DonateToGuild");

            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/api/addToGuild.php")]
        public ActionResult AddToGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            //GET /api/addToGuild.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=1361696396955615402&steamId=0&guildId=522656733f9a5b1718f1b5ab&userName=beer 
            Console.WriteLine("In AddToGuild");
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/changeGuildRank.php")]
        public ActionResult ChangeGuildRank([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In ChangeGuildRank");

            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/confirmGuildInvitation.php")]
        public ActionResult ConfirmGuildInvitation([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In ConfirmGuildInvitation");

            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/api/getGuild.php")]
        public string GetGuild([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In GetGuild");

            var cat = @"
{
""Name"" :""cats"",
""_id"": {
    ""$id"": ""522656733f9a5b1718f1b5ab""
},
""Members"": [
                    {
                    ""_id"": {
                        ""$id"": ""4FAD6BF1-5BB5-4C8F-9078-92A2827E221D""
                    },
                    ""DisplayName"" :""beer"",
                    ""Status"": 0,
                    ""ActiveAvatarImageType"" :"""",
                    ""Rank"" : 2
                                        },
                     {
                    ""_id"": {
                        ""$id"": ""C64C1E01-34D6-4311-AE40-7BAA5EBA3016""
                    },
                    ""DisplayName"" :""mekael"",
                    ""Status"": 0,
                    ""ActiveAvatarImageType"" :"""",
                    ""Rank"" : 1
                                        },
                    
            ]

}

";
             return cat;
        }
    }
}

/*
     accountId: Types.ObjectId;
    guildId: Types.ObjectId;
    status: number;
    rank: number;
    RequestMsg?: string;
    RequestExpiry?: Date;
    RegularCreditsContributed?: number;
    PremiumCreditsContributed?: number;
    MiscItemsContributed?: IMiscItem[];
    ShipDecorationsContributed?: ITypeCount[];
 */


//Ranks
//Members
/*
     message: string;
    authorName: string;
    authorGuildName?: string;

 */

//GET http://localhost/api/getGuild.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=3245491210690471581&steamId=0 HTTP/1.1