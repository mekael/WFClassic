namespace WFClassic.Web.Data.Models
{
    public class AlertConfiguration : EntityBase
    {
        public bool IsActive { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
      
        public int AllowReplay { get; set; }
        // Mission information
        public string MissionType { get; set; }
        public string Faction { get; set; }
        public string UniqueName { get; set; }
        public string Icon { get; set; }
        public int Unlocked { get; set; }
        public int Completions { get; set; }
        public int Seed { get; set; }

        public float Difficulty { get; set; }
        public string Description { get; set; }
        public string IntroText { get; set; }
        public string CompletionText { get; set; }
        public string Location { get; set; }
        public string LevelOverride { get; set; }
        public string EnemySpec { get; set; }
       
        public string VIPAgent { get; set; }
        public int MinEnemyLevel { get; set; }
        public int MaxEnemyLevel { get; set; }
        public string CompleteTag { get; set; }
        // end mission information

        public List<AlertRewardConfiguration> AlertRewardConfigurations { get; set; }
        public List<AlertEnemyConfiguration> AlertEnemyConfigurations { get; set; }

 





    }
}

