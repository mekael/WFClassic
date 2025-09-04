using FluentValidation;

using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class GetInventoryHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<GetInventoryHandler> _logger;
        private readonly GetCreditsHandler _getCreditsHandler;

        public GetInventoryHandler(ApplicationDbContext applicationDbContext, ILogger<GetInventoryHandler> logger, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _getCreditsHandler = getCreditsHandler;
        }

        public GetInventoryResult Handle(GetInventory getInventory)
        {
            GetInventoryResult result = new GetInventoryResult();
            var validationResults = new GetInventoryValidator().Validate(getInventory);

            if (!validationResults.IsValid)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", getInventory.AccountId, getInventory.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.GetInventoryResultStatus = GetInventoryResultStatus.ValidationErrors;
                return result;
            }

            Player player = null;
            List<InventoryItemAttachment> attachments = null;
            List<string> completedAlerts = null;

            try
            {
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", getInventory.AccountId, getInventory.Nonce);
                player = _applicationDbContext.Players
                    .AsSplitQuery()
                    .Include(i => i.InventoryItems)
                    .Include(i => i.InventoryBins)
                    .Include(i => i.Missions)
                    .Include(i => i.BankAccounts)
                    .Include(i => i.TauntHistoryItems)
                    .FirstOrDefault(w => w.ApplicationUserId == getInventory.AccountId);

                attachments = _applicationDbContext.InventoryItemAttachments.AsSplitQuery().Include(i => i.AttachedInventoryItem).Where(w => w.AttachedInventoryItem.PlayerId == player.Id).ToList();
                completedAlerts = this._applicationDbContext.Database.SqlQuery<string>(@$"
                                                                                            select ac.CompleteTag
                                                                                            from Missions m ,
                                                                                            AlertConfigurations ac 
                                                                                            where 
                                                                                            m.Tag = ac.CompleteTag
                                                                                            and m.PlayerId  = {player.Id}
                                                                                            ").ToList();
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", getInventory.AccountId, getInventory.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", getInventory.AccountId, getInventory.Nonce, ex);
                result.GetInventoryResultStatus = GetInventoryResultStatus.DatabaseErrors;
                return result;
            }

            try
            {
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Start of mapping onto result ", getInventory.AccountId, getInventory.Nonce);
                result.GetInventoryResultDetails = GetInventoryMapper.Map(player, attachments, completedAlerts);
                result.GetInventoryResultStatus = GetInventoryResultStatus.Success;
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => inventory query finished ", getInventory.AccountId, getInventory.Nonce);
            }
            catch (Exception ex)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception while mapping onto inventory result : {Ex}", getInventory.AccountId, getInventory.Nonce, ex);
                result.GetInventoryResultStatus = GetInventoryResultStatus.MappingFailure;
            }

            return result;
        }
    }
}