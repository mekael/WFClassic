using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Friendship.AddPending
{
    public class AddPendingFriend
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("steamId")]
        public long SteamId { get; set; }

        [JsonPropertyName("friend")]
        public string Friend { get; set; }

 
    }
}


