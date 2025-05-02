using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonMission
    {
        [JsonPropertyName("Tag")]
        public string Tag { get; set; }

        [JsonPropertyName("Completes")]
        public int Completes { get; set; }

        [JsonPropertyName("BestRating")] 
        public float BestRating { get; set; }

    }
}

