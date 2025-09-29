namespace WFClassic.Web.Logic.UI.SinglePlayer
{
    public class GetPlayerProfileInfoResult
    {
        public GetPlayerProfileInfoResultStatus GetPlayerProfileInfoResultStatus { get; set; }
        public GetPlayerProfileInfoResultDetails GetPlayerProfileInfoResultDetails { get; set; }
    }

    public enum GetPlayerProfileInfoResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }

    public class GetPlayerProfileInfoResultDetails
    {


        public string PlayerName { get; set; }
        public int MasteryRank { get; set; }
        public bool IsCurrentlyOnline { get; set; }
        public string CurrentLoginStreak {get;set;}
        public DateTime JoinedOnDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool IsBanned { get; set; }
        public int FounderLevel { get; set; }

    }

    public class GetPlayerProfileInfoResultDetailsAchievements
    {
        public string AchievementName { get; set; }
          
    }
}


/*
      username
             current mastery rank
            founder type
            current login streak
            current login status
            join date
            last login date
            is banned
            profile description ? 

            guild member
            rank in guild

 
 */