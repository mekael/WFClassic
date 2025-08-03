import json
import os
import uuid
import pandas as pd


# get the list of items in the directory

directory_path = "./Lotus/Types/StoreItems/Skins/"

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
 


    if not jsn.get("ShowInMarket"):
        package_id = str(uuid.uuid4()).upper()
        data : dict = jsn["data"]

        market_packages.append({
                        "Id":package_id,
                        "ItemType":data["TypeName"],
                        "CanBePurchasedMultipleTimes":0,
                        "CostInCredits": data["RegularPrice"] if data.get("RegularPrice") else 0,
                        "CostInPlat": data["PremiumPrice"] if data.get("PremiumPrice") else 0,
                        "CanBePurchasedWithPlat":1 if data.get("PremiumPrice") else 0,
                        "CanBePurchasedWithCredits":1 if data.get("RegularPrice") else 0,
                        "CreationTimestamp":"2025-06-26 22:01:19.6008208-05:00",
                        "LastModificationTimestamp":"2025-06-26 22:01:19.6008208-05:00"
                        })
        

 
        market_package_items.append(
        {
            "Id":package_id,
            "MarketPackageDefinitionId":package_id,
            "InternalInventoryItemType": 6,
            "IsUniqueItem": 1,
            "CanBeAddedRepeatedly":0,
            "ItemCountToBeAdded":1,
            "ItemType": data["TypeName"],
            "ItemName": str(data["TypeName"]).split("/")[-1],
            "UpgradeVer": 0,
            "UnlockLevel": 0,
            "ExtraCapacity":0,
            "UpgradeFingerprint":"",
            "AddInventoryBin":0,
            "InventoryBinTypeToAdd":0,
            "NumberOfBinsToAdd":0,
            "CreationTimestamp":"2025-06-26 22:01:19.6008208-05:00",
            "LastModificationTimestamp":"2025-06-26 22:01:19.6008208-05:00"

        })


pd.DataFrame(market_packages).to_csv("./skins_packages.csv", index=False)
pd.DataFrame(market_package_items).to_csv("./skins_package_items.csv", index= False)
