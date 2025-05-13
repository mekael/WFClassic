namespace WFClassic.Web.Logic.Admin.CheckOnline
{
    public class IsUserOnlineQueryResult
    {
        public IsUserOnlineQueryResultStatus IsUserOnlineQueryResultStatus { get; set; }
    }

    public enum IsUserOnlineQueryResultStatus
    {
        IsLoggedIn,
        DatabaseIssues,
        UserNotFound,
        UserNotLoggedIn
    }
}