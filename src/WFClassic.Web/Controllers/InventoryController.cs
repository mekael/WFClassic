using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Economics.Slots;
using WFClassic.Web.Logic.Exp.Artifact;
using WFClassic.Web.Logic.Inventory.Attach;
using WFClassic.Web.Logic.Inventory.Attach.Modifications;
using WFClassic.Web.Logic.Inventory.Attach.Orokin;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Loadout;
using WFClassic.Web.Logic.Inventory.Starting;
using WFClassic.Web.Logic.Inventory.Update;
using WFClassic.Web.Logic.Middleware;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    [TypeFilter(typeof(LoginVerificationActionFilter))]
    public class InventoryController : ControllerBase
    {
        private UpdateInventoryHandler _updateInventoryHandler;
        private GiveStartingGearHandler _giveStartingGearHandler;
        private GetInventoryHandler _getInventoryHandler;
        private AttachModsHandler _attachModsHandler;
        private UpgradeArtifactHandler _upgradeArtifactHandler;
        private UpdateLoadoutHandler _updateLoadoutHandler;
        private AttachOrokinModHandler _attachOrokinModHandler;
        private PurchaseSlotsHandler _purchaseSlotsHandler;
        public InventoryController(GiveStartingGearHandler giveStartingGearHandler, GetInventoryHandler getInventoryHandler,
            UpdateInventoryHandler updateInventoryHandler, AttachModsHandler attachModsHandler, UpgradeArtifactHandler upgradeArtifactHandler,
            UpdateLoadoutHandler updateLoadoutHandler, AttachOrokinModHandler attachOrokinModHandler, PurchaseSlotsHandler purchaseSlotsHandler)
        {
            _giveStartingGearHandler = giveStartingGearHandler;
            _getInventoryHandler = getInventoryHandler;
            _updateInventoryHandler = updateInventoryHandler;
            _attachModsHandler = attachModsHandler;
            _upgradeArtifactHandler = upgradeArtifactHandler;
            _updateLoadoutHandler = updateLoadoutHandler;
            _attachOrokinModHandler = attachOrokinModHandler;
            _purchaseSlotsHandler = purchaseSlotsHandler;
        }

        [HttpPost]
        [Route("/api/inventorySlots.php")]
        public ActionResult InventorySlots([FromQuery]Guid accountId, [FromQuery] long nonce)
        {

            PurchaseSlots purchaseSlots = new PurchaseSlots()
            {
                AccountId = accountId,
                Nonce = nonce,
                IncomingPurchaseSlotsJsonObject = Utils.GetRequestObjectAsString(this.HttpContext)
            };

            var result = _purchaseSlotsHandler.Handle(purchaseSlots);
            if (result.PurchaseSlotsResultStatus == PurchaseSlotsResultStatus.Success)
            {
                return Ok();
            }
            else if (result.PurchaseSlotsResultStatus == PurchaseSlotsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.PurchaseSlotsResultStatus == PurchaseSlotsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/saveLoadout.php")]
        public ActionResult SaveCurrentLoadout([FromQuery] UpdateLoadout updateLoadout)
        {
            updateLoadout.LoadoutState = Utils.GetRequestObjectAsString(this.HttpContext);
            var result = _updateLoadoutHandler.Handle(updateLoadout);
            if (result.UpdateLoadoutResultStatus == UpdateLoadoutResultStatus.Success)
            {
                return Ok();
            }
            else if (result.UpdateLoadoutResultStatus == UpdateLoadoutResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.UpdateLoadoutResultStatus == UpdateLoadoutResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }
            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/updateInventory.php")]
        public ActionResult UpdateInventoryEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            UpdateInventory updateInventory = new UpdateInventory()
            {
                AccountId = accountId,
                Nonce = nonce,
                UpdateInventoryFromMissionObject = Utils.GetRequestObject<UpdateInventoryFromMissionObject>(this.HttpContext)
            };

            var result = _updateInventoryHandler.Handle(updateInventory);

            return new JsonResult("{cats}");
        }

        [HttpGet]
        [Route("/api/inventory.php")]
        public ActionResult Inventory([FromQuery] GetInventory getInventory)
        {
            GetInventoryResult result = _getInventoryHandler.Handle(getInventory);


            if (result.GetInventoryResultStatus == GetInventoryResultStatus.Success)
            {
                return new JsonResult(result.GetInventoryResultDetails, new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetInventoryResultStatus == GetInventoryResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.GetInventoryResultStatus == GetInventoryResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        //accountId=c64c1e01-34d6-4311-ae40-7baa5eba3016&nonce=5060132779479405351&steamId=0
        [HttpPost]
        [Route("/api/artifacts.php")]
        public ActionResult Artifacts(Guid accountId, long nonce, long steamId)
        {
            UpgradeArtifact upgradeArtifact = new UpgradeArtifact()
            {
                AccountId = accountId,
                Nonce = nonce,
                IncomingUpgradeArtifactRequest = Utils.GetRequestObject<IncomingUpgradeArtifactRequest>(this.HttpContext)
            };




            var result = _upgradeArtifactHandler.Handle(upgradeArtifact);

            if (result.UpgradeArtifactResultStatus == UpgradeArtifactResultStatus.Success)
            {
                return Ok();
            }
            else if (result.UpgradeArtifactResultStatus == UpgradeArtifactResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.UpgradeArtifactResultStatus == UpgradeArtifactResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("/api/upgrades.php")]
        public ActionResult AttachModsEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            IncomingAttachRequest incomingAttachRequest = Utils.GetRequestObject<IncomingAttachRequest>(this.HttpContext);

            AttachMods attachMods = new AttachMods()
            {
                AccountId = accountId,
                Nonce = nonce,
                IncomingAttachRequest = incomingAttachRequest
            }
            ;
            AttachModsResult result = null;
            if (incomingAttachRequest.UpgradesToAttach.Count() == 0
                && incomingAttachRequest.UpgradesToDetach.Count() == 0)
            {
                result = _attachOrokinModHandler.Handle(attachMods);

            }
            else {
                result = _attachModsHandler.Handle(attachMods);
            }


            result = _attachModsHandler.Handle(attachMods);

            if (result.AttachModsResultStatus == AttachModsResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.AttachModsResultStatus == AttachModsResultStatus.MappingFailure
                || result.AttachModsResultStatus == AttachModsResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return new JsonResult("");
        }

        [HttpGet]
        [Route("/api/giveStartingGear.php")]
        public ActionResult GiveStartingGear([FromQuery] GiveStartingGear giveStartingGear)
        {
            var result = _giveStartingGearHandler.Handle(giveStartingGear);

            if (result.Status == GiveStartingGearResultStatus.Success)
            {
                return Ok();
            }
            else if (result.Status == GiveStartingGearResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.Status == GiveStartingGearResultStatus.DatabaseErrors)
            {
                return StatusCode(500);
            }

            return StatusCode(500);
        }
    }
}