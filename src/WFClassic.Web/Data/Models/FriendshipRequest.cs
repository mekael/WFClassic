namespace WFClassic.Web.Data.Models
{
    public class FriendshipRequest : EntityBase
    {
        public Guid RequestorId { get; set; }
        public ApplicationUser Requestor { get; set; }
        public Guid FriendId { get; set; }
        public ApplicationUser Friend { get; set; }

        public int RequestStatus { get; set; }
        public DateTime? RequestAcceptedOrDeclinedOn { get; set; }
    }
}
