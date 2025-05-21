using Microsoft.EntityFrameworkCore;
using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;


namespace WFClassic.Web.Logic.Inventory.Attach.Orokin
{
    public class AttachOrokinModHandler
    {
        private ApplicationDbContext _applicationDbContext;
        private ILogger<AttachOrokinModHandler> _logger;

        private List<InternalInventoryItemType> weaponTypes = new List<InternalInventoryItemType>() {
            InternalInventoryItemType.Melee,
            InternalInventoryItemType.LongGuns,
            InternalInventoryItemType.Pistols,
            InternalInventoryItemType.Sentinels,
            InternalInventoryItemType.SentinelWeapons
        };

        public AttachOrokinModHandler(ApplicationDbContext applicationDbContext, ILogger<AttachOrokinModHandler> logger)
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
                _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} => Validation failure {ValidationErrors}", attachMods.AccountId, attachMods.Nonce, string.Join(";", validationResults.Errors.Select(s => $"{s.ErrorCode} {s.ErrorMessage}")));
                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
                return result;
            }

            InventoryItem itemToUpgrade = null;
            InventoryItem orokinItem = null;

            try
            {
                Guid idOfItemToUpgrade = Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                itemToUpgrade = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.Id == idOfItemToUpgrade && fod.Player.ApplicationUserId == attachMods.AccountId);
                orokinItem = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.InternalInventoryItemType == InternalInventoryItemType.MiscItems &&
                                                                    fod.ItemType == attachMods.IncomingAttachRequest.UpgradeReq
                                                                    && fod.Player.ApplicationUserId == attachMods.AccountId);
            }
            catch (Exception ex)
            {
                _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                return result;
            }

            if (IsAbleTOBeUpgraded(itemToUpgrade, orokinItem))
            {
                itemToUpgrade.UnlockLevel += 1;
                orokinItem.ItemCount -= 1;
                _applicationDbContext.Entry(itemToUpgrade).State = EntityState.Modified;
                _applicationDbContext.Entry(orokinItem).State = EntityState.Modified;

                try
                {
                    _applicationDbContext.SaveChanges();
                    result.AttachModsResultStatus = AttachModsResultStatus.Success;
                }
                catch (Exception ex)
                {
                    _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} =>  {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                    result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                }
            }
            else
            {
                result.AttachModsResultStatus = AttachModsResultStatus.Success;
            }
            return result;
        }


        bool IsAbleTOBeUpgraded(InventoryItem itemToUpgrade, InventoryItem orokinItem)
        {

            bool retVal = true;
            if (itemToUpgrade == null || orokinItem == null)
            {
                // can't find an item to upgrade or it's upgrade component.
                retVal = false;
            }
            else if (!weaponTypes.Contains(itemToUpgrade.InternalInventoryItemType) && itemToUpgrade.InternalInventoryItemType != InternalInventoryItemType.Suits)
            {
                // we've got a mismatch
                retVal = false;
            }
            else if ((weaponTypes.Contains(itemToUpgrade.InternalInventoryItemType) && orokinItem.ItemType != "/Lotus/Types/Items/MiscItems/OrokinCatalyst")
                || (itemToUpgrade.InternalInventoryItemType == InternalInventoryItemType.Suits && orokinItem.ItemType != "/Lotus/Types/Items/MiscItems/OrokinReactor")
                )
            {
                retVal = false;
            }
            else if (itemToUpgrade.UnlockLevel == 1)
            {
                //we've already done the upgrade
                retVal = false;
            }
            return retVal;
        }



    }
}