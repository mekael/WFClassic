namespace WFClassic.Web.Data.Models
{
    public class PlayerReport : EntityBase
    {
        public Guid MissionReportId { get; set; }
        public MissionReport MissionReport { get; set; }

        // This should be a nullable guid, but we can't be sure given the fact that
        public string AssociatedAccountId { get; set; }

        public int Credits { get; set; }
        public int CredtBonus { get; set; }
        public int Xp { get; set; }
        public int XpBonus { get; set; }
        public int SuitXpBonus { get; set; }
        public int PistolXpBonus { get; set; }
        public int RifleXpBonus { get; set; }
        public int MeleeXpBonus { get; set; }
        public int SentinelXPBonus { get; set; }
        public int SentinelWeaponXpBonus { get; set; }
        public float Rating { get; set; }
        public string Upgrades { get; set; }
    }
}