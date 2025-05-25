namespace WFClassic.Web.Logic.Bonus.Daily
{
    public class GetDailyMissionBonusResult
    {
        public GetDailyMissionBonusResultStatus GetDailyMissionBonusResultStatus { get; set; }
        public GetDailyMissionBonusResultReturnJson GetDailyMissionBonusResultReturnJson { get; set; }
    }

    public enum GetDailyMissionBonusResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success,
        AlreadyProvided
    }

    public class GetDailyMissionBonusResultReturnJson
    {
        public int DailyMissionBonus { get; set; }
    }

 
}