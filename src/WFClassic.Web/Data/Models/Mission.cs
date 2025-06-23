using System.Text.Json.Serialization;

namespace WFClassic.Web.Data.Models
{
    public class Mission : EntityBase
    {
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        [JsonIgnore]
        public Player Player { get; set; }
        public string Tag { get; set; }
        public int Completes { get; set; }
        public float BestRatings { get; set; }
    }
}