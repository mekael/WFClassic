namespace WFClassic.Web.Logic.Bonus.Rewards
{
    public class GetLoginRewardsResult
    {
        public GetLoginRewardsResultStatus GetLoginRewardsResultStatus { get; set; }
        public GetLoginRewardsResultReturnJson GetLoginRewardsResultReturnJson { get; set; }
    }

    public enum GetLoginRewardsResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success,
        AlreadyProvided
    }

    public class GetLoginRewardsResultReturnJson
    {
        public List<Reward> Rewards { get; set; }
    }

    public class Reward
    {
        public string RewardType { get; set; }
        public string ItemType { get; set; }
        public string Icon { get; set; }
        public string ProductCategory { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public int Tier { get; set; }
        public string Rarity { get; set; }
    }
}