namespace WFClassic.Web.Logic.Stats.Upload
{
    public class UploadStatsResult
    {
        public UploadStatsResultStatus UploadStatsResultStatus { get; set; }    
    }
    public enum UploadStatsResultStatus
    {
        ValidationErrors,
        LoginCheckFailure,
        DatabaseErrors,
        Success
    }
}
