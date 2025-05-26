using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Friendship.Icon
{
    public class SetAvatarIconRequest
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("avatarImageType")]
        public string AvatarImageType { get; set; }

        [JsonPropertyName("avatarImage")]
        public string AvatarImage { get; set; }

 
    }
}