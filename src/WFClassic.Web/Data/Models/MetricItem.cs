using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class MetricItem :EntityBase
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public long AssociatedNonce { get; set; }

        public string DisplayName { get; set; }

        public MetricType MetricType { get; set; }
        public string EventName { get; set; }
        public long? ItemCount { get; set; }
        public string ItemName { get; set; }
        public bool? Set { get; set; }
        public float? Seconds { get; set; }
    }
}
