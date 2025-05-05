using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Admin.CheckOnline;
using WFClassic.Web.Logic.Credits.Get;

namespace WFClassic.Web.Logic.Inventory.Get
{
    public class GetInventoryHandler
    {

        private ApplicationDbContext _applicationDbContext;
        private ILogger<GetInventoryHandler> _logger;
        private GetCreditsHandler _getCreditsHandler;

        public GetInventoryHandler(ApplicationDbContext applicationDbContext, ILogger<GetInventoryHandler> logger,  GetCreditsHandler getCreditsHandler)
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

            try
            {
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", getInventory.AccountId, getInventory.Nonce);
                player = _applicationDbContext.Players
                    .Include(i => i.InventoryItems)
                    .Include(i=> i.InventoryBins)
                    .Include(i=> i.Missions)
                    .Include(i=> i.BankAccounts)
                    .Include(i=> i.TauntHistoryItems)
                    .FirstOrDefault(w => w.ApplicationUserId == getInventory.AccountId);


                attachments = _applicationDbContext.InventoryItemAttachments.Include(i=> i.AttachedInventoryItem).Where(w=> w.AttachedInventoryItem.PlayerId == player.Id).ToList();


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
                result.GetInventoryResultDetails = GetInventoryMapper.Map(player, attachments);
                result.GetInventoryResultStatus = GetInventoryResultStatus.Success;
            }
            catch (Exception ex)
            {
                result.GetInventoryResultStatus = GetInventoryResultStatus.MappingFailure   ;
            }

 

            return result;
        }

    }
}
