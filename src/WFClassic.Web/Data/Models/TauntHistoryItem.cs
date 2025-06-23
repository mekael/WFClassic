using System.Text.Json.Serialization;

namespace WFClassic.Web.Data.Models
{
    public class TauntHistoryItem : EntityBase
    {
        [JsonIgnore]
        public Guid PlayerId { get; set; }
        [JsonIgnore]
        public Player Player { get; set; }
        public string Node { get; set; }
    }
}