namespace WFClassic.Web.Logic.WFAuth.WFLogout
{
    public class WarframeLogoutResult
    {
        public WarframeLogoutResultStatus WarframeLogoutResultStatus { get; set; }  
    }

    public enum WarframeLogoutResultStatus
    {
        Failure,
        BadRequest,
        NotFound,
        NonceDoesNotMatch, 
        Success,
    }
}
