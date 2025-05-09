using WFClassic.Web.Data.Enums;

namespace WFClassic.Web.Data.Models
{
    public class PersonRelationship : EntityBase
    {
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid FriendId { get; set; }
        public ApplicationUser Friend { get; set; }

        public PersonRelationshipType PersonRelationshipType { get; set; }

    }
}
