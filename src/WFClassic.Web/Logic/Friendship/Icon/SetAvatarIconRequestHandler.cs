using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Friendship.Icon
{
    public class SetAvatarIconRequestHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<SetAvatarIconRequestHandler> _logger;

        public SetAvatarIconRequestHandler(ApplicationDbContext applicationDbContext, ILogger<SetAvatarIconRequestHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public SetAvatarIconResult Handle(SetAvatarIconRequest setAvatarIconRequest)
        {
            SetAvatarIconResult result = new SetAvatarIconResult();

            var validationResults = new SetAvatarIconRequestValidator().Validate(setAvatarIconRequest);

            if (!validationResults.IsValid)
            {
                _logger.LogError("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.SetAvatarIconResultStatus = SetAvatarIconResultStatus.ValidationErrors;
                return result;
            }

            bool playerHasAvatarInInventory = false ;
 
            try
            {
                _logger.LogInformation("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} =>  checking to see if player has icon in inventory ", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce );
                playerHasAvatarInInventory = _applicationDbContext.InventoryItems.Any(a => a.Player.ApplicationUserId == setAvatarIconRequest.AccountId && a.ItemType == setAvatarIconRequest.AvatarImageType);
            }
            catch (Exception ex)
            {
                _logger.LogError("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while checking for player inventory {Ex}", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce, ex);
                result.SetAvatarIconResultStatus = SetAvatarIconResultStatus.DatabaseErrors;
                return result;
            }

            if(!playerHasAvatarInInventory)
            {
                _logger.LogError("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} =>  Player does not have avatar image in inventory  ", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce);
                result.SetAvatarIconResultStatus = SetAvatarIconResultStatus.ValidationErrors;
                return result;
            }

            try
            {
                _logger.LogInformation("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} =>  Player has item in inventory. updating player object ", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce);
                _applicationDbContext.Players.Where(w => w.ApplicationUserId == setAvatarIconRequest.AccountId).ExecuteUpdate(eu => eu.SetProperty(sp => sp.ActiveAvatarImageType, setAvatarIconRequest.AvatarImageType));
                _logger.LogInformation("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} =>  update successful ", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce);
                result.SetAvatarIconResultStatus = SetAvatarIconResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("SetAvatarIconRequestHandler => accountId {AccountID} nonce {Nonce} => Exception while updating player object   {Ex}", setAvatarIconRequest.AccountId, setAvatarIconRequest.Nonce, ex);
                result.SetAvatarIconResultStatus = SetAvatarIconResultStatus.DatabaseErrors;
            }
            return result;
        }
    }
}