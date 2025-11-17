using FluentValidation;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Clans.Create
{
    public class AddGuildHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<AddGuildHandler> _logger;

        public AddGuildHandler(ApplicationDbContext applicationDbContext, ILogger<AddGuildHandler> logger)
        {
            this._applicationDbContext = applicationDbContext;
            this._logger = logger;
        }

        public AddGuildResult Handle(AddGuild addGuild)
        {
            AddGuildResult result = new AddGuildResult();
            var validationResults = new AddGuildValidator().Validate(addGuild);

            if (!validationResults.IsValid)
            {
                this._logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", addGuild.AccountId, addGuild.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AddGuildResultStatus = AddGuildResultStatus.ValidationErrors;
                return result;
            }

            string cleansedName = addGuild.GuildName.ToLower().Trim();
            bool guildAlreadyExists = true;
            ApplicationUser user = null;

            try
            {
                this._logger.LogInformation("AddGuildHandler => accountId {AccountID} nonce {Nonce} => Searching for existing guilds and guild associations ", addGuild.AccountId, addGuild.Nonce);
                guildAlreadyExists = this._applicationDbContext.Guilds.Any(a => a.CleansedName == cleansedName);
                user = this._applicationDbContext.Users.Find(addGuild.AccountId);
                this._logger.LogInformation("AddGuildHandler => accountId {AccountID} nonce {Nonce} =>  Search complete ", addGuild.AccountId, addGuild.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} => Error while querying for existing clans {Exception}", addGuild.AccountId, addGuild.Nonce, ex);
                result.AddGuildResultStatus = AddGuildResultStatus.DatabaseErrors;
                return result;
            }


            if (guildAlreadyExists)
            {
                this._logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} =>  Guild already exists", addGuild.AccountId, addGuild.Nonce);
                result.AddGuildResultStatus = AddGuildResultStatus.ValidationErrors;
                return result;
            }
            else if (user == null)
            {
                this._logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} =>  User does not exist", addGuild.AccountId, addGuild.Nonce);
                result.AddGuildResultStatus = AddGuildResultStatus.ValidationErrors;
                return result;
            }
            else if (user.CurrentGuildId.HasValue)
            {
                this._logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} =>  User is currently in a guild", addGuild.AccountId, addGuild.Nonce);
                result.AddGuildResultStatus = AddGuildResultStatus.ValidationErrors;
                return result;
            }
            Guid guildId = Guid.NewGuid();
            Guild guild = new Guild()
                                        {
                                            Id = guildId,
                                            CleansedName = cleansedName,
                                            DisplayName = addGuild.GuildName,
                                            Tier = 1,
                                            GuildMembers = new List<GuildMembership>()
                                                                                       {
                                                                                            new GuildMembership(){ Id= guildId, 
                                                                                                                   UserId = addGuild.AccountId, 
                                                                                                                   CurrentGuildRank= GuildRank.RULER, 
                                                                                                                   UserDisplayName= user.DisplayName}
                                                                                        }
                                        };

            user.CurrentGuildId = guildId;
            this._applicationDbContext.Entry(user).State = EntityState.Modified;
            try
            {
                this._logger.LogInformation("AddGuildHandler => accountId {AccountID} nonce {Nonce} => Persisting new guild ", addGuild.AccountId, addGuild.Nonce);
                this._applicationDbContext.Guilds.Add(guild);
                this._applicationDbContext.SaveChanges();
                this._logger.LogInformation("AddGuildHandler => accountId {AccountID} nonce {Nonce} => New guild persisted ", addGuild.AccountId, addGuild.Nonce);
                result.AddGuildResultStatus = AddGuildResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("AddGuildHandler => accountId {AccountID} nonce {Nonce} => Error while querying for existing clans {Exception}", addGuild.AccountId, addGuild.Nonce, ex);
                result.AddGuildResultStatus = AddGuildResultStatus.DatabaseErrors;
            }


            return result;
        }
    }
}