namespace WFClassic.Web.Logic.Sys.PlayerData
{
    public class DownloadPlayerDataResult
    {
        public DownloadPlayerDataResultStatus DownloadPlayerDataResultStatus { get; set; }
        public string FileName { get; set; }
        public byte[] JsonFile { get; set; }
    }

    public enum DownloadPlayerDataResultStatus
    {
        ValidationErrors,
        ServerError,
        Succsss

    }
}
