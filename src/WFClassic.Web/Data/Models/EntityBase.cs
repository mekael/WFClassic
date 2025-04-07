namespace WFClassic.Web.Data.Models
{
    public class EntityBase
    {
        public Guid Id { get; set; } 
        public DateTimeOffset CreationTimestamp { get; set; }
        public DateTimeOffset LastModificationTimestamp { get; set; }

    }
}
