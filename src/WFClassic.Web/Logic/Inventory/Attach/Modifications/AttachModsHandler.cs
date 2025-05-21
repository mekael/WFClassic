using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.Attach.Modifications
{
    public class AttachModsHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AttachModsHandler> _logger;

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
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", attachMods.AccountId, attachMods.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }


            List<InventoryItemAttachment> modAttachments = null;

            try
            {
                modAttachments = _applicationDbContext.InventoryItemAttachments.Where(w => w.ParentInventoryItemId == Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                return result;
            }

            foreach (var upgradeToDetach in attachMods.IncomingAttachRequest.UpgradesToDetach)
            {
                InventoryItemAttachment attachment = modAttachments.Find(w => w.AttachedInventoryItemId == Guid.Parse(upgradeToDetach.ItemId.Id));
                _applicationDbContext.Entry(attachment).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            }

            foreach (var upgradeToAttach in attachMods.IncomingAttachRequest.UpgradesToAttach)
            {
                InventoryItemAttachment attachment = new InventoryItemAttachment()
                {
                    ParentInventoryItemId = Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id),
                    Slot = upgradeToAttach.Slot,
                    AttachedInventoryItemId = Guid.Parse(upgradeToAttach.ItemId.Id)
                };
                _applicationDbContext.InventoryItemAttachments.Add(attachment);
            }

            try
            {
                _applicationDbContext.SaveChanges();
                result.AttachModsResultStatus = AttachModsResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetInventoryHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
            }

            return result;
        }



    }
}