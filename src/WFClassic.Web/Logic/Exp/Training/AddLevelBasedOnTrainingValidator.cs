using FluentValidation;

namespace WFClassic.Web.Logic.Exp.Training
{
    public class AddLevelBasedOnTrainingValidator : AbstractValidator<AddLevelBasedOnTraining>
    {
        public AddLevelBasedOnTrainingValidator()
        {
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r=> r.NumLevelsGained).GreaterThanOrEqualTo(0);
        }
    }
}
