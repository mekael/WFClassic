namespace WFClassic.Web.Logic.Inventory.Attach
{
    public class AttachModsResult
    {
      public AttachModsResultStatus AttachModsResultStatus { get; set; }
    }
    public enum AttachModsResultStatus
    {
        ValidationErrors,
        LoginCheckFailure,
        AlreadyReceivedStartingGear,
        DatabaseErrors,
        MappingFailure,
        Success
    }

}
