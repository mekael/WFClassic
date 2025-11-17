using FluentValidation;

namespace WFClassic.Web.Logic.Clans.Create
{
    public class AddGuildValidator : AbstractValidator<AddGuild>
    {
        public AddGuildValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r=> r.GuildName).NotEmpty();
            //TODO: Add in checks to make sure the guild name is valid 
        }
    }
}