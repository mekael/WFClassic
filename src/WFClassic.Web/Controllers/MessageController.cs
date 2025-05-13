using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        [Route("/api/getMessages.php")]
        public string GetMessages([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var response = @"{
      ""Messages"": [
            {
                ""SenderId"": {
                    ""$id"":""sdfs""
                },
                ""Content"":""sdfsd""
            }
        ]
}";
            return response;
        }

        [HttpPost]
        [Route("/api/sendMessage.php")]
        public ActionResult SendMessage([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
    }
}