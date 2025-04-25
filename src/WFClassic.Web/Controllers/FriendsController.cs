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
        [HttpPost]
        [Route("/api/getFriends.php")]
        public ActionResult GetFriends([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

    }
}
