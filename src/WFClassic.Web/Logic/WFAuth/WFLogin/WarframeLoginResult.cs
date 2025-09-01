using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.WFAuth.WFLogin
{
    public class WarframeLoginResult
    {
        public WarframeLoginResultStatus WarframeLoginResultStatus { get; set; }
        public WarframeLoginResultDetails WarframeLoginResultDetails { get; set; } = new WarframeLoginResultDetails();
    }

    public enum WarframeLoginResultStatus
    {
        BadRequest,
        UserNotFound,
        InvalidCredentials,
        Success,
        Failure,
    }

    public class WarframeLoginResultDetails
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("DisplayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("Nonce")]
        public long Nonce { get; set; }

        [JsonPropertyName("BuildLabel")]
        public string BuildLabel { get; set; }

        [JsonPropertyName("NatHash")]
        public string NatHash { get; set; }

        [JsonPropertyName("SteamId")]
        public string SteamId { get; set; }
    }
}