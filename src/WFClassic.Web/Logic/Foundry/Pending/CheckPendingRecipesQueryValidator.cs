using FluentValidation;

namespace WFClassic.Web.Logic.Foundry.Pending
{
    public class CheckPendingRecipesQueryValidator : AbstractValidator<CheckPendingRecipesQuery>
    {
        public CheckPendingRecipesQueryValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
        }
    }
}