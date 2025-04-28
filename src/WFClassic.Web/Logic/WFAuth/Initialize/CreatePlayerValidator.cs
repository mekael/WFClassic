using FluentValidation;

namespace WFClassic.Web.Logic.WFAuth.Initialize
{
    public class CreatePlayerValidator : AbstractValidator<CreatePlayer>
    {

        public CreatePlayerValidator()
        {
            RuleFor(r => r.ApplicationUserId).NotEmpty();
            RuleFor(r=> r.PlatinumGiftAmount).GreaterThan(0);
        }

    }
}
