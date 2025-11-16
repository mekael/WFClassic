using System.Text.Json.Serialization;

using WFClassic.Web.Logic.SessionHandling;

namespace WFClassic.Web.Logic.Shared;

public class InMemoryLoginTracking
{

    public Dictionary<Guid, InMemoryLoginTrackingItem> LoggedInUserListing = new Dictionary<Guid, InMemoryLoginTrackingItem>();
    public Dictionary<Guid, WarframeSession> SessionsListing = new Dictionary<Guid, WarframeSession>();
}

public class InMemoryLoginTrackingItem
{
    public Guid AccountId { get; set; }
    public long Nonce { get; set; }
    public string UserIpAddress { get; set; }
    public string DisplayName { get; set; }

}
