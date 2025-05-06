using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WFClassic.Web.Logic.Exp.Artifact;
using WFClassic.Web.Logic.Inventory.Attach;
using WFClassic.Web.Logic.Inventory.Get;
using WFClassic.Web.Logic.Inventory.Starting;
using WFClassic.Web.Logic.Inventory.Update;
using WFClassic.Web.Logic.Middleware;
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
        UpgradeArtifactHandler _upgradeArtifactHandler;

        public InventoryController(GiveStartingGearHandler giveStartingGearHandler, GetInventoryHandler getInventoryHandler,
            UpdateInventoryHandler updateInventoryHandler, AttachModsHandler attachModsHandler, UpgradeArtifactHandler upgradeArtifactHandler)
        {
            _giveStartingGearHandler = giveStartingGearHandler;
            _getInventoryHandler = getInventoryHandler;
            _updateInventoryHandler = updateInventoryHandler;
            _attachModsHandler = attachModsHandler;
            _upgradeArtifactHandler = upgradeArtifactHandler;
        }

        [HttpGet]
        [Route("/api/inventorySlots.php")]
        public ActionResult InventorySlots(Guid accountId, long nonce)
        {

            return new JsonResult("{cats}");
        }


        [HttpPost]
        [Route("/api/saveLoadout.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult SaveCurrentLoadout(Guid accountId, long nonce)
        {

            // 
            /*
             {
    "ItemId" : {
        "$id" : "Current"
    },
    "Name" : "",
    "Presets" : [
        {
            "ItemId" : {
                "$id" : "47d4ed2d-8a11-4375-89f3-fb51e84dd972"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -6904668,
                    -7378852,
                    -8113345,
                    -4277585,
                    -7696737
                ],
                "Skins" : [
                    "/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmet",
                    "",
                    ""
                ]
            }
        },
        {
            "ItemId" : {
                "$id" : "31dace59-46aa-4491-b1cd-9e98147b0d08"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -4539718,
                    -4539718,
                    -4539718,
                    -4539718,
                    -1
                ],
                "Skins" : [
                    "",
                    "",
                    ""
                ]
            }
        },
        {
            "ItemId" : {
                "$id" : "b63257eb-2cb4-4970-ab1e-7e568a4f9c2c"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -4539718,
                    -4539718,
                    -4539718,
                    -4539718,
                    -1
                ],
                "Skins" : [
                    "",
                    "",
                    ""
                ]
            }
        },
        {
            "ItemId" : {
                "$id" : "ffffffffffffffffffffffff"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -4539718,
                    -4539718,
                    -4539718,
                    -4539718,
                    -1
                ],
                "Skins" : [
                    "",
                    "",
                    ""
                ]
            }
        },
        {
            "ItemId" : {
                "$id" : "ffffffffffffffffffffffff"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -4539718,
                    -4539718,
                    -4539718,
                    -4539718,
                    -1
                ],
                "Skins" : [
                    "",
                    "",
                    ""
                ]
            }
        },
        {
            "ItemId" : {
                "$id" : "ffffffffffffffffffffffff"
            },
            "Customization" : {
                "Emblem" : "",
                "Colors" : [
                    -4539718,
                    -4539718,
                    -4539718,
                    -4539718,
                    -1
                ],
                "Skins" : [
                    "",
                    "",
                    ""
                ]
            }
        }
    ]
}
             
             */
            return null;
        }

        [HttpPost]
        [Route("/api/updateInventory.php")]
        [TypeFilter(typeof(LoginVerificationActionFilter))]
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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
        public ActionResult Inventory([FromQuery] GetInventory getInventory)
        {
            GetInventoryResult result = _getInventoryHandler.Handle(getInventory);

            Console.WriteLine(JsonSerializer.Serialize(result.GetInventoryResultDetails));

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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
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

            var result = _attachModsHandler.Handle(attachMods);

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
        [TypeFilter(typeof(LoginVerificationActionFilter))]
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

