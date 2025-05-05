using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Shared;
using WFClassic.Web.Logic.Stats.Upload;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class StatsController : ControllerBase
    {
        UploadStatsHandler _uploadStatsHandler;

        public StatsController(UploadStatsHandler uploadStatsHandler)
        {
            _uploadStatsHandler = uploadStatsHandler;
        }


        [HttpGet]
        [Route("/stats/leaderboard.php")]
        public string leaderboard([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            string cats = @"
""players"" :[
{
""DisplayName"" :""mekael"",
""score"":124,
""rank"":111
},
{
""DisplayName"" :""bixby"",
""score"":1000000,
""rank"":1
}
]
";
            //
            // score is "kills


            return cats;
        }

        [HttpPost]
        [Route("/stats/upload.php")]
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
            else if (result.UploadStatsResultStatus == UploadStatsResultStatus.LoginCheckFailure)
            {
                return new ForbidResult();
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("/stats/profileStats.php")]
        public ActionResult ProfileStats([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
