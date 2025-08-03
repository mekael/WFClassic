import json
import os
import uuid
import pandas as pd


# get the list of items in the directory

directory_path = "./Lotus/Types/StoreItems/Weapons/"

files = os.listdir(directory_path)

market_packages= []
market_package_items = []

for file in files:
    file_path = os.path.join(directory_path, file)
    print(f"parsing ")
    with open(file_path) as fp:
        jsn : dict = json.load(fp)


    """
        "parent": "/Lotus/Types/Game/StoreItem",
        "data": {
            "TypeName": "/Lotus/Weapons/Tenno/Rifle/StartingRifle",
            "StartingGear": 1,
            "RegularPrice": 8000,
            "PremiumPrice": 50,
            "ProductCategory": "LongGuns"
        }
    """
    mappings = dict()
    mappings["Melee"] = 5
    mappings["LongGuns"] = 1
    mappings["Recipes"] = 13
    


    if not jsn.get("ShowInMarket"):
        package_id = str(uuid.uuid4()).upper()
        data : dict = jsn["data"]

        market_packages.append({
                        "Id":package_id,
                        "ItemType":data["TypeName"],
                        "CanBePurchasedMultipleTimes":1,
                        "CostInCredits": data["RegularPrice"] if data.get("RegularPrice") else 0,
                        "CostInPlat": data["PremiumPrice"] if data.get("PremiumPrice") else 0,
                        "CanBePurchasedWithPlat":1 if data.get("PremiumPrice") else 0,
                        "CanBePurchasedWithCredits":1 if data.get("RegularPrice") else 0,
                        "CreationTimestamp":"2025-06-26 22:01:19.6008208-05:00",
                        "LastModificationTimestamp":"2025-06-26 22:01:19.6008208-05:00"
                        })
        

        internal_inventory_item_type = mappings[data["ProductCategory"]] if data.get("ProductCategory") else 0

        market_package_items.append(
        {
            "Id":package_id,
            "MarketPackageDefinitionId":package_id,
            "InternalInventoryItemType": internal_inventory_item_type,
            "IsUniqueItem": 0,
            "CanBeAddedRepeatedly":1,
            "ItemCountToBeAdded":1,
            "ItemType": data["TypeName"],
            "ItemName": str(data["TypeName"]).split("/")[-1],
            "UpgradeVer": 101,
            "UnlockLevel": 1,
            "ExtraCapacity":0,
            "UpgradeFingerprint":"",
            "AddInventoryBin":1,
            "InventoryBinTypeToAdd":1,
            "NumberOfBinsToAdd":1,
            "CreationTimestamp":"2025-06-26 22:01:19.6008208-05:00",
            "LastModificationTimestamp":"2025-06-26 22:01:19.6008208-05:00"

        })


pd.DataFrame(market_packages).to_csv("./weapon_packages.csv", index=False)
pd.DataFrame(market_package_items).to_csv("./weapon_package_items.csv", index= False)
