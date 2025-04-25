using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class StatsController : ControllerBase
    {
        [HttpGet]
        [Route("/stats/leaderboard.php")]
        public ActionResult leaderboard([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/stats/upload.php")]
        public ActionResult Upload([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/stats/profileStats.php")]
        public ActionResult ProfileStats([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
