namespace WFClassic.Web.Logic.Exp.Artifact
{
    public class UpgradeArtifactResult
    {
        public UpgradeArtifactResultStatus UpgradeArtifactResultStatus { get; set; }
    }

    public enum UpgradeArtifactResultStatus
    {
        Success,
        ValidationErrors,
        DatabaseErrors,

    }
}
