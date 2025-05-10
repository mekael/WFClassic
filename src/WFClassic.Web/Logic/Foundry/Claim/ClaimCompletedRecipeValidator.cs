using FluentValidation;
 
namespace WFClassic.Web.Logic.Foundry.Claim
{
     
    public class ClaimCompletedRecipeValidator : AbstractValidator<ClaimCompletedRecipe>    
    {
        public ClaimCompletedRecipeValidator()
        {
            RuleFor(r=> r.AccountId).NotEmpty();
            RuleFor(r=> r.Nonce).GreaterThan(0);
            RuleFor(r => r.RecipeName).NotEmpty();
        }
    }
}
