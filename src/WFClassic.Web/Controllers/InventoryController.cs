using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Starting;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {

 

        GiveStartingGearHandler _giveStartingGearHandler;
        GetInventoryHandler _getInventoryHandler;
        public InventoryController(GiveStartingGearHandler giveStartingGearHandler, GetInventoryHandler getInventoryHandler)
        {
            _giveStartingGearHandler = giveStartingGearHandler;
            _getInventoryHandler = getInventoryHandler;
        }

        [HttpGet]
        [Route("/api/inventorySlots.php")]
        public ActionResult InventorySlots(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }
        [HttpGet]
        [Route("/api/updateInventory.php")]
        public ActionResult UpdateInventory(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
        }

      

        [HttpGet]
        [Route("/api/inventory.php")]
        public ActionResult Inventory([FromQuery] GetInventory getInventory)
        {
            GetInventoryResult result = _getInventoryHandler.Handle(getInventory);

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

            return new JsonResult(cats);
        }

        [HttpGet]
        [Route("/api/upgrades.php")]
        public ActionResult AttachMods(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
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

            return new JsonResult(cats);
        }





        string cats = @"{}";
    }

}

public class Rootobject
{
    public string Category { get; set; }
    public Weapon Weapon { get; set; }
    public Upgrade[] UpgradesToAttach { get; set; }
    public Upgrade[] UpgradesToDetach { get; set; }
    public int Cost { get; set; }
    public string UpgradeReq { get; set; }
}

public class Weapon
{
    public string ItemType { get; set; }
    public Itemid ItemId { get; set; }
    public int XP { get; set; }
    public int UpgradeVer { get; set; }
    public int UnlockLevel { get; set; }
    public int ExtraCapacity { get; set; }
    public int ExtraRemaining { get; set; }
}

public class Itemid
{
    public string id { get; set; }
}

public class Upgrade
{
    public string ItemType { get; set; }
    public Itemid ItemId { get; set; }
    public string UpgradeFingerprint { get; set; }
    public int Slot { get; set; }
    public Itemid ParentId { get; set; }
}
