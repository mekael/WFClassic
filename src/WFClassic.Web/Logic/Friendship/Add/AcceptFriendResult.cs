namespace WFClassic.Web.Logic.Friendship.Add
{
    public class AcceptFriendResult
    {
        public AcceptFriendResultStatus AcceptFriendResultStatus { get; set; }
    }
    public enum AcceptFriendResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}
