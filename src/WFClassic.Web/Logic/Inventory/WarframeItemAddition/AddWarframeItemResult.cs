namespace WFClassic.Web.Logic.Inventory.WarframeItemAddition
{
    public class AddWarframeItemResult
    {
        public AddWarframeItemResultStatus AddWarframeItemResultStatus { get; set; }
    }

    public enum AddWarframeItemResultStatus
    {
        ValidationErrors,
        DatabaseErrors,
        Success
    }
}