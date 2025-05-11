using FluentValidation;

namespace WFClassic.Web.Logic.Inventory.Loadout
{
    public class UpdateLoadoutValidator : AbstractValidator<UpdateLoadout>
    {


        public UpdateLoadoutValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.LoadoutState).NotEmpty();
        }
    }
}