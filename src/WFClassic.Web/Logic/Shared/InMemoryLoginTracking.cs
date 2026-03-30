namespace WFClassic.Web.Logic.Shared;

public class InMemoryLoginTracking
{

    public Dictionary<Guid, InMemoryLoginTrackingItem> LoggedInUserListing = new Dictionary<Guid, InMemoryLoginTrackingItem>();


    public InMemoryLoginTrackingItem GetUser(Guid userId)
    {
        if (LoggedInUserListing.ContainsKey(userId))
        {
            return LoggedInUserListing[userId];
        }
        throw new BadHttpRequestException("No User Found");
    }

    public bool RemoveLoggedInUser(Guid userId)
    {
        return this.LoggedInUserListing.Remove(userId);
    }

    public bool UserIsLoggedIn(Guid userId)
    {

        //TODO: add 24 hour check and log out user if they are beyond the 
        return LoggedInUserListing.ContainsKey(userId);
    }


    public void AddLoggedInUser(Guid userId, string displayName, long nonce, string userIpAddress, string buildLabel)
    {
        InMemoryLoginTrackingItem inMemoryLoginTrackingItem = new InMemoryLoginTrackingItem()
        {
            AccountId = userId,
            DisplayName = displayName,
            Nonce = nonce,
            UserIpAddress = userIpAddress,
            BuildLabel = buildLabel
        };

        if (this.LoggedInUserListing.ContainsKey(userId))
        {
            this.LoggedInUserListing[userId] = inMemoryLoginTrackingItem;
        }
        else
        {
            this.LoggedInUserListing.Add(userId, inMemoryLoginTrackingItem);
        }
    }

    public void ResetLoggedInUsers()
    {
        this.LoggedInUserListing.Clear();
    }
}

public class InMemoryLoginTrackingItem
{
    public string SessionId { get; set; }
    public string NatHash { get; set; }
    public Guid AccountId { get; set; }
    public long Nonce { get; set; }
    public string UserIpAddress { get; set; }
    public string DisplayName { get; set; }
    public string BuildLabel { get; set; }

}
