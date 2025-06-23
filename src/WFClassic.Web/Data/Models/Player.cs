using System.Text.Json.Serialization;

namespace WFClassic.Web.Data.Models
{
    public class Player : EntityBase
    {
        [JsonIgnore]
        public Guid ApplicationUserId { get; set; }
        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; }

        public List<TauntHistoryItem> TauntHistoryItems { get; set; }
        public List<Mission> Missions { get; set; }
        public List<InventoryBin> InventoryBins { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        [JsonIgnore]
        public List<PendingRecipe> PendingRecipes { get; set; }
        [JsonIgnore]
        public List<MissionReport> MissionReports { get; set; }
        [JsonIgnore]
        public List<PlayerPurchaseRecord> PlayerPurchaseRecords { get; set; }

        public int PlayerXP { get; set; }
        public int AdditionalPlayerXP { get; set; }
        public int Rating { get; set; }
        public int PlayerLevel { get; set; }
        public DateTime TrainingDate { get; set; }
        public bool ReceivedStartingGear { get; set; }
        public string Founder { get; set; }
        public string ActiveAvatarImageType { get; set; }

        public bool SubscribedToEmails { get; set; }

        [JsonIgnore]
        public string CurrentLoadout { get; set; }
    }
}