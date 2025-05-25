using FluentValidation;

namespace WFClassic.Web.Logic.Bonus.Daily
{
    public class GetDailyMissionBonusValidator : AbstractValidator<GetDailyMissionBonus>
    {
        public GetDailyMissionBonusValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}