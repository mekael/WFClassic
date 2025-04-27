using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class FriendsController : ControllerBase
    {

        [HttpPost]
        [Route("/api/addFriendImage.php")]
        public ActionResult AddFriendImage([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/addPendingFriend.php")]
        public ActionResult AddPendingFriend([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/addFriend.php")]
        public ActionResult AddFriend([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpPost]
        [Route("/api/removeFriend.php")]
        public ActionResult RemoveFriend([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }
        [HttpGet]
        [Route("/api/getFriends.php")]
        public string GetFriends([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            var response = @"

{
 ""Current"": [
            {
                ""_id"": {
                    ""$id"": ""aaa""
                },
                ""DisplayName"": ""aaa"",
                ""Status"": 0
            },
            {
                ""_id"": {
                    ""$id"": ""bbb""
                },
                ""DisplayName"": ""bbb"",
                ""Status"": 0
            },
            {
                ""_id"": {
                    ""$id"": ""ccc""
                },
                ""DisplayName"": ""ccc"",
                ""Status"": 0,
""ChatHistory"" :[]
            }
        ]
}
";

            return response;
        }

    }
}
