using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Shared.Models;

namespace WFClassic.Web.Logic.Clans.Get
{
    public class GetGuildHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<GetGuildHandler> _logger;
        //TODO: allow customization at some point. 
        private readonly List<GetGuildResultRanksJson> _guildRanks = new List<GetGuildResultRanksJson>() {
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Warlord.ToString(), Permissions = (int)GuildRank .Warlord },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Recruiter.ToString(), Permissions = (int)GuildRank .Recruiter },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Regulator.ToString(), Permissions =(int)GuildRank .Regulator },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Promotion.ToString(), Permissions =(int)GuildRank .Promotion },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Architect.ToString(), Permissions =(int)GuildRank .Architect },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Treasurer.ToString(), Permissions =(int)GuildRank .Treasurer },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Tech.ToString(), Permissions =(int)GuildRank .Tech },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .Host.ToString(), Permissions =(int)GuildRank .Host },
        };

        public GetGuildHandler(ApplicationDbContext applicationDbContext, ILogger<GetGuildHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public GetGuildResult Handle(GetGuild getGuild)
        {
            GetGuildResult result = new GetGuildResult();

            Guild guild = null;

            try
            {
                this._logger.LogInformation("GetGuildHandler => accountId {AccountID} nonce {Nonce} => Searching for existing guilds and guild associations ", getGuild.AccountId, getGuild.Nonce);

                var guildId = this._applicationDbContext.Users.Find(getGuild.AccountId)?.CurrentGuildId;
                guild = guildId.HasValue ? this._applicationDbContext.Guilds.Include(i => i.GuildMembers).FirstOrDefault(w => w.Id == guildId.Value) : null;
                this._logger.LogInformation("GetGuildHandler => accountId {AccountID} nonce {Nonce} =>  Search complete ", getGuild.AccountId, getGuild.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetGuildHandler => accountId {AccountID} nonce {Nonce} => Error while querying for existing clans {Exception}", getGuild.AccountId, getGuild.Nonce, ex);
                result.GetGuildResultStatus = GetGuildResultStatus.DatabaseErrors;
                return result;
            }

            if (guild != null)
            {
                this._logger.LogInformation("GetGuildHandler => accountId {AccountID} nonce {Nonce} => Guild found {GuildId}", getGuild.AccountId, getGuild.Nonce, guild.Id);

                result.GetGuildResultJson = new GetGuildResultJson()
                {
                    Members = guild.GuildMembers.Select(s => new GetGuildResultMemberJson() { Name = s.UserDisplayName, Rank = Convert.ToInt32(s.CurrentGuildRank) , _id = new MongoId(s.UserId), Status = 0 }).ToList(),
                    _id = new MongoId(guild.Id),
                    Ranks = this._guildRanks
                };
            }
            else
            {
                this._logger.LogInformation("GetGuildHandler => accountId {AccountID} nonce {Nonce} => No guild found", getGuild.AccountId, getGuild.Nonce);
            }
            return result;
        }
    }
}
 