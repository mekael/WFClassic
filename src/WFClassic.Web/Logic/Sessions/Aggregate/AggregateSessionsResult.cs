using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.Sessions.Aggregate;

public class AggregateSessionsResult
{
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public AggregateSessionsResultStatus AggregateSessionsResultStatus { get; set; }
    [JsonPropertyName("Results")]

    public List<AggregateSessionsResultItem> Results { get; set; } = new List<AggregateSessionsResultItem>();
}

public class AggregateSessionsResultItem
{
    public long gameModeId { get; set; }
    public long count { get; set; }
}


public enum AggregateSessionsResultStatus
{
    ValidationErrors,
    DatabaseErrors,
    MappingFailure,
    Success
}
