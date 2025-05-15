using Newtonsoft.Json;

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
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("Nonce")]
        public long Nonce { get; set; }

        [JsonProperty("BuildLabel")]
        public string BuildLabel { get; set; }  

        [JsonProperty("NatHash")]
        public string NatHash { get; set; }

        [JsonProperty("SteamId")]
        public string SteamId { get; set; }
    }
}