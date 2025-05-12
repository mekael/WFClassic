using FluentValidation;

namespace WFClassic.Web.Logic.Bonus.Rewards
{
    public class GetLoginRewardsValidator : AbstractValidator<GetLoginRewards>
    {


        public GetLoginRewardsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}