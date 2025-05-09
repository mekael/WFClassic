namespace WFClassic.Web.Data.Models
{
    public class Player : EntityBase
    {

        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public List<TauntHistoryItem> TauntHistoryItems { get; set; }
        public List<Mission> Missions { get; set; }
        public List<InventoryBin> InventoryBins { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public List<PendingRecipe> PendingRecipes { get; set; }



        public int PlayerXP { get; set; }
        public int AdditionalPlayerXP { get; set; }
        public int Rating { get; set; }
        public int PlayerLevel { get; set; }
        public DateTime TrainingDate { get;set; }
        public bool ReceivedStartingGear { get; set; }
        public string Founder { get; set; }

        public bool SubscribedToEmails { get; set; }


    }
}


 