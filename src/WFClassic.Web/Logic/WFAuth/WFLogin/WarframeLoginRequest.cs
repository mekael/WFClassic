using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.WFAuth.WFLogin
{
    public class WarframeLoginRequest
    {
        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }

        [JsonIgnore]
        public string HostName { get; set; }
       
    }
}
