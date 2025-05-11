namespace WFClassic.Web.Data.Models
{
    public class MissionReport : EntityBase
    {

        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public long Nonce { get; set; }

        public string HostId { get; set; }
        public string MissionStartTime { get; set; }
        public string MissionName { get; set; }
        public string ReporterId { get; set; }
        public bool FullReport { get; set; }

        public List<PlayerReport> PlayerReports { get; set; }
    }
}
