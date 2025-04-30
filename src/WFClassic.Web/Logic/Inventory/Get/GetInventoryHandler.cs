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
        private IsUserOnlineQueryHandler _isUserOnlineQueryHandler;
        private GetCreditsHandler _getCreditsHandler;

        public GetInventoryHandler(ApplicationDbContext applicationDbContext, ILogger<GetInventoryHandler> logger, IsUserOnlineQueryHandler isUserOnlineQueryHandler, GetCreditsHandler getCreditsHandler)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _isUserOnlineQueryHandler = isUserOnlineQueryHandler;
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


            var isLoggedInResult = _isUserOnlineQueryHandler.Handle(new IsUserOnlineQuery(getInventory.AccountId, getInventory.Nonce) { });
            if (isLoggedInResult.IsUserOnlineQueryResultStatus != IsUserOnlineQueryResultStatus.IsLoggedIn)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => User is not currently logged in with current nonce", getInventory.AccountId, getInventory.Nonce);
                result.GetInventoryResultStatus = GetInventoryResultStatus.LoginCheckFailure;
                return result;
            }


            Player player = null;


            try
            {
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Starting Query for player", getInventory.AccountId, getInventory.Nonce);
                player = _applicationDbContext.Players
                    .Include(i => i.InventoryItems)
                    .Include(i=> i.InventoryBins)
                    .Include(i=> i.Missions)
                    .Include(i=> i.BankAccounts)
                    .FirstOrDefault(w => w.ApplicationUserId == getInventory.AccountId);
                _logger.LogInformation("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Query Complete for player ", getInventory.AccountId, getInventory.Nonce);

            }
            catch (Exception ex)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Exception while querying for player object : {Ex}", getInventory.AccountId, getInventory.Nonce, ex);
                result.GetInventoryResultStatus = GetInventoryResultStatus.LoginCheckFailure;
                return result;
            }

            try
            {
                result.GetInventoryResultDetails = GetInventoryMapper.Map(player);
                result.GetInventoryResultStatus = GetInventoryResultStatus.Success;
            }
            catch (Exception ex)
            {
                result.GetInventoryResultStatus = GetInventoryResultStatus.MappingFailure   ;
            }


            _logger.LogInformation(
                JsonSerializer.Serialize(result.GetInventoryResultDetails)
                );




            return result;
        }

    }
}
