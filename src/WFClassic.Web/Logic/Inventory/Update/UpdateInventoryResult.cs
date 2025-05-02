 namespace WFClassic.Web.Logic.Inventory.Update
{
    public class UpdateInventoryResult
    {
        public UpdateInventoryResultStatus UpdateInventoryResultStatus { get; set; }
    }


    public enum UpdateInventoryResultStatus
    {
        ValidationErrors,
        LoginCheckFailure,
        AlreadyReceivedStartingGear,
        DatabaseErrors,
        MappingFailure,
        Success
    }
}
