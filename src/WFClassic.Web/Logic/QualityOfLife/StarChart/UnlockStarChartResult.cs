namespace WFClassic.Web.Logic.QualityOfLife.StarChart;

public class UnlockStarChartResult
{
    public UnlockStarChartResultStatus UnlockStarChartResultStatus { get; set; }
    public Guid PlayerId { get; set; }
}

public enum UnlockStarChartResultStatus
{
    Success,
    Failure,
    NotFound
}
