namespace WFClassic.Web.Logic.AlertConfig.Add;

public class AddAlertConfiguration
{
    public bool IsActive { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }

    public bool AllowReplay { get; set; }


    // select list types

    public string MissionType { get; set; }
    public string Faction { get; set; }
    public string Icon { get; set; }
    public string Location { get; set; }
    public string LevelOverride { get; set; }
    public string VIPAgent { get; set; }
    public string RandomizedItems { get; set; }  
    public string EnemySpec { get; set; }


    public float Difficulty { get; set; } = 1.0f;
    public string Description { get; set; }
    public string IntroText { get; set; }
    public string CompletionText { get; set; }
    public string UniqueName { get; set; }

    public int Credits { get; set; } = 2500;
    public int Xp { get; set; } = 0;

    public List<string> RewardItems { get; set; }

}
