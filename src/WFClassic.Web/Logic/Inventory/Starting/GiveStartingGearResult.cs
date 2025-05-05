using Newtonsoft.Json;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public class GiveStartingGearResult
    {
    public GiveStartingGearResultStatus Status { get; set; }
    }

    public enum GiveStartingGearResultStatus
    {
        ValidationErrors,
        AlreadyReceivedStartingGear,
        DatabaseErrors,
        Success

    }
}
