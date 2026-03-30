using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.Clans.Create;
using WFClassic.Web.Logic.Clans.Get;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;

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
        [HttpGet]
        [Route("/api/getGuild.php")]
        public ActionResult GetGuildEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var result = this._getGuildHandler.Handle(new GetGuild() { AccountId = accountId, Nonce = nonce });
            return new JsonResult(result.GetGuildResultJson);
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
        public ActionResult CustomizeGuildRanks([FromQuery] Guid accountId, [FromQuery] long nonce, [FromQuery] Guid guildId)
        {
            Console.WriteLine("In customizeGuildRanks");
            //HTTP/1.1 POST http://127.0.0.1/api/customizeGuildRanks.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=4805214973093660194&guildId=3e370a24-b2c9-4840-821c-3af9611dd893 
            Utils.GetRequestObjectAsString(this.HttpContext);

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

        [HttpPost]
        [Route("/api/setGuildMotd.php")]
        public ActionResult SetGuildMessageOfTheDay([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            //  POST /api/setGuildMotd.php?accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=4805214973093660194 HTTP/1.1
            Utils.GetRequestObjectAsString(this.HttpContext);

            return new JsonResult("");
        }


    }
}
