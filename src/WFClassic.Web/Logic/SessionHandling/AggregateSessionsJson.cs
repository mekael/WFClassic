using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.SessionHandling;

public class AggregateSessionsRequest
{
    [JsonIgnore]
    public Guid AccountId { get; set; } 
    [JsonPropertyName("buildId")]
    public long BuildId { get; set; }
    [JsonPropertyName("regionId")]
    public long RegionId { get; set; }
}


public class AggregateSessionsResult
{
    public List<AggregateSessionsResultItem> Results { get; set; }
}

public class AggregateSessionsResultItem
{
    [JsonPropertyName("gameModeId")]
    public long GameModeId { get; set; }

    [JsonPropertyName("count")]
    public long Count { get; set; }
}