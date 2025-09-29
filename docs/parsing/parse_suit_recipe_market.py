import json
import os
import uuid
import pandas

folder_path = "./Lotus/Types/StoreItems/PowerSuits"
store_path = "/Lotus/Types/StoreItems/PowerSuits/"

file_listing = os.listdir(folder_path)
recipes = [
'/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint',
'/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint'

]

packages = []
package_items=[]

for item_name in recipes:
 
    
    item_store_path = item_name
    
    id = str(uuid.uuid4()).upper()
    internal_inventory_name = item_name
    premium_price = 0
    premium_price = 0


    packages.append({
                    "Id":id,
                    "ItemType":internal_inventory_name,
                    "CanBePurchasedMultipleTimes":1,
                    "CostInCredits":35000,
                    "CostInPlat":0,
                    "CanBePurchasedWithPlat":0,
                    "CanBePurchasedWithCredits":1,
                    "CreationTimestamp":"2025-05-07 22:01:19.6008208-05:00",
                    "LastModificationTimestamp":"2025-05-07 22:01:19.6008208-05:00"
                    })
    
    package_items.append(
    {
        "Id":id,
        "MarketPackageDefinitionId":id,
        "InternalInventoryItemType": 13,
        "IsUniqueItem": 0,
        "CanBeAddedRepeatedly":1,
        "ItemCountToBeAdded":1,
        "ItemType": internal_inventory_name,
        "ItemName": str(internal_inventory_name).split("/")[-1],
        "UpgradeVer": 0,
        "UnlockLevel": 0,
        "ExtraCapacity":0,
        "UpgradeFingerprint":"",
        "AddInventoryBin":0,
        "InventoryBinTypeToAdd":0,
        "NumberOfBinsToAdd":0,
        "CreationTimestamp":"2025-05-07 22:01:19.6008208-05:00",
        "LastModificationTimestamp":"2025-05-07 22:01:19.6008208-05:00"

    }
)

 


pandas.DataFrame(packages).to_csv("./suit_recipe_packages.csv", index=None)
pandas.DataFrame(package_items).to_csv("./suit_recipe_package_items.csv", index=None)