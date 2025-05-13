using FluentValidation;

namespace WFClassic.Web.Logic.Stats.Leaderboard
{
    public class GetLeaderboardStatsValidator : AbstractValidator<GetLeaderboardStats>
    {
        public GetLeaderboardStatsValidator()
        {
            RuleFor(r => r.AccountId).NotEmpty();
            RuleFor(r => r.Nonce).GreaterThan(0);
            RuleFor(r => r.Field).NotEmpty();
        }
    }
}