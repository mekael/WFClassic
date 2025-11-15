using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Shared;

public class InMemoryLoginTracking
{

    public Dictionary<Guid, InMemoryLoginTrackingItem> LoggedInUserListing = new Dictionary<Guid, InMemoryLoginTrackingItem>(); 
}

public class InMemoryLoginTrackingItem
{
    public Guid AccountId { get; set; }
    public long Nonce { get; set; }
    public string UserIpAddress { get; set; }
    public string DisplayName { get; set; }

}


