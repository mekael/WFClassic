using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class WfItemRecipeRebuildData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
delete from RecipeItems;
delete from Recipes;

INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C5FF2F36-A76D-4A3C-9090-9E17D9B5C025', 0, '/Lotus/Types/StoreItems/Recipes/OrokinCatalystStoreItem', 'OrokinCatalystStoreItem', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 'OrokinCatalystBlueprint', 86400, 25000, 10, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BDBC6797-5207-4D3C-9758-473B1E581075', 0, '/Lotus/Types/StoreItems/Recipes/OrokinReactorStoreItem', 'OrokinReactorStoreItem', '/Lotus/Types/Recipes/Components/OrokinReactorBlueprint', 'OrokinReactorBlueprint', 86400, 35000, 10, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8D31D2FD-5C4E-4546-A1EE-F73755ADB0DF', 0, '/Lotus/Types/StoreItems/Skins/NinjaAltHelmetItem', 'NinjaAltHelmetItem', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 'AshAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('DCF50F59-66FD-4B1E-86B4-07108BBD23A8', 0, '/Lotus/Types/StoreItems/Skins/BansheeAltHelmetItem', 'BansheeAltHelmetItem', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 'BansheeAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D2956B45-D0FB-469E-89DF-47541676C343', 0, '/Lotus/Types/StoreItems/Skins/EmberAltHelmetItem', 'EmberAltHelmetItem', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 'EmberAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D74FC919-BBE4-4E19-81A6-E768A161F548', 0, '/Lotus/Types/StoreItems/Skins/ExcaliburAltHelmetItem', 'ExcaliburAltHelmetItem', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 'ExcaliburAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C209A6A2-A2FA-4B08-BB71-BE13958C27E3', 0, '/Lotus/Types/StoreItems/Skins/FrostAltHelmetItem', 'FrostAltHelmetItem', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 'FrostAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('03964B87-76CE-44F3-89B5-EA5723F29B87', 0, '/Lotus/Types/StoreItems/Skins/LokiAltHelmetItem', 'LokiAltHelmetItem', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 'LokiAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1B344D05-9D5B-4DAA-8BBB-1B741733705A', 0, '/Lotus/Types/StoreItems/Skins/MagAltHelmetItem', 'MagAltHelmetItem', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 'MagAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('55950CF3-9CDD-49BC-A7E9-9AFCFA5ADAE9', 0, '/Lotus/Types/StoreItems/Skins/JadeAltHelmetItem', 'JadeAltHelmetItem', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 'NyxAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('F8F44F12-8C4A-47F1-8C89-1157BB02F6FE', 0, '/Lotus/Types/StoreItems/Skins/RhinoAltHelmetItem', 'RhinoAltHelmetItem', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 'RhinoAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C1687C5E-AE74-44CA-9D9A-7FA334CF8A91', 0, '/Lotus/Types/StoreItems/Skins/SarynAltHelmetItem', 'SarynAltHelmetItem', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 'SarynAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('483E6A89-2738-4DA4-B2CF-64EB9A5E50CF', 0, '/Lotus/Types/StoreItems/Skins/TrinityAltHelmetItem', 'TrinityAltHelmetItem', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 'TrinityAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A4872899-6F06-4EF4-823C-1DBEB7268E7F', 0, '/Lotus/Types/StoreItems/Skins/VoltAltHelmetItem', 'VoltAltHelmetItem', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 'VoltAltHelmetBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8EE8846D-B7A3-475A-A1C8-701109613BCD', 0, '/Lotus/Types/StoreItems/Sentinels/ShadePowerSuitStoreItem', 'ShadePowerSuitStoreItem', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 'ShadeSentinelBlueprint', 86400, 15000, 30, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('391E8CC4-6BC3-4A31-8293-EE7101CBCEFD', 0, '/Lotus/Types/StoreItems/Sentinels/WyrmPowerSuitStoreItem', 'WyrmPowerSuitStoreItem', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 'WyrmSentinelBlueprint', 86400, 15000, 30, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('9F5EDD5B-A7FE-4C12-84AC-4255A7DD6A4A', 0, '/Lotus/Types/StoreItems/PowerSuits/AshStoreItem', 'AshStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'AshBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7002954A-3240-453E-8768-1419E9BDC57E', 0, '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 'AshChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisBlueprint', 'AshChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('104BE57C-BB4A-430E-B031-C6EAB9DF7E6A', 0, '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 'AshHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetBlueprint', 'AshHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('730A6609-CEE2-4624-9F5B-651118E12EED', 0, '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 'AshSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsBlueprint', 'AshSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D94E71A0-E9E4-4534-BE91-252E70681ABD', 0, '/Lotus/Types/StoreItems/PowerSuits/BansheeStoreItem', 'BansheeStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'BansheeBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ECB96050-90B9-462B-A22F-84184BED1B1B', 0, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 'BansheeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisBlueprint', 'BansheeChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('53B0F030-F758-477A-ACC9-F7DBB5C60916', 0, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 'BansheeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetBlueprint', 'BansheeHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('376990EE-0AAC-4946-818F-262E1FC1A71C', 0, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 'BansheeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsBlueprint', 'BansheeSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E9EF173D-5FF1-4A59-90B0-F3E7A74CD2E7', 0, '/Lotus/Types/StoreItems/PowerSuits/EmberStoreItem', 'EmberStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'EmberBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('71CC0BEF-C81A-4F83-A5A3-3144027D8CDF', 0, '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 'EmberChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisBlueprint', 'EmberChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8EF033A3-B312-4D6B-8773-43A800FA930C', 0, '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 'EmberHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetBlueprint', 'EmberHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8EC5E31F-7920-4E34-80E8-54028D0C0CBD', 0, '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 'EmberSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsBlueprint', 'EmberSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ABB0DB21-94A3-4A73-9161-3AD8F8635DB0', 0, '/Lotus/Types/StoreItems/PowerSuits/ExcaliburStoreItem', 'ExcaliburStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 'ExcaliburBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6C50B57A-B956-4CFE-BA4F-792D2BD817FD', 0, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 'ExcaliburChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisBlueprint', 'ExcaliburChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('87DB6CD3-EA3E-4549-B835-B93A3055C7C2', 0, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 'ExcaliburHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetBlueprint', 'ExcaliburHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0AFC0355-77DF-4F1F-9C87-477E45796C65', 0, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 'ExcaliburSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsBlueprint', 'ExcaliburSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E8CFD88C-799F-4A87-A11A-80F7C1779161', 0, '/Lotus/Types/StoreItems/PowerSuits/FrostStoreItem', 'FrostStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 'FrostBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('827AA174-A43C-433D-AC7B-DB6EAF126C27', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 'FrostChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisBlueprint', 'FrostChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2CE4AB70-8AA6-4E0E-B141-6307F673877B', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 'FrostHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetBlueprint', 'FrostHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('91497D81-636E-4E21-8E62-FDC4C4D9E6F5', 0, '/Lotus/Types/StoreItems/PowerSuits/FrostPrimeStoreItem', 'FrostPrimeStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 'FrostPrimeBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D4E7FABF-7EF6-4971-92AF-11694EC2C1C8', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 'FrostPrimeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisBlueprint', 'FrostPrimeChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0E4AEA9D-DDE3-4B4E-9DDE-A9C690482793', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 'FrostPrimeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetBlueprint', 'FrostPrimeHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('AD91BEC2-D3F5-4818-ACB7-44A93B27AF4F', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 'FrostPrimeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsBlueprint', 'FrostPrimeSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('311B66C6-7DCD-4AC9-B5A5-5A64786E2911', 0, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 'FrostSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsBlueprint', 'FrostSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('018463A0-643E-449D-9406-2F06353A07AC', 0, '/Lotus/Types/StoreItems/PowerSuits/LokiStoreItem', 'LokiStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 'LOKIBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0CAA198F-A9F3-4EEA-A178-D5E2237B47CA', 0, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 'LOKIChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisBlueprint', 'LOKIChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('9F97782C-A23D-40EC-85FF-012FA727DC9D', 0, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 'LOKIHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetBlueprint', 'LOKIHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A2EFB226-288F-4DFE-AD9C-0CF95B41D050', 0, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 'LOKISystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsBlueprint', 'LOKISystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('40B30656-FAD9-4164-A66C-44077158AB36', 0, '/Lotus/Types/StoreItems/PowerSuits/MagStoreItem', 'MagStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 'MagBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8BD4526A-B3BF-4BB2-9DE3-F8DBED389C42', 0, '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 'MagChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisBlueprint', 'MagChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('3D309B87-C622-4015-AEA2-BE7D162DC57E', 0, '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 'MagHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetBlueprint', 'MagHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('5738C720-4F2D-482E-813E-8F76958B6827', 0, '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 'MagSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsBlueprint', 'MagSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('732A201D-74AC-470E-9370-39B6E50CB04F', 0, '/Lotus/Types/StoreItems/PowerSuits/JadeStoreItem', 'JadeStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 'NyxBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4B5369C1-F85B-4AC5-8637-BE0167D56AC2', 0, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 'NyxChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisBlueprint', 'NyxChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A08EC1F6-EA57-479A-ACBA-D102FDF16F0D', 0, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 'NyxHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetBlueprint', 'NyxHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D60E9D19-9602-4FDD-8CF3-ACC89BFFD2FB', 0, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 'NyxSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsBlueprint', 'NyxSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('F6F698BE-9652-47F3-84E0-1F888FDE6E90', 0, '/Lotus/Types/StoreItems/PowerSuits/RhinoStoreItem', 'RhinoStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 'RhinoBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2DB39253-3272-4BF2-807F-4BADCA988CD7', 0, '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 'RhinoChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisBlueprint', 'RhinoChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7107DB85-9764-4BE8-91A6-50EA7D13B06D', 0, '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 'RhinoHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetBlueprint', 'RhinoHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C94679B0-B77B-412C-B878-3FDFBE33DBDF', 0, '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 'RhinoSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsBlueprint', 'RhinoSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0F1ECFEB-8B6F-4C73-BD03-EA829CFB592B', 0, '/Lotus/Types/StoreItems/PowerSuits/SarynStoreItem', 'SarynStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 'SarynBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2F1A58CF-1D95-4CA3-9594-22B7AAFA5FC8', 0, '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 'SarynChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisBlueprint', 'SarynChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('B9E286C8-2569-4D7E-B0B5-3C6398D08489', 0, '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 'SarynHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetBlueprint', 'SarynHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('AF5D66A8-FB1F-4146-B353-244BD045F11D', 0, '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 'SarynSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsBlueprint', 'SarynSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('33534F59-287C-4FC7-A711-CA4A6F06E6A9', 0, '/Lotus/Types/StoreItems/PowerSuits/TrinityStoreItem', 'TrinityStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 'TrinityBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('77F40060-A9BC-420A-8A3A-82088EB34CA0', 0, '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 'TrinityChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisBlueprint', 'TrinityChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('39D9EB0B-6F2D-4BD3-B1E0-846155096634', 0, '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 'TrinityHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetBlueprint', 'TrinityHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('AE36CF67-DDF7-4C22-BDFC-EFA032E0AB14', 0, '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 'TrinitySystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsBlueprint', 'TrinitySystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D7803BBA-2125-4B2B-AB10-9AC6DDCC05B5', 0, '/Lotus/Types/StoreItems/PowerSuits/VoltStoreItem', 'VoltStoreItem', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 'VOLTBlueprint', 259200, 25000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8D01FE1B-B86B-4F12-AA76-F4EB6739F994', 0, '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 'VOLTChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisBlueprint', 'VOLTChassisBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8826959F-E20D-4F8C-9A8F-1E8F0E275439', 0, '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 'VOLTHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetBlueprint', 'VOLTHelmetBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('78507514-816A-4EB6-9708-4CA627E9D642', 0, '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 'VOLTSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsBlueprint', 'VOLTSystemsBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('EEBCAA9E-FCE8-44F4-B610-F21B16A0745F', 0, '/Lotus/Types/StoreItems/Weapons/AkimboAutoPistolStoreItem', 'AkimboAutoPistolStoreItem', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 'AFurisBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('691ADA22-41DB-46DA-B97B-86345E9CAD78', 0, '/Lotus/Types/StoreItems/Weapons/AkimboBoltoStoreItem', 'AkimboBoltoStoreItem', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 'AkBoltoBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('CC7AB4A2-7C9E-4881-BBB9-683FEBAF4C31', 0, '/Lotus/Types/StoreItems/Weapons/AxeStoreItem', 'AxeStoreItem', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'AxeBlueprint', 43200, 30000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C821278D-572C-4E65-81AF-A703909AC12B', 0, '/Lotus/Types/StoreItems/Weapons/CrossBowStoreItem', 'CrossBowStoreItem', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 'BoltoBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('82A39A1A-72CA-4534-9FF9-7CF90AE2CF22', 0, '/Lotus/Types/StoreItems/Weapons/BoltoRifleStoreItem', 'BoltoRifleStoreItem', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 'BoltorBlueprint', 86400, 25000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('16067E5B-F090-4116-8A26-76D5D7E0685E', 0, '/Lotus/Types/StoreItems/Weapons/CeramicDaggerStoreItem', 'CeramicDaggerStoreItem', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 'CeramicDaggerBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C09C8645-3E9C-420B-B35A-B73A8C0E05B5', 0, '/Lotus/Types/StoreItems/Weapons/DarkDaggerStoreItem', 'DarkDaggerStoreItem', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 'DarkDaggerBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7BDD3DB4-BE77-47BD-9229-83EBC41347D8', 0, '/Lotus/Types/StoreItems/Weapons/DualAxeStoreItem', 'DualAxeStoreItem', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'DualAxeBlueprint', 43200, 30000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0880725C-E5AA-40E0-A627-4BFF8558159A', 0, '/Lotus/Types/StoreItems/Weapons/DualDaggerStoreItem', 'DualDaggerStoreItem', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 'DualDaggerBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4AEFC1F8-A1E7-41D6-8CF8-EBD4996BA8F5', 0, '/Lotus/Types/StoreItems/Weapons/DualEtherDaggerStoreItem', 'DualEtherDaggerStoreItem', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 'DualEtherDaggerBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4A820B74-A426-4420-9773-B7E44CB8DFDC', 0, '/Lotus/Types/StoreItems/Weapons/DualEtherSwordStoreItem', 'DualEtherSwordStoreItem', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 'DualEtherSwordBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0D342D6E-A06F-4E2A-A490-7DEA549740C1', 0, '/Lotus/Types/StoreItems/Weapons/DualHeatSwordStoreItem', 'DualHeatSwordStoreItem', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 'DualHeatSwordBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('F04F816A-BAA2-44A0-8153-52295AE96208', 0, '/Lotus/Types/StoreItems/Weapons/GauntletStoreItem', 'GauntletStoreItem', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 'GauntletBlueprint', 43200, 30000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E801364F-DCA9-4D49-B03F-0355833E2FB6', 0, '/Lotus/Types/StoreItems/Weapons/LightGlaiveStoreItem', 'LightGlaiveStoreItem', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 'GlaiveBlueprint', 43200, 15000, 50, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('5FFFA9E9-2922-471F-83CC-F0ED0DDA08ED', 0, '/Lotus/Types/StoreItems/Weapons/GreatSwordStoreItem', 'GreatSwordStoreItem', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 'GreatSwordBlueprint', 43200, 30000, 30, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('9255BBF6-A680-48F5-B9AF-817C874DFBB2', 0, '/Lotus/Types/StoreItems/Weapons/GrineerLightPistolStoreItem', 'GrineerLightPistolStoreItem', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 'GrineerLightPistolBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('DF279BEA-A22D-4855-8127-218CE8628C14', 0, '/Lotus/Types/StoreItems/Weapons/GrnAssaultRifleStoreItem', 'GrnAssaultRifleStoreItem', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'GrnAssaultRifleBlueprint', 86400, 25000, 40, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('57E2565F-81F7-4ACF-BF16-5A535DF45699', 0, '/Lotus/Types/StoreItems/Weapons/GrnHeavyPistolStoreItem', 'GrnHeavyPistolStoreItem', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 'GrnHeavyPistolBlueprint', 86400, 25000, 45, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8BD9EAAA-1561-4730-AB01-026C574F52E8', 0, '/Lotus/Types/StoreItems/Weapons/GrnStaffStoreItem', 'GrnStaffStoreItem', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 'GrnStaffBlueprint', 43200, 30000, 45, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('AC062A61-A99B-4ABD-B2D3-E7AB230CB1A4', 0, '/Lotus/Types/StoreItems/Weapons/HammerStoreItem', 'HammerStoreItem', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 'HammerBlueprint', 43200, 30000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('5E8B7EA4-C5F8-447F-89CB-AA5A0EAD37AA', 0, '/Lotus/Types/StoreItems/Weapons/DaggerStoreItem', 'DaggerStoreItem', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 'HeatDaggerBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BC93CC8B-370C-41B6-AD75-6D52BB084C61', 0, '/Lotus/Types/StoreItems/Weapons/HeatSwordStoreItem', 'HeatSwordStoreItem', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 'HeatSwordBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7FC872E0-2698-4A1F-873D-C54089974F81', 0, '/Lotus/Types/StoreItems/Weapons/HuntingBowStoreItem', 'HuntingBowStoreItem', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 'HuntingBowBlueprint', 43200, 15000, 45, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('85AAEF20-394B-4BBB-846F-D5D98CE17CE0', 0, '/Lotus/Types/StoreItems/Weapons/JawLongSwordStoreItem', 'JawLongSwordStoreItem', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 'JawBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D800AA33-9D43-44E8-A8C9-EF1EECB2269B', 0, '/Lotus/Types/StoreItems/Weapons/MireSwordStoreItem', 'MireSwordStoreItem', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 'MireSwordBlueprint', 43200, 20000, 45, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('725524BF-66BC-4CC6-945A-C18481C8ABFF', 0, '/Lotus/Types/StoreItems/Weapons/PangolinLongSwordStoreItem', 'PangolinLongSwordStoreItem', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 'PangolinSwordBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('018D45EA-9498-42CD-B9EB-6D51B58FD6DE', 0, '/Lotus/Types/StoreItems/Weapons/PlasmaSwordStoreItem', 'PlasmaSwordStoreItem', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 'PlasmaSwordBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('28562F18-5CF1-42FE-ADBC-F286C9AD3095', 0, '/Lotus/Types/StoreItems/Weapons/QuadShotgunStoreItem', 'QuadShotgunStoreItem', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 'QuadShotgunBlueprint', 86400, 25000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BC6F6ABB-DCAC-433F-8C52-71B12BD8D9CD', 0, '/Lotus/Types/StoreItems/Weapons/AkimboViperStoreItem', 'AkimboViperStoreItem', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 'TwinViperBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7046CBEF-C90C-4033-9275-6215703E9F94', 0, '/Lotus/Types/StoreItems/Skins/AxeDaggerAxeItem', 'AxeDaggerAxeItem', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 'DaggerAxeBlueprint', 43200, 15000, 45, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C5352A3F-6AD0-4071-80E3-843654BE16DA', 0, '/Lotus/Types/StoreItems/Skins/DualAxeDaggerAxeItem', 'DualAxeDaggerAxeItem', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 'DualDaggerAxeBlueprint', 43200, 20000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BBE1A5B1-B795-4379-8CC5-769F97044417', 0, '/Lotus/Types/StoreItems/Skins/GrnAxeSkinItem', 'GrnAxeSkinItem', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 'GrnAxeBlueprint', 43200, 30000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D0650793-84F2-4836-ADCD-3E419236ABA1', 0, '/Lotus/Types/StoreItems/Skins/HammerSkintem', 'HammerSkintem', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 'GrnHammerBlueprint', 43200, 30000, 35, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('DF74C19D-96AF-4DBF-95E5-8390C61DB60A', 0, '/Lotus/Types/StoreItems/Weapons/CronusLongSwordStoreItem', 'CronusLongSwordStoreItem', '/Lotus/Types/Recipes/CronusBlueprint', 'CronusBlueprint', 43200, 15000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('576E0FC2-6E1D-41E9-B3E0-F6007A6256E9', 0, '/Lotus/Types/StoreItems/Weapons/DarkSwordStoreItem', 'DarkSwordStoreItem', '/Lotus/Types/Recipes/DarkSwordBlueprint', 'DarkSwordBlueprint', 43200, 20000, 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8567D839-36A7-4D02-B8EF-3DC972BA9607', 0, '/Lotus/Types/StoreItems/WeaponUpgrades/IncendiaryRifleModStoreItem', 'IncendiaryRifleModStoreItem', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 'IncendiaryRifleModBlueprint', 43200, 6000, 10, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D218259E-2DB1-4653-8766-CF3B1B33D63F', 0, '/Lotus/Types/StoreItems/WeaponUpgrades/IncendiaryRifleModStoreItem', 'IncendiaryRifleModStoreItem', '/Lotus/Types/Recipes/KevinTestRecipe', 'KevinTestRecipe', 180, 1000, 10, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');


INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AD341E75-C6B1-4DE5-B7ED-38C2CC5A4CCB', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'C5FF2F36-A76D-4A3C-9090-9E17D9B5C025');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('40848858-C87E-467E-BEA1-14E32559138D', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Gallium', '2025-07-01 00:00:00.000000-05:00', 'Gallium', 'C5FF2F36-A76D-4A3C-9090-9E17D9B5C025');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1125EEE9-C538-47C7-A0BA-0394D4980B9B', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', 'C5FF2F36-A76D-4A3C-9090-9E17D9B5C025');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('925C0AF4-7B3B-4B2D-88F8-12A6DF6011C2', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'C5FF2F36-A76D-4A3C-9090-9E17D9B5C025');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7E98AFA5-3266-4F3D-B32E-27654C811F1C', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'BDBC6797-5207-4D3C-9758-473B1E581075');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('041DC6A2-FF8F-4BF9-8FD8-DA78ACD0335E', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'BDBC6797-5207-4D3C-9758-473B1E581075');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E72BF6D6-1BCE-4646-811E-C6BED407E5BC', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', 'BDBC6797-5207-4D3C-9758-473B1E581075');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8E04F42E-9971-49CD-9D2E-081D6C2C92A9', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'BDBC6797-5207-4D3C-9758-473B1E581075');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('218E5C57-B028-49CB-A212-CF786A314382', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '8D31D2FD-5C4E-4546-A1EE-F73755ADB0DF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7E960BED-1B0E-439A-8D2B-2D8A4C259160', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '8D31D2FD-5C4E-4546-A1EE-F73755ADB0DF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3F06487B-05A2-4A43-9D42-FE633C79A3DE', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '8D31D2FD-5C4E-4546-A1EE-F73755ADB0DF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('70E26FDA-DC3D-4CC4-8545-0C0E6CF0F032', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', '8D31D2FD-5C4E-4546-A1EE-F73755ADB0DF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9EAB3E19-9462-4A03-A448-A0E4559CDEB4', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'DCF50F59-66FD-4B1E-86B4-07108BBD23A8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5A17026D-C694-4CD9-A567-0094155387A2', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'DCF50F59-66FD-4B1E-86B4-07108BBD23A8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('021C8061-9F27-4482-8AC0-B5FFED56F945', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'DCF50F59-66FD-4B1E-86B4-07108BBD23A8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2CC3D62E-4121-443F-B6AA-1DA2DB9B954D', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'DCF50F59-66FD-4B1E-86B4-07108BBD23A8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('493EC038-9E49-4F28-AEB4-5CDBB80BA36E', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'D2956B45-D0FB-469E-89DF-47541676C343');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('756B88E6-2129-4019-A18D-22B1D3141D78', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'D2956B45-D0FB-469E-89DF-47541676C343');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BB3D4790-3855-4AAF-87D2-00CF3BEE91BF', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'D2956B45-D0FB-469E-89DF-47541676C343');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DD76EB03-2CEF-4DCF-A341-6F323177E847', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'D2956B45-D0FB-469E-89DF-47541676C343');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5EE31448-4C3F-4921-84F1-BAAFB3868E37', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'D74FC919-BBE4-4E19-81A6-E768A161F548');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FDB0BC3D-954B-4D6F-B6D3-8E3068A5B8E3', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'D74FC919-BBE4-4E19-81A6-E768A161F548');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F88C754C-4A51-4B5D-B5EC-5B3F119978A0', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'D74FC919-BBE4-4E19-81A6-E768A161F548');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5A497642-61D2-48FE-9742-D96B64DFECFA', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'D74FC919-BBE4-4E19-81A6-E768A161F548');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('11B07AC5-CF0B-4375-A24D-144E19832C97', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'C209A6A2-A2FA-4B08-BB71-BE13958C27E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F31057D5-B35D-4944-9760-45D55CFDF48C', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'C209A6A2-A2FA-4B08-BB71-BE13958C27E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CE7818A6-390F-4134-BC21-D94137CBD052', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'C209A6A2-A2FA-4B08-BB71-BE13958C27E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B3C134FE-29AC-4DE0-B1BB-4CF5269A7B24', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'C209A6A2-A2FA-4B08-BB71-BE13958C27E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3376B30B-0ABA-40FE-B499-19A2B94DDAE7', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '03964B87-76CE-44F3-89B5-EA5723F29B87');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AF78F7E0-0C29-42D0-A66A-B4244BA26EF2', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '03964B87-76CE-44F3-89B5-EA5723F29B87');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CFEF6896-088B-4E12-9EF0-F889716DD166', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '03964B87-76CE-44F3-89B5-EA5723F29B87');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('012D57D4-C577-41AA-94EB-4A6F97E7CE16', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', '03964B87-76CE-44F3-89B5-EA5723F29B87');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E343C2FD-9BF1-47DF-A721-5D9C9DB0C199', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '1B344D05-9D5B-4DAA-8BBB-1B741733705A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8AABD183-2050-4CFC-BF2C-E42CF33BC0C6', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '1B344D05-9D5B-4DAA-8BBB-1B741733705A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5EBC400F-61D7-4359-A7B5-77F58402AAAE', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '1B344D05-9D5B-4DAA-8BBB-1B741733705A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AE3FE90A-1969-4345-86A8-1A17CA650DB7', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', '1B344D05-9D5B-4DAA-8BBB-1B741733705A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8FE0E04D-E402-451B-B768-FB93684C984B', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '55950CF3-9CDD-49BC-A7E9-9AFCFA5ADAE9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EE84F4F4-5EC4-4BB7-9DE8-1A1F06A78F0A', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '55950CF3-9CDD-49BC-A7E9-9AFCFA5ADAE9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8A86744A-A879-4986-A87C-F9EF5E27FFAE', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '55950CF3-9CDD-49BC-A7E9-9AFCFA5ADAE9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('70FF3D56-1838-49EB-BDA4-60E95E171395', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', '55950CF3-9CDD-49BC-A7E9-9AFCFA5ADAE9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('656906E1-7891-42C4-BAA4-11E4E034B729', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'F8F44F12-8C4A-47F1-8C89-1157BB02F6FE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9D0831AF-5CB1-4CCC-A9A9-1AB59088C073', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'F8F44F12-8C4A-47F1-8C89-1157BB02F6FE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('126F64F1-6BB9-481D-A861-B1FF807353B3', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'F8F44F12-8C4A-47F1-8C89-1157BB02F6FE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E83FB4A9-AEE9-443E-855F-9EA3F77C9AAB', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'F8F44F12-8C4A-47F1-8C89-1157BB02F6FE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('23BD7121-5148-480D-B93D-1DCBB174565D', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'C1687C5E-AE74-44CA-9D9A-7FA334CF8A91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('31F3E6F6-C8BE-436E-B1F4-1FADC5012751', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'C1687C5E-AE74-44CA-9D9A-7FA334CF8A91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1B2E6CB2-FB95-40F6-AE19-6B5044E804BA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'C1687C5E-AE74-44CA-9D9A-7FA334CF8A91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0A14A207-AA3B-44E1-AC03-84F773CEC2D1', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'C1687C5E-AE74-44CA-9D9A-7FA334CF8A91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('54E863CD-C7EA-478B-878C-8CC475C8B141', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '483E6A89-2738-4DA4-B2CF-64EB9A5E50CF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('21DA4073-2C1E-4A05-87FC-6B6844287D5E', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '483E6A89-2738-4DA4-B2CF-64EB9A5E50CF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('896F72A6-CAAD-4892-A6CF-EA3A85B21544', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '483E6A89-2738-4DA4-B2CF-64EB9A5E50CF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9038962E-BF98-446B-8F37-D6C5C2EE7411', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', '483E6A89-2738-4DA4-B2CF-64EB9A5E50CF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('37D2CE2C-A8D6-4A6C-ADD4-14E2C19019AC', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'A4872899-6F06-4EF4-823C-1DBEB7268E7F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('59D6996A-D62E-4729-B895-ECD3D78C31C8', '2025-07-01 00:00:00.000000-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'A4872899-6F06-4EF4-823C-1DBEB7268E7F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E0EBF961-54CB-45FA-9BB2-5F3C0C200193', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'A4872899-6F06-4EF4-823C-1DBEB7268E7F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('34707312-D382-4597-979F-B5ECDCE781E3', '2025-07-01 00:00:00.000000-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-07-01 00:00:00.000000-05:00', 'Neurode', 'A4872899-6F06-4EF4-823C-1DBEB7268E7F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B5845CE3-431A-464D-9A7E-EC623959D1A6', '2025-07-01 00:00:00.000000-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '8EE8846D-B7A3-475A-A1C8-701109613BCD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FDB38050-B9B8-4694-BF3E-CB6B60416854', '2025-07-01 00:00:00.000000-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-07-01 00:00:00.000000-05:00', 'Circuits', '8EE8846D-B7A3-475A-A1C8-701109613BCD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7C2B535A-AE2F-4E54-B851-4F1141C87CF3', '2025-07-01 00:00:00.000000-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-07-01 00:00:00.000000-05:00', 'Nanospores', '8EE8846D-B7A3-475A-A1C8-701109613BCD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('428D9254-73B6-4D42-AE17-C648AA9ED671', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '8EE8846D-B7A3-475A-A1C8-701109613BCD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('95C04B5D-DFB7-4F7B-9999-AF194D3B8349', '2025-07-01 00:00:00.000000-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '391E8CC4-6BC3-4A31-8293-EE7101CBCEFD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ABA9347D-AC57-4B0C-81E9-E2CEB9B29099', '2025-07-01 00:00:00.000000-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-07-01 00:00:00.000000-05:00', 'Circuits', '391E8CC4-6BC3-4A31-8293-EE7101CBCEFD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F3443F51-191B-4EF2-BF81-0CFDA955169D', '2025-07-01 00:00:00.000000-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-07-01 00:00:00.000000-05:00', 'Nanospores', '391E8CC4-6BC3-4A31-8293-EE7101CBCEFD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4202CEF8-CD2E-4613-B218-FCC12E41DB95', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '391E8CC4-6BC3-4A31-8293-EE7101CBCEFD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4A5A43F3-61B2-4642-8214-79337C7DF5FA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'AshHelmetComponent', '9F5EDD5B-A7FE-4C12-84AC-4255A7DD6A4A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A8A6F799-D84D-461D-BAD7-F3394E42A0ED', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'AshChassisComponent', '9F5EDD5B-A7FE-4C12-84AC-4255A7DD6A4A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('66C1E953-8ED9-4DAA-A657-82CB397CD2C4', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'AshSystemsComponent', '9F5EDD5B-A7FE-4C12-84AC-4255A7DD6A4A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('21225B41-67F5-4FEB-B05B-2ECBBB9AAE4C', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '9F5EDD5B-A7FE-4C12-84AC-4255A7DD6A4A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('78E4F939-AFDC-42A2-8D19-04EC8E9301F0', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '7002954A-3240-453E-8768-1419E9BDC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DC73051A-0739-4DB8-8EB7-3E53910614C2', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '7002954A-3240-453E-8768-1419E9BDC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('79F38442-3E4F-4D02-A2E7-95ABAE78F2C0', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '7002954A-3240-453E-8768-1419E9BDC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9B550DA0-5C64-49BA-985A-F0612D8BCBF3', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '104BE57C-BB4A-430E-B031-C6EAB9DF7E6A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A43F5A28-ECC4-41EE-B62F-BA25D0CABEC0', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '104BE57C-BB4A-430E-B031-C6EAB9DF7E6A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C51B0ADF-D885-4077-8E8F-66C70A618AA7', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '104BE57C-BB4A-430E-B031-C6EAB9DF7E6A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('453A2291-BFD8-47C5-A3A0-4B53C662EFAD', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '104BE57C-BB4A-430E-B031-C6EAB9DF7E6A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C5B79521-10AF-48D2-A574-4BB4E2D8E664', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '730A6609-CEE2-4624-9F5B-651118E12EED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('71B660E1-E240-4941-B978-ADF9AF507214', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '730A6609-CEE2-4624-9F5B-651118E12EED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1903E837-2DCB-42AD-B513-8A72475D7577', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '730A6609-CEE2-4624-9F5B-651118E12EED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2DA41296-45E4-4793-976B-AECAF8EF0581', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '730A6609-CEE2-4624-9F5B-651118E12EED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('765416BE-146A-4F17-9872-3EAA0C4A4456', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'BansheeHelmetComponent', 'D94E71A0-E9E4-4534-BE91-252E70681ABD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2C4A7F0C-F2DE-4FF6-84F0-AAA78BE62D15', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'BansheeChassisComponent', 'D94E71A0-E9E4-4534-BE91-252E70681ABD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EC8BE098-6C8B-4653-864D-6E7A9E155220', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'BansheeSystemsComponent', 'D94E71A0-E9E4-4534-BE91-252E70681ABD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CAD042A0-13DA-498C-991A-55F9246A4CA8', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'D94E71A0-E9E4-4534-BE91-252E70681ABD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E9FEE575-F2FD-43A0-9415-BB80C49347A1', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'ECB96050-90B9-462B-A22F-84184BED1B1B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3DAA244A-EA9F-4EFA-BCB4-3C624FED619C', '2025-07-01 00:00:00.000000-05:00', 900, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', 'ECB96050-90B9-462B-A22F-84184BED1B1B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A7D838C0-9967-4864-9D3D-49A8D7AB59AE', '2025-07-01 00:00:00.000000-05:00', 50, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', 'ECB96050-90B9-462B-A22F-84184BED1B1B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('833E9BEE-62FC-4365-8D2C-C5B346DF6C62', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/Circuits', '2025-07-01 00:00:00.000000-05:00', 'Circuits', '53B0F030-F758-477A-ACC9-F7DBB5C60916');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E9C49D59-6969-4959-9C99-BF33FA5038EA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '53B0F030-F758-477A-ACC9-F7DBB5C60916');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0BF3633A-A023-4C8A-B097-EF48545AAA6C', '2025-07-01 00:00:00.000000-05:00', 200, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '53B0F030-F758-477A-ACC9-F7DBB5C60916');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AC02F239-190B-4870-9695-7A242149DEBE', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '53B0F030-F758-477A-ACC9-F7DBB5C60916');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5EAD80CA-3C30-4BC0-83F7-07248018A9D0', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '376990EE-0AAC-4946-818F-262E1FC1A71C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('039E5303-F5C4-40F6-A175-17BC46AFD688', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '376990EE-0AAC-4946-818F-262E1FC1A71C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A3F3DF71-FCDA-4750-ABA6-3668E5C70A93', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '376990EE-0AAC-4946-818F-262E1FC1A71C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('84E94D4E-86F5-4874-B768-48192BC37772', '2025-07-01 00:00:00.000000-05:00', 400, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '376990EE-0AAC-4946-818F-262E1FC1A71C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7957B0B6-A175-4D20-A93D-134BBFA913CF', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'EmberHelmetComponent', 'E9EF173D-5FF1-4A59-90B0-F3E7A74CD2E7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C415EE3A-1A3B-49D7-B227-0566C1425BFE', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'EmberChassisComponent', 'E9EF173D-5FF1-4A59-90B0-F3E7A74CD2E7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1CA58C36-F1FD-482D-A050-EF1AFD7891EC', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'EmberSystemsComponent', 'E9EF173D-5FF1-4A59-90B0-F3E7A74CD2E7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('71609963-4B6B-479B-8BB5-2E4BC581E3A5', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'E9EF173D-5FF1-4A59-90B0-F3E7A74CD2E7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6A401C15-6341-42E1-85FF-68AA52917519', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '71CC0BEF-C81A-4F83-A5A3-3144027D8CDF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('55838013-E552-4B80-AFB4-39ADDCA3876D', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '71CC0BEF-C81A-4F83-A5A3-3144027D8CDF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E0307178-03ED-49D2-B90F-861A60230A37', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '71CC0BEF-C81A-4F83-A5A3-3144027D8CDF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C516B927-18BC-4187-9BD1-59D620DD5DC0', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '8EF033A3-B312-4D6B-8773-43A800FA930C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1E8DF61E-B33D-4A50-AFAF-8A23CBA75C96', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '8EF033A3-B312-4D6B-8773-43A800FA930C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('45DD2B3A-DA79-46B6-94C1-772991C0E4EF', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '8EF033A3-B312-4D6B-8773-43A800FA930C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E01F1582-325D-407C-923F-2C2729474227', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '8EF033A3-B312-4D6B-8773-43A800FA930C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F130F164-EA45-4D1D-A9FC-0216BCCEF8D2', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '8EC5E31F-7920-4E34-80E8-54028D0C0CBD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F9F51A58-C4F1-42B9-84E4-A371B0C4CC02', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '8EC5E31F-7920-4E34-80E8-54028D0C0CBD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('60FAB115-4CDC-4D48-82C7-8C3A90CD904F', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '8EC5E31F-7920-4E34-80E8-54028D0C0CBD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EA76B588-ACF2-444A-B46D-19202F5DD4AC', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '8EC5E31F-7920-4E34-80E8-54028D0C0CBD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('27217C08-AB86-4C15-A754-48377B61056F', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'ExcaliburChassisComponent', 'ABB0DB21-94A3-4A73-9161-3AD8F8635DB0');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FB52CC1B-1BBD-4311-96BE-1273E845AE59', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'ExcaliburHelmetComponent', 'ABB0DB21-94A3-4A73-9161-3AD8F8635DB0');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B6ABE1B0-3F3B-4083-87B2-DC262C1C6864', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'ExcaliburSystemsComponent', 'ABB0DB21-94A3-4A73-9161-3AD8F8635DB0');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EB9F2F8D-6FBE-4984-ACDE-30AA644A40B1', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'ABB0DB21-94A3-4A73-9161-3AD8F8635DB0');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('808DB67A-DC0D-49DB-ADA2-C7C46C7E1349', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '6C50B57A-B956-4CFE-BA4F-792D2BD817FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AEE63FC7-BA63-41E6-AE30-02D0FDB1B30A', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '6C50B57A-B956-4CFE-BA4F-792D2BD817FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4BF88D53-1DFA-48E0-B28B-6AA82C219A68', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '6C50B57A-B956-4CFE-BA4F-792D2BD817FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3F5E9065-DEE0-4D9A-982C-A6374BA0FBA4', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '87DB6CD3-EA3E-4549-B835-B93A3055C7C2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('874464F0-7BFE-489E-880A-260B8C479FF6', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '87DB6CD3-EA3E-4549-B835-B93A3055C7C2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5CEC81E1-C63F-453E-89E8-53519AACF889', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '87DB6CD3-EA3E-4549-B835-B93A3055C7C2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('458FD95B-B30E-4238-B7B1-00C47EF2ADF6', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '87DB6CD3-EA3E-4549-B835-B93A3055C7C2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D9374AD3-E764-4AA3-BCA4-A0E4104F6A79', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '0AFC0355-77DF-4F1F-9C87-477E45796C65');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('630D36D4-1736-4D68-8CFF-26FD4649E816', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '0AFC0355-77DF-4F1F-9C87-477E45796C65');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('411D50BF-BABC-4231-95DA-3F6B2CD58077', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '0AFC0355-77DF-4F1F-9C87-477E45796C65');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A312069C-B8F7-4377-958D-AAD111F690E4', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '0AFC0355-77DF-4F1F-9C87-477E45796C65');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5429A12B-A57C-4C38-B26E-8480C33BB7D4', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostHelmetComponent', 'E8CFD88C-799F-4A87-A11A-80F7C1779161');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8DA4B56B-7E5F-4E04-845B-DF7819DEA9C3', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostChassisComponent', 'E8CFD88C-799F-4A87-A11A-80F7C1779161');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3A47B3FA-ABB7-4F40-A961-6F4B3C782E80', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostSystemsComponent', 'E8CFD88C-799F-4A87-A11A-80F7C1779161');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('63840986-0EE3-4998-8DE7-2D7E85BF2C8A', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', 'E8CFD88C-799F-4A87-A11A-80F7C1779161');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F554A4C1-4AFD-4942-AE1D-7806227C473E', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '827AA174-A43C-433D-AC7B-DB6EAF126C27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C81BA65F-177C-4D66-A3DC-772B0FA1438A', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '827AA174-A43C-433D-AC7B-DB6EAF126C27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9687FA41-B062-4B17-9B83-E5C8E8DEE33C', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '827AA174-A43C-433D-AC7B-DB6EAF126C27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3D055F15-FFA5-4BB2-B519-D90F1B5B058B', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '2CE4AB70-8AA6-4E0E-B141-6307F673877B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E6BE7FD9-6844-418E-88B0-D26D4C585DBE', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '2CE4AB70-8AA6-4E0E-B141-6307F673877B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E544CCAC-A40D-4136-8CB2-E9DBFBF18512', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '2CE4AB70-8AA6-4E0E-B141-6307F673877B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DB6CB257-E7FB-42C1-96AB-942C11BE3DE9', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '2CE4AB70-8AA6-4E0E-B141-6307F673877B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('196F21BE-CF52-450C-BFC4-F5A934AF5633', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostPrimeHelmetComponent', '91497D81-636E-4E21-8E62-FDC4C4D9E6F5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('258D0821-0909-47FA-B7AF-307DBDC0C8C6', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostPrimeChassisComponent', '91497D81-636E-4E21-8E62-FDC4C4D9E6F5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('38443F27-0F2D-454D-B42E-AC6EC4CB8D2E', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'FrostPrimeSystemsComponent', '91497D81-636E-4E21-8E62-FDC4C4D9E6F5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3630F4DC-1EB6-421E-BFA5-24BC14CD6C2A', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '91497D81-636E-4E21-8E62-FDC4C4D9E6F5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B913B1E6-7682-4776-BA34-CA00416E21DA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'D4E7FABF-7EF6-4971-92AF-11694EC2C1C8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D9D11368-0657-4FAC-B641-91962DEC2C62', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', 'D4E7FABF-7EF6-4971-92AF-11694EC2C1C8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E3F77DE3-B0D5-4704-947F-0EC9E65D0F57', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', 'D4E7FABF-7EF6-4971-92AF-11694EC2C1C8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B6D86736-C43B-49B5-A8B8-2DE94BF0B5DA', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '0E4AEA9D-DDE3-4B4E-9DDE-A9C690482793');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9C95CC12-D57C-4CAF-8A98-DB08F6B12470', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '0E4AEA9D-DDE3-4B4E-9DDE-A9C690482793');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('12B1D3CC-FFAF-4CA5-B5EE-9DA5CAF9BE84', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '0E4AEA9D-DDE3-4B4E-9DDE-A9C690482793');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('39398A71-9FB5-40FA-A8F6-48E4FBB98729', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '0E4AEA9D-DDE3-4B4E-9DDE-A9C690482793');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A3430052-3DB0-4B45-9F53-37DD5DCDF367', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', 'AD91BEC2-D3F5-4818-ACB7-44A93B27AF4F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E991281D-BE31-4BCE-B663-25C4BC0B716C', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'AD91BEC2-D3F5-4818-ACB7-44A93B27AF4F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3D83EC77-8FCC-443A-B4A7-F1C8A3917DAF', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'AD91BEC2-D3F5-4818-ACB7-44A93B27AF4F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1F2C4141-E29F-4821-A20A-FD93A5715BA0', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', 'AD91BEC2-D3F5-4818-ACB7-44A93B27AF4F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('722D301F-41FC-4DF9-BA70-3F9B104FF921', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '311B66C6-7DCD-4AC9-B5A5-5A64786E2911');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E32D2177-3CE9-40A0-BC81-688B01614394', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '311B66C6-7DCD-4AC9-B5A5-5A64786E2911');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('49ED9CA3-4033-4226-B360-73E351A97AE6', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '311B66C6-7DCD-4AC9-B5A5-5A64786E2911');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('92E81601-1627-42CD-8EB1-9969178FC095', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '311B66C6-7DCD-4AC9-B5A5-5A64786E2911');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('680376BB-E57B-4F8D-B2AB-591113F80254', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'LOKIChassisComponent', '018463A0-643E-449D-9406-2F06353A07AC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0E4F1D28-A16D-4221-A8C5-0EF6B56D62C1', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'LOKIHelmetComponent', '018463A0-643E-449D-9406-2F06353A07AC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3C8628FB-4443-49E8-8655-61B95992D53D', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'LOKISystemsComponent', '018463A0-643E-449D-9406-2F06353A07AC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0299C9E1-F1B8-4B46-AE7B-34A118ABB31A', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '018463A0-643E-449D-9406-2F06353A07AC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7D904127-E39E-42C6-AA45-170C127C10E5', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '0CAA198F-A9F3-4EEA-A178-D5E2237B47CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DC0BBA1D-1D90-4E86-B762-71344F6EC672', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '0CAA198F-A9F3-4EEA-A178-D5E2237B47CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C89E521A-9A5D-40B5-836B-2470BAC2E7E7', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '0CAA198F-A9F3-4EEA-A178-D5E2237B47CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A43B7BA2-2538-4371-A0BE-0EC52C656B65', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '9F97782C-A23D-40EC-85FF-012FA727DC9D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FC29A83C-A8F1-4C2A-B485-69EE513160D5', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '9F97782C-A23D-40EC-85FF-012FA727DC9D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('37694DFE-C2BA-4195-8EAE-5DB7654AC02A', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '9F97782C-A23D-40EC-85FF-012FA727DC9D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('18C072AE-2EB5-4D92-9EB6-36AAA16FCD46', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '9F97782C-A23D-40EC-85FF-012FA727DC9D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('35EC2520-8020-4829-9F1C-6B978EB73597', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', 'A2EFB226-288F-4DFE-AD9C-0CF95B41D050');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FB793B0B-99B1-40A6-9A38-58CC70E72299', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'A2EFB226-288F-4DFE-AD9C-0CF95B41D050');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('525A483B-D4C4-4EC2-9807-85F922F34202', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'A2EFB226-288F-4DFE-AD9C-0CF95B41D050');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1C557CEF-F893-4DCE-9574-7F5FF15BD489', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', 'A2EFB226-288F-4DFE-AD9C-0CF95B41D050');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2EE1222C-813C-496B-9277-9B9F8D4326F1', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'MagHelmetComponent', '40B30656-FAD9-4164-A66C-44077158AB36');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2155772E-0C82-49CA-AED8-B6A1477A21CC', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'MagChassisComponent', '40B30656-FAD9-4164-A66C-44077158AB36');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9543B659-E1C4-432C-8B88-65B18F285CED', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'MagSystemsComponent', '40B30656-FAD9-4164-A66C-44077158AB36');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6597EC58-80F7-45AA-8FEF-329CED179AC7', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '40B30656-FAD9-4164-A66C-44077158AB36');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F027FA79-A0D4-46E0-B364-073858109616', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '8BD4526A-B3BF-4BB2-9DE3-F8DBED389C42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E0ACA4F4-7A63-4180-9C4D-173E74674EDB', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '8BD4526A-B3BF-4BB2-9DE3-F8DBED389C42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0F81483B-A6B3-4E91-AE98-7AE81CF5CCB0', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '8BD4526A-B3BF-4BB2-9DE3-F8DBED389C42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('99F3B68B-59C5-4D58-AD61-1AD9FCF51541', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', '3D309B87-C622-4015-AEA2-BE7D162DC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('209D36DB-C6E8-4E7A-BA94-47668DBE7EA5', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', '3D309B87-C622-4015-AEA2-BE7D162DC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('625C47F7-7611-4D8E-8711-14BF54256326', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', '3D309B87-C622-4015-AEA2-BE7D162DC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('507CB3C7-B27C-4BFC-A914-257D561EFF18', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '3D309B87-C622-4015-AEA2-BE7D162DC57E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('963A8000-83F8-43CD-9BE6-5CB8B056B7EB', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', '5738C720-4F2D-482E-813E-8F76958B6827');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('88A42334-9B3D-4FC5-BF70-7C0E5046895F', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '5738C720-4F2D-482E-813E-8F76958B6827');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9FEC5965-6C32-49B7-B7DD-5D2E99CD4581', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', '5738C720-4F2D-482E-813E-8F76958B6827');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('27FEF5B9-2C90-45C6-8496-393D9AE1768D', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', '5738C720-4F2D-482E-813E-8F76958B6827');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0B24B17F-BE16-476D-BB2F-B283828DD958', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'NyxHelmetComponent', '732A201D-74AC-470E-9370-39B6E50CB04F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8AA272EA-40A8-43FE-BC5F-D91A6F3DDA9A', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', '2025-07-01 00:00:00.000000-05:00', 'NyxChassisComponent', '732A201D-74AC-470E-9370-39B6E50CB04F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D7F10A30-4AE4-45E1-B2F2-87EEEAB796F9', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', '2025-07-01 00:00:00.000000-05:00', 'NyxSystemsComponent', '732A201D-74AC-470E-9370-39B6E50CB04F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1525811B-3989-405D-AE5C-827673E875F1', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-07-01 00:00:00.000000-05:00', 'OrokinCell', '732A201D-74AC-470E-9370-39B6E50CB04F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FD182F42-6412-4747-A037-D579F32184EA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', '4B5369C1-F85B-4AC5-8637-BE0167D56AC2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('90ADFEE8-DFEC-4DF0-A4BC-F88A564F5629', '2025-07-01 00:00:00.000000-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-07-01 00:00:00.000000-05:00', 'Ferrite', '4B5369C1-F85B-4AC5-8637-BE0167D56AC2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('72CA5750-58E8-421C-95DF-295B57C3CA19', '2025-07-01 00:00:00.000000-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', '4B5369C1-F85B-4AC5-8637-BE0167D56AC2');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2FD06A7D-A17C-4D80-9165-5270F4122C3A', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-07-01 00:00:00.000000-05:00', 'AlloyPlate', 'A08EC1F6-EA57-479A-ACBA-D102FDF16F0D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('01455732-4BE0-4B13-B51F-000D238293B4', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-07-01 00:00:00.000000-05:00', 'NeuralSensor', 'A08EC1F6-EA57-479A-ACBA-D102FDF16F0D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A324B28B-5F93-40BC-9DE0-111B15A034FC', '2025-07-01 00:00:00.000000-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-07-01 00:00:00.000000-05:00', 'PolymerBundle', 'A08EC1F6-EA57-479A-ACBA-D102FDF16F0D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6F5C9B26-A132-41CE-B34E-EDE7F013CAF2', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-07-01 00:00:00.000000-05:00', 'Rubedo', 'A08EC1F6-EA57-479A-ACBA-D102FDF16F0D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A0408B2E-C772-46D9-9880-00C43E09F69E', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-07-01 00:00:00.000000-05:00', 'ControlModule', 'D60E9D19-9602-4FDD-8CF3-ACC89BFFD2FB');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('41F0F4B8-15E0-4D62-96C5-9727E16F8FA8', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-07-01 00:00:00.000000-05:00', 'Morphic', 'D60E9D19-9602-4FDD-8CF3-ACC89BFFD2FB');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CBEA9E08-50D2-4A8E-BAC2-6386D0A2CE3C', '2025-07-01 00:00:00.000000-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-07-01 00:00:00.000000-05:00', 'Salvage', 'D60E9D19-9602-4FDD-8CF3-ACC89BFFD2FB');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8F3DFA50-D638-43AF-A531-6516472B0A71', '2025-07-01 00:00:00.000000-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-07-01 00:00:00.000000-05:00', 'Plastids', 'D60E9D19-9602-4FDD-8CF3-ACC89BFFD2FB');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CB3610E6-0816-4355-B501-83E4CACA66DA', '2025-07-01 00:00:00.000000-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', '2025-07-01 00:00:00.000000-05:00', 'RhinoHelmetComponent', 'F6F698BE-9652-47F3-84E0-1F888FDE6E90');




");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
