namespace WFClassic.Web.Data.Models
{
    public class EntityBase
    {
        public Guid Id { get; set; } 
        public DateTimeOffset CreationTimestamp { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset LastModificationTimestamp { get; set; } = DateTimeOffset.Now;

    }
}
