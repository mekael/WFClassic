
namespace WFClassic.Web.Logic.Shared;

public class WFClassicAdditionalData
{
    public Dictionary<string, string> Factions { get; set; }
    public Dictionary<string, string> MissionTypes { get; set; }
    public Dictionary<string, string> AlertIcons { get; set; }
    public Dictionary<string, string> FactionLevels { get; set; }
    public Dictionary<string, string> Vips { get; set; }
    public Dictionary<string, List<string>> ItemRewards { get; set; }
    public Dictionary<string, string> RandomizedRewards { get; set; }
    public Dictionary<string, string> EnemySpecs { get; set; }
    public Dictionary<string, List<string>> RandomAlertDescriptions { get; set; }
    public NodeDefinition[] NodeDefinitions { get; set; }
}



public class NodeDefinition
{
    public string Node { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public string Description { get { return $"{this.Region} - {this.Name}"; } }
}


public class ServerConfiguration
{
    public bool LockServerToBuild { get; set; }
    public bool AutomaticallyCreateAccountUponInitialLogin { get; set; }
    public bool AllowQualityOfLifeModifications { get; set; }
    public bool KillAllSessionsAtUTCDayChange { get; set; }
    public string BuildLabel { get; set; }
    public string ServerVersion {get;set;}
}