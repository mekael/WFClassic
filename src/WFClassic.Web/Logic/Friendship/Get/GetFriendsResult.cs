using System.Text.Json.Serialization;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Friendship.Get
{
    public class GetFriendsResult
    {
        public GetFriendsResultStatus GetFriendsResultStatus { get; set; }
        public JsonGetFriendsResult JsonGetFriendsResult { get; set; }


    }

    public class JsonGetFriendsResult
    {
        [JsonPropertyName("Current")]
        public List<GetFriendsResultFriendItem> Current { get; set; }

        [JsonPropertyName("IncomingFriendRequests")]
        public List<GetFriendsResultFriendItem> IncomingFriendRequests { get; set; }

        [JsonPropertyName("OutgoingFriendRequests")]
        public List<GetFriendsResultFriendItem> OutgoingFriendRequests { get; set; }
    }


    public class GetFriendsResultFriendItem 
    {
        [JsonPropertyName("_id")]
        public MongoId id { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }
    
    }


    public enum GetFriendsResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
