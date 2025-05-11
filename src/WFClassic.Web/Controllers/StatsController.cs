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

            return StatusCode(500);
        }
    }
}
