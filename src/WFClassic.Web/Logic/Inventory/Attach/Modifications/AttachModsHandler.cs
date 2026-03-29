using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.Attach.Modifications
{
    public class AttachModsHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<AttachModsHandler> _logger;

        public AttachModsHandler(ApplicationDbContext applicationDbContext, ILogger<AttachModsHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        public AttachModsResult Handle(AttachMods attachMods)
        {
            AttachModsResult result = new AttachModsResult();
            var validationResults = new AttachModsValidator().Validate(attachMods);

            if (!validationResults.IsValid)
            {
                _logger.LogError("AttachModsHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", attachMods.AccountId, attachMods.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }



            List<string> inventoryItemIds = null;
            List<InventoryItemAttachment> modAttachments = null;
            InventoryItem associatedItem = null;
            Guid itemId = Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id);



            try
            {
                inventoryItemIds = this._applicationDbContext.Database.SqlQuery<string>($@"select ii.Id
                                                                                from InventoryItems ii 
                                                                                inner join players p on ii.PlayerId = p.Id
                                                                                where p.ApplicationUserId  = {attachMods.AccountId}").ToList();

                modAttachments = _applicationDbContext.InventoryItemAttachments.Where(w => w.ParentInventoryItemId == itemId).ToList();
                associatedItem = this._applicationDbContext.InventoryItems.FirstOrDefault(fod=> fod.Id == itemId);
            }
            catch (Exception ex)
            {
                _logger.LogError("AttachModsHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                return result;
            }



            if (inventoryItemIds.Count(cod => cod.Equals(attachMods.IncomingAttachRequest.Weapon.ItemId.Id, StringComparison.InvariantCultureIgnoreCase)) == 0)
            {
                _logger.LogError("AttachModsHandler => accountId {AccountID} nonce {Nonce} => User does not own item {ItemId}", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }
            else if (inventoryItemIds.Count(w => attachMods.IncomingAttachRequest.UpgradesToAttach.Select(s => s.ItemId.Id.ToUpper()).Contains(w.ToUpper())) != attachMods.IncomingAttachRequest.UpgradesToAttach.Count() )
            {

                _logger.LogError("AttachModsHandler => accountId {AccountID} nonce {Nonce} => User does not own one or more mods to be attached.", attachMods.AccountId, attachMods.Nonce);
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }


            foreach (var upgradeToDetach in attachMods.IncomingAttachRequest.UpgradesToDetach)
            {
                InventoryItemAttachment attachment = modAttachments.FirstOrDefault(w => w.AttachedInventoryItemId == Guid.Parse(upgradeToDetach.ItemId.Id));
                if (attachment != null)
                {
                    _applicationDbContext.Entry(attachment).State = EntityState.Deleted;
                }
            }

            foreach (var upgradeToAttach in attachMods.IncomingAttachRequest.UpgradesToAttach)
            {
                InventoryItemAttachment existingAttachment = modAttachments.FirstOrDefault(w => w.AttachedInventoryItemId == Guid.Parse(upgradeToAttach.ItemId.Id));
                if (existingAttachment != null)
                {
                    _applicationDbContext.Entry(existingAttachment).State = EntityState.Deleted;
                }

                InventoryItemAttachment attachment = new InventoryItemAttachment()
                {
                    ParentInventoryItemId = Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id),
                    Slot = upgradeToAttach.Slot,
                    AttachedInventoryItemId = Guid.Parse(upgradeToAttach.ItemId.Id)
                };
                _applicationDbContext.InventoryItemAttachments.Add(attachment);
            }

            associatedItem.UpgradeNodes = attachMods.IncomingAttachRequest.Weapon.UpgradeNodes;
            try
            {
                _applicationDbContext.SaveChanges();
                result.AttachModsResultStatus = AttachModsResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("AttachModsHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
            }

            return result;
        }
    }
}