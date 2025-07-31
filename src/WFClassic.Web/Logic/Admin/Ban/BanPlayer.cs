namespace WFClassic.Web.Logic.Admin.Ban
{


    public class BanPlayer
    {

        public Guid AccountId { get; set; }
        public string BanReason { get; set; }
        public DateTimeOffset? BanInEffectUntil { get; set; }
        public bool PermaBan { get; set; }
        public Guid BannedByUserId { get; set; }

    }
}