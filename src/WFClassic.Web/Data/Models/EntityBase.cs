using System.Text.Json.Serialization;

namespace WFClassic.Web.Data.Models
{
    public class EntityBase
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        
        [JsonIgnore]
        public DateTimeOffset CreationTimestamp { get; set; } = DateTimeOffset.Now;

        [JsonIgnore]
        public DateTimeOffset LastModificationTimestamp { get; set; } = DateTimeOffset.Now;
    }
}