import json
import os
import uuid
import pandas

folder_path = "./Lotus/Types/StoreItems/PowerSuits"
store_path = "/Lotus/Types/StoreItems/PowerSuits/"

file_listing = os.listdir(folder_path)


packages = []
package_items=[]

for file_name in file_listing:
    file_path = os.path.join(folder_path, file_name)
    print(f"processing {file_path}")
    json_data = {}
    with open(file_path) as fp:
       json_data= json.load(fp)
    
    item_name = file_name.replace(".json","")
    item_store_path = f"{store_path}{item_name}"
    
    id = str(uuid.uuid4()).upper()
    internal_inventory_name = json_data["data"]["TypeName"]
    premium_price = json_data["data"]["PremiumPrice"]


    packages.append({
                    "Id":id,
                    "ItemType":internal_inventory_name,
                    "CanBePurchasedMultipleTimes":1,
                    "CostInCredits":0,
                    "CostInPlat":premium_price,
                    "CanBePurchasedWithPlat":1,
                    "CanBePurchasedWithCredits":0,
                    "CreationTimestamp":"2025-05-07 22:01:19.6008208-05:00",
                    "LastModificationTimestamp":"2025-05-07 22:01:19.6008208-05:00"
                    })
    
    package_items.append(
    {
        "Id":id,
        "MarketPackageDefinitionId":id,
        "InternalInventoryItemType": 3,
        "IsUniqueItem": 1,
        "CanBeAddedRepeatedly":1,
        "ItemCountToBeAdded":1,
        "ItemType": internal_inventory_name,
        "ItemName": str(internal_inventory_name).split("/")[-1],
        "UpgradeVer": 101,
        "UnlockLevel": 1,
        "ExtraCapacity":4,
        "UpgradeFingerprint":"",
        "AddInventoryBin":1,
        "InventoryBinTypeToAdd":0,
        "NumberOfBinsToAdd":1,
        "CreationTimestamp":"2025-05-07 22:01:19.6008208-05:00",
        "LastModificationTimestamp":"2025-05-07 22:01:19.6008208-05:00"

    }
)



    for upgrade in json_data["data"]["DefaultUpgrades"]:
        upgrade_id = str(uuid.uuid4()).upper()
        package_items.append(
            {
                "Id":str(uuid.uuid4()).upper(),
                "MarketPackageDefinitionId":id,
                "InternalInventoryItemType": 4,
                "IsUniqueItem": 1,
                "CanBeAddedRepeatedly":1,
                "ItemCountToBeAdded":1,
                "ItemType": upgrade["ItemType"],
                "ItemName": str(upgrade["ItemType"]).split("/")[-1],
                "UpgradeVer": 0,
                "UnlockLevel": 0,
                "ExtraCapacity":0,
                "UpgradeFingerprint":"lvl=0|",
                "AddInventoryBin":0,
                "InventoryBinTypeToAdd":0,
                "NumberOfBinsToAdd":0,
                "CreationTimestamp":"2025-05-07 22:01:19.6008208-05:00",
                "LastModificationTimestamp":"2025-05-07 22:01:19.6008208-05:00",

            }
        )






pandas.DataFrame(packages).to_csv("./suit_packages.csv", index=None)
pandas.DataFrame(package_items).to_csv("./suit_package_items.csv", index=None)