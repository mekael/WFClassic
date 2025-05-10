using System.Runtime.CompilerServices;

namespace WFClassic.Web.Logic.Stats.ProfileStats
{
    public class GetProfileStatsResult
    {

        public GetProfileStatsResultsStatus GetProfileStatsResultsStatus { get; set; }
        public ProfileStatsItem ProfileStatsItem { get; set; }   
    }
    
    public enum GetProfileStatsResultsStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success,
        MappingErrors
    }


    public class ProfileStatsItem
    {
        public float TimePlayedSec { get; set; }
        public long Rating { get; set; }
        public long Rank { get; set; }
        public long MissionsCompleted { get; set; }
        public long MissionsFailed { get; set; }
        public long MissionsInterrupted { get; set; }
        public long MissionsDumped { get; set; }
        public long MissionsQuit { get; set; }
        public long CiphersSolved { get; set; }
        public long CiphersFailed { get; set; }
        public float CipherTime { get; set; }
        public long ReviveCount { get; set; }
        public long HealCount { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Weapon> Weapons { get; set; }
    }

    public class Enemy
    {
        public string type { get; set; }
        public long deaths { get; set; }
    }

    public class Weapon
    {
        public string type { get; set; }
        public float equipTime { get; set; }
        public long hits { get; set; }
        public long kills { get; set; }
        public long xp { get; set; }
        public long assists { get; set; }
        public long headshots { get; set; }
        public long fired { get; set; }

    }

 
}
