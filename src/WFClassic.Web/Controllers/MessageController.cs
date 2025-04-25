using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        [Route("/api/getMessages.php")]
        public ActionResult GetMessages([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/sendMessage.php")]
        public ActionResult SendMessage([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

    }
}

