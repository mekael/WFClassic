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
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .RULER.ToString(), Permissions =0 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .RECRUITER.ToString(), Permissions =1 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .REGULATOR.ToString(), Permissions =2 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .PROMOTION.ToString(), Permissions =3 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .ARCHITECT.ToString(), Permissions =4 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .TREASURER.ToString(), Permissions =5 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .TECH.ToString(), Permissions =6 },
                                                                                                    new GetGuildResultRanksJson(){ Name = GuildRank .HOST.ToString(), Permissions =7 }
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
                guild = (guildId.HasValue) ? this._applicationDbContext.Guilds.Include(i => i.GuildMembers).FirstOrDefault(w => w.Id == guildId.Value) : null;
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
                result.GetGuildResultJson = new GetGuildResultJson()
                {
                      Members = guild.GuildMembers.Select(s=> new GetGuildResultMemberJson() {  Name=s.UserDisplayName, Rank= Convert.ToInt32( s.CurrentGuildRank)+1, _id= new MongoId(s.UserId), Status =0 }).ToList(),
                       _id = new MongoId(guild.Id),
                        Ranks = this._guildRanks
                };
            }
            else
            {

            }

            return result;
        }
    }
}

/*
 Ruler =0
 Recruiter =1
Regulator =2
Promotion =3,
 
 */