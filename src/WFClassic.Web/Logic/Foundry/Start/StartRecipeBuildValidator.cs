using FluentValidation;

namespace WFClassic.Web.Logic.Foundry.Start
{
     
    public class StartRecipeBuildValidator : AbstractValidator<StartRecipeBuild>    
    {
        public StartRecipeBuildValidator()
        {
            RuleFor(r=> r.AccountId).NotEmpty();
            RuleFor(r=> r.Nonce).GreaterThan(0);
            RuleFor(r => r.RecipeName).NotEmpty();
        }
    }
}
