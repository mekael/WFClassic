namespace WFClassic.Web.Logic.WFAuth.Initialize
{
    public class CreatePlayerResult
    {
        public CreatePlayerResultStatus CreatePlayerResultStatus { get; set; }
    }

    public enum CreatePlayerResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}