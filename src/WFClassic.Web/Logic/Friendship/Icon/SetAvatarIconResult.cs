namespace WFClassic.Web.Logic.Friendship.Icon
{
    public class SetAvatarIconResult
    {
        public SetAvatarIconResultStatus SetAvatarIconResultStatus { get; set; }
    }

    public enum SetAvatarIconResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}