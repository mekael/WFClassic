using FluentValidation;

namespace WFClassic.Web.Logic.Stats.ProfileStats
{
    public class GetProfileStatsValidator : AbstractValidator<GetProfileStats>
    {
        public GetProfileStatsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.LookupId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}