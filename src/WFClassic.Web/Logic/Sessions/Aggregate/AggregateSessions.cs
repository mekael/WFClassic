namespace WFClassic.Web.Logic.Sessions.Aggregate;

public class AggregateSessions
{

    public Guid AccountId { get; set; }
    public long Nonce { get; set; }

    public AggregateSessionsJson AggregateSessionsJson { get; set; }
}

public class AggregateSessionsJson
{
    public long buildId { get; set; }
    public long regionId { get; set; }
}
