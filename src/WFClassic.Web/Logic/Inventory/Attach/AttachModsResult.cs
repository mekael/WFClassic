namespace WFClassic.Web.Logic.Inventory.Attach
{
    public class AttachModsResult
    {
        public AttachModsResultStatus AttachModsResultStatus { get; set; }
    }

    public enum AttachModsResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}