using FluentValidation;

namespace WFClassic.Web.Logic.Taunt
{
    public class AddTauntValidator : AbstractValidator<AddTaunt>
    {
        public AddTauntValidator()
        {
            RuleFor(r=> r).NotEmpty();
        }
    }
}
