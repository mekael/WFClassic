using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared.Models
{
    public class MongoId
    {
        [JsonPropertyName("$id")]
        public string Id { get; set; }

        public MongoId(Guid id)
        {
            this.Id = id.ToString();
        }
    }
}
