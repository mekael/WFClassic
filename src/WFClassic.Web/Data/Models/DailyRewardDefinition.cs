namespace WFClassic.Web.Data.Models
{
    public class DailyRewardDefinition : EntityBase
    {
        // from documentation
        public string RewardType { get; set; }
        public string Icon { get; set; }
        public string ItemType { get; set; }
        public string ProductCategory { get; set; }
        public int Amount { get; set; }
        public int Tier { get; set; }
        public string DisplayName { get; set; }
        public string Rarity { get; set; }


        // from wiki
        public int StreakStartDate { get; set; }
        public int StreakEndDate { get; set; }
        
        // guessing. 
        public int RandLowerBound { get; set; }
        public int RandUpperBound { get; set; }

    }
}

 