using System.Text.Json;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Models;

namespace WFClassic.Web.Logic.Inventory.Attach.Forma
{
    public class FuseFormaHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<FuseFormaHandler> _logger;

        public FuseFormaHandler(ApplicationDbContext applicationDbContext, ILogger<FuseFormaHandler> logger)
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
                _logger.LogError("FuseFormaHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", attachMods.AccountId, attachMods.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }

            InventoryItem itemToPolarize = null;
            InventoryItem formaItem = null;
            List<InventoryItemAttachment> modAttachments = null;

            //todo: get the polarization(s) from the 

            try
            {
                itemToPolarize = this._applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.Id == Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id) && fod.Player.ApplicationUserId == attachMods.AccountId);
                formaItem = this._applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.ItemType == attachMods.IncomingAttachRequest.PolarizeReq && fod.Player.ApplicationUserId == attachMods.AccountId);
                modAttachments = this._applicationDbContext.InventoryItemAttachments.Where(w => w.ParentInventoryItemId == Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("FuseFormaHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                return result;
            }

            if (itemToPolarize == null || formaItem == null || formaItem.ItemCount == 0)
            {
                _logger.LogError("FuseFormaHandler => accountId {AccountID} nonce {Nonce} => /User does not have the requisite item or forma.", attachMods.AccountId, attachMods.Nonce);
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }

            // remove all attached mods
            modAttachments.ForEach(fe => { this._applicationDbContext.Entry(fe).State = Microsoft.EntityFrameworkCore.EntityState.Deleted; });

            //decrement forma count
            formaItem.ItemCount--;
            this._applicationDbContext.Entry(formaItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            //reset item xp. 
            // TODO: decide if we want to reset the metrics as well. 
            itemToPolarize.XP = 0;
            // mark item as polarized
            itemToPolarize.Polarized = 1;
            if (!string.IsNullOrWhiteSpace(itemToPolarize.PolarityDefinition))
            {
                Dictionary<int, string> polarityDefs = JsonSerializer.Deserialize<Dictionary<int, string>>(itemToPolarize.PolarityDefinition);
                polarityDefs[attachMods.IncomingAttachRequest.PolarizeSlot] = attachMods.IncomingAttachRequest.PolarizeValue;
                itemToPolarize.PolarityDefinition = JsonSerializer.Serialize(polarityDefs);
            }
            this._applicationDbContext.Entry(itemToPolarize).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


            try
            {
                _applicationDbContext.SaveChanges();
                result.AttachModsResultStatus = AttachModsResultStatus.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError("FuseFormaHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
            }

            return result;
        }



    }
}