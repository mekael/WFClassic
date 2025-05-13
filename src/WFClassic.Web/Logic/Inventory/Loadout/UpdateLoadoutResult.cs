namespace WFClassic.Web.Logic.Inventory.Loadout
{
    public class UpdateLoadoutResult
    {
        public UpdateLoadoutResultStatus UpdateLoadoutResultStatus { get; set; }
    }

    public enum UpdateLoadoutResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}