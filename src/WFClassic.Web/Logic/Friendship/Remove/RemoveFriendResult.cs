namespace WFClassic.Web.Logic.Friendship.Remove
{
    public class RemoveFriendResult
    {
        public RemoveFriendResultStatus RemoveFriendResultStatus { get; set; }
    }

    public enum RemoveFriendResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}