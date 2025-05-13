namespace WFClassic.Web.Logic.Credits.Get
{
    public class GetCreditsResult
    {
        public GetCreditsResultDetails GetCreditsResultDetails { get; set; }

        public GetCreditsResultStatus GetCreditsResultStatus { get; set; }
    }

    public enum GetCreditsResultStatus
    {
        ValidationErrors,
        Failure,
        Success,
    }

    public class GetCreditsResultDetails
    {
        public long PremiumCredits { get; set; }
        public long RegularCredits { get; set; }
    }
}