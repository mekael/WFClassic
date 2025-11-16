using System.Text.Json;

using Microsoft.AspNetCore.Mvc;

using WFClassic.Web.Logic.Bonus.Daily;
using WFClassic.Web.Logic.Bonus.Rewards;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Universe.GetState;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class UniverseController : ControllerBase
    {
        private readonly GetLoginRewardsHandler _getLoginRewardsHandler;
        private readonly GetWorldStateHandler _getWorldStateHandler;
        private readonly GetDailyMissionBonusHandler _getDailyMissionBonusHandler;
        public UniverseController(GetLoginRewardsHandler getLoginRewardsHandler, GetWorldStateHandler getWorldStateHandler, GetDailyMissionBonusHandler getDailyMissionBonusHandler)
        {
            _getLoginRewardsHandler = getLoginRewardsHandler;
            _getWorldStateHandler = getWorldStateHandler;
            _getDailyMissionBonusHandler = getDailyMissionBonusHandler;
        }

        [HttpGet]
        [Route("/api/loginRewards.php")]
        public ActionResult LoginRewards([FromQuery] GetLoginRewards getLoginRewards)
        {
            var result = _getLoginRewardsHandler.HandleAsync(getLoginRewards).Result;

            if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.Success)
            {
                return new JsonResult(result.GetLoginRewardsResultReturnJson, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.AlreadyProvided)
            {
                return Ok();
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetLoginRewardsResultStatus == GetLoginRewardsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpGet]
        [Route("/api/checkDailyMissionBonus.php")]
        public ActionResult CheckDailyMissionBonus([FromQuery] GetDailyMissionBonus getDailyMissionBonus)
        {
            var result = _getDailyMissionBonusHandler.Handle(getDailyMissionBonus);

            if (result.GetDailyMissionBonusResultStatus == GetDailyMissionBonusResultStatus.Success)
            {
                return new JsonResult(result.GetDailyMissionBonusResultReturnJson, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetDailyMissionBonusResultStatus == GetDailyMissionBonusResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetDailyMissionBonusResultStatus == GetDailyMissionBonusResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpGet]
        [Route("/api/worldState.php")]
        public ActionResult WorldState([FromQuery] GetWorldState getWorldState)
        {

            var result = _getWorldStateHandler.Handle(getWorldState);

            if (result.GetWorldStateResultStatus == GetWorldStateResultStatus.Success)
            {
                return new JsonResult(result.GetWorldStateResultJson, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetWorldStateResultStatus == GetWorldStateResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetWorldStateResultStatus == GetWorldStateResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/goals.php")]
        public ActionResult Goals([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            Console.WriteLine("In Goals");
            return new JsonResult("{}");
        }



        [HttpPost]
        [Route("/api/heartbeat.php")]
        public ActionResult HeartbeatPost()
        {
            return new JsonResult("");
        }

        [HttpGet]
        [Route("/api/heartbeat.php")]
        public ActionResult HeartbeatGet()
        {
            return new JsonResult("");
        }

    }
}