using System;

namespace WFClassic.Web.Data.Models;

public class PlayerBan : EntityBase
{
    public Guid ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public Guid BannedByUserId { get; set; }
        public ApplicationUser BannedByUser { get; set; }

    public string BanReason { get; set; }
    public DateTimeOffset BanStartedOn { get; set; }
    public DateTimeOffset BanInEffectUntil { get; set; }

    public string BanRescindedBy { get; set; }
    public string BanRescindedReason { get; set; }
    public DateTimeOffset? BanRescindedOnDate { get; set; }

}
