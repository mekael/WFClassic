using FluentValidation;

namespace WFClassic.Web.Logic.Foundry.Rush
{
    public class RushRecipeValidator : AbstractValidator<RushRecipe>
    {
        public RushRecipeValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.RecipeName).NotEmpty();
        }
    }
}