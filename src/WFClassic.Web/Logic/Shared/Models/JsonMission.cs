using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonMission
    {
        [JsonProperty("Tag")]
        public string Tag { get; set; }

        [JsonProperty("Completes")]
        public int Completes { get; set; }

        [JsonProperty("BestRating")] 
        public float BestRating { get; set; }

    }
}

