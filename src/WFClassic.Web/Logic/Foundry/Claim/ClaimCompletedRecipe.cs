using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Foundry.Claim
{
    public class ClaimCompletedRecipe
    {
        [JsonPropertyName("accountId")]
        public Guid AccountId { get; set; }

        [JsonPropertyName("nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("steamId")]
        public long SteamId { get; set; }

        [JsonPropertyName("recipeName")]
        public string RecipeName { get; set; }
 
    }
}
 