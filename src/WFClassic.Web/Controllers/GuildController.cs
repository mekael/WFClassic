using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.Clans.Create;
using WFClassic.Web.Logic.Clans.Get;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class GuildController : ControllerBase
    {

        private readonly AddGuildHandler _addGuildHandler;
        private readonly GetGuildHandler _getGuildHandler;
        public GuildController(AddGuildHandler addGuildHandler, GetGuildHandler getGuildHandler)
        {
            this._addGuildHandler = addGuildHandler;
            this._getGuildHandler = getGuildHandler;
        }

        [HttpGet]
        [Route("/api/createGuild.php")]
        public ActionResult CreateGuild([FromQuery] AddGuild addGuild)
        {

            var result = this._addGuildHandler.Handle(addGuild);
            if (result.AddGuildResultStatus == AddGuildResultStatus.DatabaseErrors)
            {
                return this.StatusCode(500);
            }
            else if (result.AddGuildResultStatus == AddGuildResultStatus.ValidationErrors)
            {
                return this.BadRequest();
            }

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

        // used in 10.x
        [HttpGet]
        [Route("/api/getAlliance.php")]
        public string GetAlliance([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return "{}";
        }


        [HttpGet]
        [Route("/api/getGuild.php")]
        public ActionResult GetGuildEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var result = this._getGuildHandler.Handle(new GetGuild() { AccountId = accountId, Nonce = nonce });
            // return new JsonResult(result.GetGuildResultJson, new JsonSerializerOptions { PropertyNamingPolicy = null });

            var cat = @"
                            {
                            ""Name"" :""cats"",
                            ""_id"": {
                                ""$id"": ""522656733f9a5b1718f1b5ab""
                                     },
                            ""Members"": [
                                          {""Rank"" :1, ""Name"" :""mekael""}      
                                        ],
                            ""Ranks"" : [{""Name"":""devil"", ""Permissions"" :1}, {""Name"":""mekael""}],
                            ""MOTD"" :""cats and more cats""
                            }
                        ";

            Console.WriteLine(JsonSerializer.Serialize(result.GetGuildResultJson));
            return new JsonResult(result.GetGuildResultJson);
        }
    }
}
