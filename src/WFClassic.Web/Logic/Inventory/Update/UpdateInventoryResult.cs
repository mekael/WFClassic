 namespace WFClassic.Web.Logic.Inventory.Update
{
    public class UpdateInventoryResult
    {
        public UpdateInventoryResultStatus UpdateInventoryResultStatus { get; set; }
    }


    public enum UpdateInventoryResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
