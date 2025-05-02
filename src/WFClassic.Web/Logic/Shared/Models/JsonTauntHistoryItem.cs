using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class JsonTauntHistoryItem
    {
        [JsonPropertyName("node")]
        public string node { get; set; }
    }
}
