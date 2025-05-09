using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Stats.Leaderboard;
using WFClassic.Web.Logic.Stats.ProfileStats;
using WFClassic.Web.Logic.Stats.Upload;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class StatsController : ControllerBase
    {
        UploadStatsHandler _uploadStatsHandler;
        GetLeaderboardStatsHandler _getLeaderboardStatsHandler;
        GetProfileStatsHandler _getProfileStatsHandler;
        public StatsController(UploadStatsHandler uploadStatsHandler, GetLeaderboardStatsHandler getLeaderboardStatsHandler, GetProfileStatsHandler getProfileStatsHandler)
        {
            _uploadStatsHandler = uploadStatsHandler;
            _getLeaderboardStatsHandler = getLeaderboardStatsHandler;
            _getProfileStatsHandler = getProfileStatsHandler;
        }

        [HttpGet]
        [Route("/stats/leaderboard.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult leaderboard([FromQuery] GetLeaderboardStats getLeaderboardStats)
        {

            var result = _getLeaderboardStatsHandler.Handle(getLeaderboardStats);

            if (result.GetLeaderboardStatsResultStatus == GetLeaderboardStatsResultStatus.Success)
            {
                return new JsonResult(result.GetLeaderboardStatsResultJson,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetLeaderboardStatsResultStatus == GetLeaderboardStatsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetLeaderboardStatsResultStatus == GetLeaderboardStatsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("/stats/upload.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult Upload([FromQuery] Guid accountId, [FromQuery] long nonce)
        {


            var uploadStats = new UploadStats()
            {
                AccountId = accountId,
                Nonce = nonce,
                StatsObject = Utils.GetRequestObject<StatsObject>(this.HttpContext)
            };


            var result = _uploadStatsHandler.Handle(uploadStats);
            if (result.UploadStatsResultStatus == UploadStatsResultStatus.Success)
            {
                return Ok();
            }
            else if (result.UploadStatsResultStatus == UploadStatsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.UploadStatsResultStatus == UploadStatsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("/stats/profileStats.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult ProfileStats([FromQuery] GetProfileStats getProfileStats)
        {

            var result = _getProfileStatsHandler.Handle(getProfileStats);

            if (result.GetProfileStatsResultsStatus == GetProfileStatsResultsStatus.Success)
            {
                return new JsonResult(result.ProfileStatsItem,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetProfileStatsResultsStatus == GetProfileStatsResultsStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetProfileStatsResultsStatus == GetProfileStatsResultsStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }




            // Dumped and quit both count as quits, 
            // interupted must be something else (network issues?) 
            var cat = @"
{
""TimePlayedSec"": 10,
""Rating"" :2,
""Rank"" : 22,
""MissionsCompleted"" :1,
""MissionsFailed"" :1,
""MissionsInterrupted"" :1,  
""MissionsDumped"" :1,
""MissionsQuit"" :1,
""CiphersSolved"" :1,
""CiphersFailed"" :1,
""CipherTime"" :1,
 
""ReviveCount"" :1,
""HealCount"" :1,
""Enemies"" : [
{
""type"" :""/Lotus/Types/Enemies/Corpus/BipedRobot/AIWeek/ShockwaveBipedAvatar"",
""deaths"": 1,
}
]
}

";



            return StatusCode(500);
        }
    }
}
/*
stats/profileStats.php?
accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016
nonce=8495907343374567873
steamId=0
lookupId=c64c1e01-34d6-4311-ae40-7baa5eba3016  

 
 */
// 