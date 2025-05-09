namespace WFClassic.Web.Logic.Friendship.AddPending
{
    public class AddPendingFriendResult
    {
        public AddPendingFriendResultStatus AddPendingFriendResultStatus { get; set; }
    }
    public enum AddPendingFriendResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
