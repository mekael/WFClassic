using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class MiscController : ControllerBase
    {

        [HttpPost]
        [Route("/api/trainingResult.php")]
        public ActionResult TrainingResult([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/refillCard.php")]
        public ActionResult RefillCard([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/refillRevives.php")]
        public ActionResult RefillRevives([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/recharge.php")]
        public ActionResult Recharge([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }


        [HttpPost]
        [Route("/api/tauntHistory.php")]
        public ActionResult TauntHistory([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

    }

}
