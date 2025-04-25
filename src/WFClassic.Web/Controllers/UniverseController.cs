using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class UniverseController : ControllerBase
    {

        [HttpPost]
        [Route("/api/loginRewards.php")]
        public ActionResult LoginRewards([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/checkDailyMissionBonus.php")]
        public ActionResult CheckDailyMissionBonus([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/worldState.php")]
        public ActionResult WorldState([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/goals.php")]
        public ActionResult Goals([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}
