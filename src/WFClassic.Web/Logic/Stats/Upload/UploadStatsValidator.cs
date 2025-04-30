using FluentValidation;

namespace WFClassic.Web.Logic.Stats.Upload
{
    public class UploadStatsValidator : AbstractValidator<UploadStats>
    {
        public UploadStatsValidator() {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r=> r.StatsObject).NotEmpty();
        }
    }
}
