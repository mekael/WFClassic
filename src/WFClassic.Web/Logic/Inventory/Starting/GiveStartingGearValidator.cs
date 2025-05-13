using FluentValidation;

namespace WFClassic.Web.Logic.Inventory.Starting
{
    public class GiveStartingGearValidator : AbstractValidator<GiveStartingGear>
    {
        public GiveStartingGearValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.WarframeName).NotEmpty();
        }
    }
}