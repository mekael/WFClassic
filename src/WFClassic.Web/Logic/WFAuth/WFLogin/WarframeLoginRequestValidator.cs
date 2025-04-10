using FluentValidation;
using System.Text.Json.Serialization;

namespace WFClassic.Web.Logic.WFAuth.WFLogin
{
    public class WarframeLoginRequestValidator: AbstractValidator<WarframeLoginRequest>
    {
       public WarframeLoginRequestValidator()
        {
            RuleFor(rf => rf.email).EmailAddress();
            RuleFor(rf=> rf.password).NotEmpty();
        }

    }
}
