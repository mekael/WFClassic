namespace WFClassic.Web.Data.Models;

public class OperationConfiguration : EntityBase
{
    public bool IsActive { get; set; }
    public DateTimeOffset StartDate { get; set; } // activation
    public DateTimeOffset EndDate { get; set; } //expiry

    public bool AllowReplay { get; set; } 
    public string Description { get; set; }
    public string OperationType { get; set; }
    public string TransmissionPath { get; set; }
    public int CurrentCompletionCount { get; set; }
    public int GoalCompletionCount { get; set; }
    public bool SuccessIndicator { get; set; }
    public string RewardItemType { get; set; }
    public int RewardItemCount { get; set; }
    public int RewardCreditsAmount { get; set; }

    public bool IsFusionMoaEvent { get; set; }
    public bool PostEventCompletionTaskCompleted { get; set; }
}
 