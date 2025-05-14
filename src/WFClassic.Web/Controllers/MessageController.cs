using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
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
                    ""$id"":""4FAD6BF1-5BB5-4C8F-9078-92A2827E221D""
                },
                ""Content"":""asdfhjasldfkjlkj""
            }
        ]
}";
            response = "{}";
            return response;
        }

        [HttpPost]
        [Route("/api/sendMessage.php")]
        public ActionResult SendMessage([FromQuery] Guid accountId, [FromQuery] long nonce)
        {

            Console.WriteLine("in SendMessage");

            return new JsonResult("{}");
        }
    }
}