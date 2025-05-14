using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Friendship.Add;
using WFClassic.Web.Logic.Friendship.AddPending;
using WFClassic.Web.Logic.Friendship.Get;
using WFClassic.Web.Logic.Friendship.Remove;
using WFClassic.Web.Logic.Middleware;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class FriendsController : ControllerBase
    {
        private AddPendingFriendHandler _addPendingFriendHandler;
        private GetFriendsRequestHandler _getFriendsRequestHandler;
        private AcceptFriendRequestHandler _acceptFriendRequestHandler;
        private RemoveFriendRequestHandler _removeFriendRequestHandler;

        public FriendsController(AddPendingFriendHandler addPendingFriendHandler, GetFriendsRequestHandler getFriendsRequestHandler,
            AcceptFriendRequestHandler acceptFriendRequestHandler, RemoveFriendRequestHandler removeFriendRequestHandler)
        {
            _addPendingFriendHandler = addPendingFriendHandler;
            _getFriendsRequestHandler = getFriendsRequestHandler;
            _acceptFriendRequestHandler = acceptFriendRequestHandler;
            _removeFriendRequestHandler = removeFriendRequestHandler;
        }

        [HttpPost]
        [Route("/api/addFriendImage.php")]
        public ActionResult AddFriendImage([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            return new JsonResult("{}");
        }

        [HttpGet]
        [Route("/api/addPendingFriend.php")]
        public ActionResult AddPendingFriend([FromQuery] AddPendingFriend addPendingFriend)
        {
            var result = _addPendingFriendHandler.Handle(addPendingFriend);

            if (result.AddPendingFriendResultStatus == AddPendingFriendResultStatus.Success)
            {
                return Ok();
            }
            else if (result.AddPendingFriendResultStatus == AddPendingFriendResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.AddPendingFriendResultStatus == AddPendingFriendResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        // approve a friend request
        [HttpGet]
        [Route("/api/addFriend.php")]
        public ActionResult AddFriend([FromQuery] AcceptFriendRequest acceptFriendRequest)

        {
            var result = _acceptFriendRequestHandler.Handle(acceptFriendRequest);

            if (result.AcceptFriendResultStatus == AcceptFriendResultStatus.Success)
            {
                return Ok();
            }
            else if (result.AcceptFriendResultStatus == AcceptFriendResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.AcceptFriendResultStatus == AcceptFriendResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/removeFriend.php")]
        public ActionResult RemoveFriend([FromQuery] RemoveFriendRequest removeFriendRequest)
        {
            var result = _removeFriendRequestHandler.Handle(removeFriendRequest);
            if (result.RemoveFriendResultStatus == RemoveFriendResultStatus.Success)
            {
                return Ok();
            }
            else if (result.RemoveFriendResultStatus == RemoveFriendResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.RemoveFriendResultStatus == RemoveFriendResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        [HttpGet]
        [Route("/api/getFriends.php")]
        public ActionResult GetFriends([FromQuery] GetFriendsRequest getFriendsRequest)
        {
            var result = _getFriendsRequestHandler.Handle(getFriendsRequest);

            if (result.GetFriendsResultStatus == GetFriendsResultStatus.DatabaseErrors ||
                result.GetFriendsResultStatus == GetFriendsResultStatus.MappingFailure)
            {
                return StatusCode(500);
            }
            else if (result.GetFriendsResultStatus == GetFriendsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetFriendsResultStatus == GetFriendsResultStatus.Success)
            {
                return new JsonResult(result.JsonGetFriendsResult,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
            }

            return StatusCode(500);
        }
    }
}