import pandas as pd
import json


def getNameAndPrettyName(rawRecipe: str):
    if str(rawRecipe) =="nan":
        return "", "", False
    elif  rawRecipe.startswith("/") or rawRecipe.find("(") == -1: 
        return rawRecipe, rawRecipe, True   
    prettyName = rawRecipe.split("(")[0]
    resultName = rawRecipe.split("(")[1].split(")")[0]

    return resultName, prettyName, True


def createMaterialRecord(rawRecipe: str, itemCount):
    materialItemName, materialPrettyName, includeMaterial = getNameAndPrettyName(rawRecipe)

    if includeMaterial:
        return {"ItemName": materialItemName, "PrettyName" :  materialPrettyName, "ItemCountNeeded": itemCount}


cat = pd.read_csv("itemInfo/recipes.csv", delimiter="," )


recipeListing = []

for index, recipe in cat.iterrows():

    rawRecipe :str = str(recipe["ResultItem"]) 
    resultItemName , resultItemPrettyName, _ =  getNameAndPrettyName(rawRecipe)


    materials = [ createMaterialRecord(recipe["Mat1"], recipe["Mat1Count"]),
                 createMaterialRecord(recipe["Mat2"], recipe["Mat2Count"]),
                 createMaterialRecord(recipe["Mat3"], recipe["Mat3Count"]),
                 createMaterialRecord(recipe["Mat4"], recipe["Mat4Count"])
                 ]

    materials = list(filter(None, materials))


    recipeListing.append( {
        "ResultItemName" : resultItemName, 
        "ResultItemPrettyName" : resultItemPrettyName,
        "BuildTimeInSeconds" : recipe["BuildTime"],
        "PriceInStandardCredits" : recipe["Price"],
        "SkipBuildPriceInPlatinum" : recipe["SkipBuildPrice"],
        "RecipeItems": materials
    })

 
print(json.dumps(recipeListing, indent=5))



 

'''
ResultItem,
Mat1,
Mat1Count,
Mat2,
Mat2Count,
Mat3,
Mat3Count,
Mat4,
Mat4Count,
BuildTime,
Price,
SkipBuildPrice
'''