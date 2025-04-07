namespace WFClassic.Web.Data.Models
{
    public class LoginTrackingItem : EntityBase
    {
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTimeOffset LoginTimestamp { get; set; }
        public DateTimeOffset? LogoutTimestamp { get; set; }
        public string IPAddress { get; set; }
        public long Nonce { get; set; }

    }
}
