using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Inventory.Attach;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Starting;
using WFClassic.Web.Logic.Inventory.Update;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {


        UpdateInventoryHandler _updateInventoryHandler;
        GiveStartingGearHandler _giveStartingGearHandler;
        GetInventoryHandler _getInventoryHandler;
        AttachModsHandler _attachModsHandler;
        
        
        public InventoryController(GiveStartingGearHandler giveStartingGearHandler, GetInventoryHandler getInventoryHandler,
            UpdateInventoryHandler updateInventoryHandler, AttachModsHandler attachModsHandler)
        {
            _giveStartingGearHandler = giveStartingGearHandler;
            _getInventoryHandler = getInventoryHandler;
            _updateInventoryHandler = updateInventoryHandler;
            _attachModsHandler = attachModsHandler; 
        }

        [HttpGet]
        [Route("/api/inventorySlots.php")]
        public ActionResult InventorySlots(Guid accountId, long nonce)
        {

            return new JsonResult("{cats}");
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

            Console.WriteLine( JsonSerializer.Serialize(result.GetInventoryResultDetails));

            if (result.GetInventoryResultStatus == GetInventoryResultStatus.Success)
            {
                return new JsonResult(result.GetInventoryResultDetails,
        new JsonSerializerOptions { PropertyNamingPolicy = null });
            }
            else if (result.GetInventoryResultStatus == GetInventoryResultStatus.LoginCheckFailure)
            {
                return StatusCode(403);
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

        [HttpGet]
        [Route("/api/artifacts.php")]
        public ActionResult Artifacts(Guid accountId, long nonce)
        {

            return new JsonResult("{cats}");
        }

        [HttpPost]
        [Route("/api/upgrades.php")]
        public ActionResult AttachModsEndpoint([FromQuery] Guid accountId, [FromQuery] long nonce)
        {
            IncomingAttachRequest incomingAttachRequest = Utils.GetRequestObject<IncomingAttachRequest>(this.HttpContext);

            AttachMods attachMods = new AttachMods() { 
              AccountId = accountId,
              Nonce = nonce ,
              IncomingAttachRequest = incomingAttachRequest 
            }
            ;

              var result  = _attachModsHandler.Handle(attachMods);

            if(result.AttachModsResultStatus == AttachModsResultStatus.LoginCheckFailure)
            {
                return StatusCode(403) ;
            }
            else if (result.AttachModsResultStatus == AttachModsResultStatus.ValidationErrors)
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
            else if (result.Status == GiveStartingGearResultStatus.LoginCheckFailure)
            {
                return StatusCode(403);
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

