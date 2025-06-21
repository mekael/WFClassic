namespace WFClassic.Web.Logic.UI.ListPlayers
{
    public class GetPlayerListResult
    {
        public int PageNumber { get; set; }
        public int NumberOfItemsPerPage { get; set; }
        public GetPlayerListResultStatus GetPlayerListResultStatus { get; set; }

        public List<GetPlayerListResultDetailItem> GetPlayerListResultDetailItems { get; set; }
    }

    public enum GetPlayerListResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }

    public class GetPlayerListResultDetailItem
    {

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public bool IsCurrentlyOnline { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime JoinedOnDate { get; set; }

    }
}
