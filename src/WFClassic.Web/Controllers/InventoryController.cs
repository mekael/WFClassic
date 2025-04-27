using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WFClassic.Web.Logic.Inventory.Starting;

namespace WFClassic.Web.Controllers
{
    [ApiController]
    public class InventoryController : ControllerBase
    {

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
        public ActionResult Inventory(Guid accountId, long nonce)
        {

            return new JsonResult(cats);
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



        [HttpPost]
        [Route("/api/giveStartingGear.php")]
        public ActionResult GiveStartingGearPost([FromQuery] GiveStartingGear giveStartingGear)
        {
            string cats = "";



            string dogs = "";



            return new JsonResult(cats);
        }



        [HttpGet]
        [Route("/api/giveStartingGear.php")]
        public ActionResult GiveStartingGear([FromQuery]GiveStartingGear giveStartingGear)
        {
            string cats = "";



            string dogs = "";



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
 