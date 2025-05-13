using Microsoft.AspNetCore.Identity;

namespace WFClassic.Web.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
        public string SteamId { get; set; }
        public DateTimeOffset LastLoginTimestamp { get; set; }
        public bool CurrentlyLoggedIn { get; set; }
        public long CurrentNonce { get; set; }
        public int TotalNumberOfDaysLoginCount { get; set; }
        public int LoginStreak { get; set; }

        public ICollection<LoginTrackingItem> LoginTrackingItems { get; set; }
    }
}