using Microsoft.EntityFrameworkCore;

using WFClassic.Web.Data;
using WFClassic.Web.Data.Enums;
using WFClassic.Web.Data.Models;


namespace WFClassic.Web.Logic.Inventory.Attach.Orokin
{
    public class AttachOrokinModHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<AttachOrokinModHandler> _logger;

        private readonly List<InternalInventoryItemType> catalystTypes = new List<InternalInventoryItemType>() {
            InternalInventoryItemType.Melee,
            InternalInventoryItemType.LongGuns,
            InternalInventoryItemType.Pistols,
                        InternalInventoryItemType.SentinelWeapons,

        };
        private readonly List<InternalInventoryItemType> reactorTypes = new List<InternalInventoryItemType>() {
            InternalInventoryItemType.Sentinels,
            InternalInventoryItemType.Suits,

        };


        public AttachOrokinModHandler(ApplicationDbContext applicationDbContext, ILogger<AttachOrokinModHandler> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }
        /// <summary>
        /// Attaches a potato. 
        /// </summary>
        /// <param name="attachMods"></param>
        /// <returns></returns>
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
                _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => searching for item to upgrade and reactor/catalyst", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                Guid idOfItemToUpgrade = Guid.Parse(attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                itemToUpgrade = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.Id == idOfItemToUpgrade && fod.Player.ApplicationUserId == attachMods.AccountId);
                orokinItem = _applicationDbContext.InventoryItems.FirstOrDefault(fod => fod.InternalInventoryItemType == InternalInventoryItemType.MiscItems &&
                                                                    fod.ItemType == attachMods.IncomingAttachRequest.UpgradeReq
                                                                    && fod.Player.ApplicationUserId == attachMods.AccountId);
                _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => Query complete", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);



            }
            catch (Exception ex)
            {
                _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} =>  Error while searching for upgrade items {Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                return result;
            }

            if (IsAbleTOBeUpgraded(itemToUpgrade, orokinItem))
            {
                _logger.LogInformation("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => Item is able to be upgraded", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                itemToUpgrade.UnlockLevel += 1;
                orokinItem.ItemCount -= 1;
                _applicationDbContext.Entry(itemToUpgrade).State = EntityState.Modified;
                _applicationDbContext.Entry(orokinItem).State = EntityState.Modified;

                try
                {
                    _logger.LogInformation("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => Persisting item upgrade", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);
                    _applicationDbContext.SaveChanges();
                    result.AttachModsResultStatus = AttachModsResultStatus.Success;
                    _logger.LogInformation("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => Completed", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);

                }
                catch (Exception ex)
                {
                    _logger.LogError("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} =>  Exception while saving update{Ex}", attachMods.AccountId, attachMods.Nonce, ex);
                    result.AttachModsResultStatus = AttachModsResultStatus.DatabaseErrors;
                }
            }
            else
            {
                _logger.LogInformation("AttachOrokinModHandler => accountId {AccountID} nonce {Nonce} itemID {ItemId} => Item has already been upgraded. leaving early", attachMods.AccountId, attachMods.Nonce, attachMods.IncomingAttachRequest.Weapon.ItemId.Id);

                result.AttachModsResultStatus = AttachModsResultStatus.ValidationErrors;
            }
            return result;
        }


        bool IsAbleTOBeUpgraded(InventoryItem itemToUpgrade, InventoryItem orokinItem)
        {

            bool retVal = true;
            if (itemToUpgrade == null || orokinItem == null)
            {
                retVal = false;
            }
            else if (!catalystTypes.Contains(itemToUpgrade.InternalInventoryItemType)  && !reactorTypes.Contains(itemToUpgrade.InternalInventoryItemType))
            {
                retVal = false;
            }

            else if (
                (catalystTypes.Contains(itemToUpgrade.InternalInventoryItemType) && orokinItem.ItemType != "/Lotus/Types/Items/MiscItems/OrokinCatalyst")
             || (reactorTypes.Contains(itemToUpgrade.InternalInventoryItemType) && orokinItem.ItemType != "/Lotus/Types/Items/MiscItems/OrokinReactor")
                )
            {
                retVal = false;
            }
            else if (itemToUpgrade.UnlockLevel == 1)
            {
                retVal = false;
            }
            return retVal;
        }



    }
}