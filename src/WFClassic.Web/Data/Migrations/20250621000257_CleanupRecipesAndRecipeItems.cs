using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CleanupRecipesAndRecipeItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from RecipeItems");
            migrationBuilder.Sql("Delete from Recipes");

            migrationBuilder.Sql(@" 

INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('16120F2A-35B7-4DBC-A543-A39D7FFD78BE', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 'AFurisBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A476979B-E665-4960-9503-1B89C5F36D0B', 0, '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 'BoltoBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BEBEA877-DB0A-45DA-B126-FAE30BDCF034', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 'AkBoltoBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('49F91A40-AB15-4A4C-9424-C18AC225A5E1', 0, '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 'GrnHeavyPistolBlueprint', 86400, 25000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D5C4BB0A-33E8-4C18-B0E7-F1AF815FB366', 0, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 'GrineerLightPistolBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('75C39EAF-FB46-4A55-AEDD-9806516325E8', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 'TwinViperBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0674D8B8-C391-489B-ACE4-EE5F40DEBFCA', 1, '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 'QuadShotgunBlueprint', 86400, 25000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7EE3FA22-D976-4B2F-9B20-1AB7BCB0FAD9', 1, '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 'BoltorBlueprint', 86400, 25000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('66DFCA4D-01FB-4E40-9D8D-C4B4637AF70D', 1, '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 'HuntingBowBlueprint', 43200, 15000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A7AB4F31-DF77-42CF-9CBB-879DF9555ACF', 1, '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'GrnAssaultRifleBlueprint', 86400, 25000, 40, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('732D0662-7068-494C-9F4F-A69CB2AE3875', 3, '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'AshBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1D6ED9F5-8388-4F04-92BB-CA13E043A272', 3, '/Lotus/Powersuits/Ember/Ember', 'Ember', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'EmberBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A8F93E5E-1586-4FEC-9365-3E6D3B3046EE', 3, '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 'RhinoBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('EF735264-EAAE-46A3-A5F8-896A0512A953', 3, '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 'TrinityBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E601EFF1-B742-4DBE-9E32-0E8F41181A89', 3, '/Lotus/Powersuits/Mag/Mag', 'Mag', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 'MagBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('DF27FC53-0436-41C6-925D-14039F1A8CF7', 3, '/Lotus/Powersuits/Volt/Volt', 'Volt', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 'VOLTBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('B882EE82-5A0D-41B8-9106-83BAD0DAD22C', 3, '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 'ExcaliburBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C5617551-57A7-4C2F-B7EF-A60F5558DB91', 3, '/Lotus/Powersuits/Loki/Loki', 'Loki', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 'LOKIBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('46891BD1-10D4-409A-8E44-FC9C97416B3F', 3, '/Lotus/Powersuits/Jade/Jade', 'Jade', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 'NyxBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C8A34C48-B406-4F0E-8BDB-FF762BEFA3EE', 3, '/Lotus/Powersuits/Frost/Frost', 'Frost', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 'FrostBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('BA3E23B6-0585-49BA-9EC0-0000ACA158D1', 3, '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 'SarynBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1ADF0512-A41D-49A1-9E76-F5909B8EE540', 3, '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'BansheeBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('896BA6E7-CD0E-4258-A275-77814CF9491F', 3, '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 'FrostPrimeBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('5E2C0407-936D-4D29-B1B4-336ED5A7FFB2', 4, '/Lotus/Upgrades/Modules/Crafted/IncendiaryRifleMod', 'IncendiaryRifleMod', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 'IncendiaryRifleModBlueprint', 43200, 6000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('748C804F-332C-4EF9-AFF2-B6441909EB07', 5, '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', '/Lotus/Types/Recipes/CronusBlueprint', 'CronusBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8123567D-7258-4335-A413-7938AE12F420', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 'CeramicDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('EA1EA458-3732-4B57-9999-90E1A201896B', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 'DarkDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('15A14965-4BD8-4E16-926E-A1783C214C27', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 'HeatDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('F434D141-244C-4947-8920-90D3FBA30B20', 5, '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 'HeatSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('40C474B8-7858-4161-B75A-8D703164E4F8', 5, '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 'JawBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('802E4871-5704-43C0-AAD3-AAC746C90706', 5, '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 'PangolinSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4F1DCB1E-1919-4ABC-9FF1-69265FE664DD', 5, '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 'PlasmaSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A035D87D-A503-4304-AF00-05D58AC93EBC', 5, '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', '/Lotus/Types/Recipes/DarkSwordBlueprint', 'DarkSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('3041CABE-43AC-4FA5-ADF9-70CA812D9C94', 5, '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 'HammerBlueprint', 43200, 30000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E6A801BC-E2E5-4E67-ADD9-F8373FA8F321', 5, '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'AxeBlueprint', 43200, 30000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8FFC2717-46C6-428B-AE37-091A8574847F', 5, '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'DualAxeBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('EEBEAAFE-62BC-4568-873B-DD41E838C92C', 5, '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 'GreatSwordBlueprint', 43200, 30000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('B38D441E-0E68-4C39-9D72-FD2E96EA1922', 5, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 'DualHeatSwordBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E52AE0C2-01AB-4E97-B6A8-5649E69AA6E3', 5, '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 'GrnStaffBlueprint', 43200, 30000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('113A1AFB-4CAC-40AA-826E-3F0AD6A434CA', 5, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 'DualDaggerBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6500674A-0083-4A4A-8220-5BA94483C3B7', 5, '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 'MireSwordBlueprint', 43200, 20000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('F687E946-5F7B-4E17-ACE6-965B8F7916E5', 5, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 'DualEtherDaggerBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('CFD6DBEF-CEC1-4F1E-A84A-EA6CA87356D8', 5, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 'DualEtherSwordBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1C479545-A926-4E12-919D-E438E138DF27', 5, '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 'GlaiveBlueprint', 43200, 15000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('19F771E1-180A-4B9B-AAD7-76F4D12A471D', 5, '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 'GauntletBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8E133CAA-24E0-4372-A77C-734B867C4A6C', 6, '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 'AshAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('12AF99FA-10E8-4960-BFEB-D66BA499B268', 6, '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 'EmberAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6F419860-3551-4454-93E2-EB7007618E86', 6, '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 'ExcaliburAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('9F1E2186-B9DF-4631-BDE6-6AB8F0B2F17E', 6, '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 'FrostAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('DAD8CA0C-690A-4AA8-B9B1-27726CF18F24', 6, '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 'LokiAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D41590CD-00C2-4756-912B-AEB84B8F036F', 6, '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 'MagAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('545439ED-70D2-4580-8D92-7FAC5EEE4B5B', 6, '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 'NyxAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2AB269CB-00FB-41FD-9721-B7406894F357', 6, '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 'RhinoAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('B41FFB22-5F4E-4F5D-9FDA-223AF215C936', 6, '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 'TrinityAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('533BE73A-CC8D-4159-89D6-3EAA0A39FB7A', 6, '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 'VoltAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('16EFB209-E206-4690-BC0A-A95C3D8BAFA3', 6, '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 'DaggerAxeBlueprint', 43200, 15000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C525CC08-F3CF-4B27-9290-FFA3AC0C5488', 6, '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 'DualDaggerAxeBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('747D6146-8B34-4AAE-AD7E-B6643BDC4BE7', 6, '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 'GrnHammerBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('61F4AD96-F5A2-4592-B3FB-98AE30343337', 6, '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 'BansheeAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D4FBB92E-2E0B-480B-95DF-0C6017E652BA', 6, '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 'SarynAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C911BC4E-7696-44A2-9BB0-79C98D47073C', 6, '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 'GrnAxeBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8572FC81-E73E-45E5-9918-F7D45D80A954', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 'AshChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisBlueprint', 'AshChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('96F31D55-46E9-4B49-8291-5B18D71810D0', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 'AshHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetBlueprint', 'AshHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C69AC191-798B-4094-8A9E-DE7AD2187549', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 'AshSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsBlueprint', 'AshSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('CECAEA9B-37C3-4CF0-B309-EFE49952C323', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 'EmberChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisBlueprint', 'EmberChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2F462CD2-BFBB-44F3-891E-EF0698B7C92C', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 'EmberHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetBlueprint', 'EmberHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E6E71AF6-8606-4C64-9A09-04F6C7A41B6D', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 'EmberSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsBlueprint', 'EmberSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E58DD103-94F0-4A47-9D39-2228A40C7EE2', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 'RhinoChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisBlueprint', 'RhinoChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('A88A784F-C9F8-4C9A-B878-C003C13E1A1A', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 'RhinoHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetBlueprint', 'RhinoHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8CFA3DBF-B1E9-4370-B594-86AB08F7EE75', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 'RhinoSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsBlueprint', 'RhinoSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('CBCD2D77-7455-4E08-AD14-0B1BFA449A88', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 'TrinityChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisBlueprint', 'TrinityChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('45612F91-6915-496C-84DA-434759E390FC', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 'TrinityHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetBlueprint', 'TrinityHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('38D1842A-710D-4710-8734-32AD899A1028', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 'TrinitySystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsBlueprint', 'TrinitySystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0830E3AD-1FB7-4E37-A2BD-973BF1A298D6', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 'MagChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisBlueprint', 'MagChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7AFB8DA8-3D4C-411C-B185-A68101FE365D', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 'MagHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetBlueprint', 'MagHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D5C6AC77-65F6-4C38-9778-62E843615FD5', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 'MagSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsBlueprint', 'MagSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1D726F44-E6B2-4D91-BD06-11B36C579471', 11, '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 'OrokinCatalystBlueprint', 86400, 25000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('B46F012E-EBBF-47D2-A9C3-FBE8669B7F82', 11, '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', '/Lotus/Types/Recipes/Components/OrokinReactorBlueprint', 'OrokinReactorBlueprint', 86400, 35000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('29B473BF-E2A7-42C3-93CB-0FCF22582BD3', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 'VOLTChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisBlueprint', 'VOLTChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('C282C1E1-2BAD-4D5C-8925-CFCF855B7421', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 'VOLTHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetBlueprint', 'VOLTHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('24EC315D-5FE5-4F2B-9583-C97838BED289', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 'VOLTSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsBlueprint', 'VOLTSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0F1646CF-BF81-4AC2-853E-273A5C218D6E', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 'ExcaliburChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisBlueprint', 'ExcaliburChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7A0546FC-2AA7-4E85-97A8-DF61173F7070', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 'ExcaliburHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetBlueprint', 'ExcaliburHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7BF7022A-599F-4FEF-A924-3B42DE79055D', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 'ExcaliburSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsBlueprint', 'ExcaliburSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('481D0084-3267-449B-A6F1-F636C96D7C9A', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 'LOKIChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisBlueprint', 'LOKIChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('CCC442FF-C65E-47C1-AF34-27DA8AB76D85', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 'LOKIHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetBlueprint', 'LOKIHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7CF2643E-0302-4099-ADDF-35598D3917ED', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 'LOKISystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsBlueprint', 'LOKISystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8821C513-3769-48D8-A4E2-18FF0CDFDB23', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 'NyxChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisBlueprint', 'NyxChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8429B40F-E244-4A45-92FD-271174824EF6', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 'NyxHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetBlueprint', 'NyxHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6152A9C2-3A18-4DC6-B2B1-55D16E09C894', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 'NyxSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsBlueprint', 'NyxSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D2560DFE-9A59-49AC-905F-534A9F161F42', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 'FrostChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisBlueprint', 'FrostChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4CB709EB-DC30-4C09-847E-E24AD68C8405', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 'FrostHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetBlueprint', 'FrostHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('641C3E5C-A85C-478C-87FC-FF8A5C1EED5B', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 'FrostSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsBlueprint', 'FrostSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('082A704B-1300-48B5-A9B6-B56C0E8BD76F', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 'SarynChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisBlueprint', 'SarynChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('709F4F55-00C8-4A40-AF8E-3ABD6FA5D7FD', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 'SarynHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetBlueprint', 'SarynHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('499F2A6D-4BF2-43FB-B097-0B3847330479', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 'SarynSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsBlueprint', 'SarynSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6520405A-B438-482F-B6DC-63CFFA463510', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 'BansheeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisBlueprint', 'BansheeChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('230224F6-D67C-46F5-A5FE-F033AE040564', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 'BansheeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetBlueprint', 'BansheeHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('D160892D-1DFB-4311-B95E-D9290173A1B6', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 'BansheeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsBlueprint', 'BansheeSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('04AA47DC-AC0C-466E-A5C5-E305E3CD0E16', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 'FrostPrimeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisBlueprint', 'FrostPrimeChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('AE8BD670-7014-466E-98EA-5F46C0A48498', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 'FrostPrimeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetBlueprint', 'FrostPrimeHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('E428899B-6130-4313-BAF6-78EA5CBF7BEA', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 'FrostPrimeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsBlueprint', 'FrostPrimeSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('912A7AFE-3117-4814-9374-777FC90C0FA8', 15, '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 'ShadePowerSuit', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 'ShadeSentinelBlueprint', 86400, 15000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('42EB5A8B-1699-46BD-9C45-E73C6C84ED6F', 15, '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 'WyrmPowerSuit', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 'WyrmSentinelBlueprint', 86400, 15000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');




INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('35F6D5DD-0BF4-4B45-B9EF-BAFFC8986EDA', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'F434D141-244C-4947-8920-90D3FBA30B20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E498EE92-7A57-4E22-A667-A25E5800BC61', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'F434D141-244C-4947-8920-90D3FBA30B20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('707103B7-F569-494C-BE42-78401B148E24', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', 'F434D141-244C-4947-8920-90D3FBA30B20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85E1CA77-1F24-4B59-95C9-077609481A0B', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'F434D141-244C-4947-8920-90D3FBA30B20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F1F7C813-2293-4844-B9FA-EAE9F12141A9', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '40C474B8-7858-4161-B75A-8D703164E4F8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D45D2DD7-C2D7-4125-8EA3-233E532961F9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '40C474B8-7858-4161-B75A-8D703164E4F8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8686FE60-9B9F-4657-A026-7CD008C9130C', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '40C474B8-7858-4161-B75A-8D703164E4F8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0E1A78A7-2BFE-4799-9373-F9C8C291634B', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '40C474B8-7858-4161-B75A-8D703164E4F8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89C65551-86DE-4B0E-B839-91DE99818522', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '802E4871-5704-43C0-AAD3-AAC746C90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4E0B6A79-B061-4053-9063-6CA460F4289A', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '802E4871-5704-43C0-AAD3-AAC746C90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4695468F-E8CF-4E17-B9E8-95D7B550AE07', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '802E4871-5704-43C0-AAD3-AAC746C90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6F892943-04F6-4410-AA24-F697390D3BE0', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '802E4871-5704-43C0-AAD3-AAC746C90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5561E417-458B-4A28-BEB0-06F642E7D09A', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '4F1DCB1E-1919-4ABC-9FF1-69265FE664DD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5FD9835C-4526-4E5D-B05A-28E82F72DFF9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '4F1DCB1E-1919-4ABC-9FF1-69265FE664DD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('90634363-1C10-4388-8212-399FEFDE0D07', '2025-05-09 10:44:56.198218-05:00', 450, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '4F1DCB1E-1919-4ABC-9FF1-69265FE664DD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FF0561AA-4005-431B-99FB-3A11AAA87FB6', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '4F1DCB1E-1919-4ABC-9FF1-69265FE664DD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9FFF1165-588D-485C-887B-B04ED95265B3', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'A035D87D-A503-4304-AF00-05D58AC93EBC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('008DB677-A956-457A-AE0F-3BF3671A08C9', '2025-05-09 10:44:56.198218-05:00', 800, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'A035D87D-A503-4304-AF00-05D58AC93EBC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3EF5E134-9A8D-4159-A09B-BB668ED8A16F', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'A035D87D-A503-4304-AF00-05D58AC93EBC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9EB03C00-68BF-4EC0-BB0D-3AA02F221785', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'A035D87D-A503-4304-AF00-05D58AC93EBC');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4F3690C3-1AE2-409E-B096-E346056A0BD0', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '0674D8B8-C391-489B-ACE4-EE5F40DEBFCA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E316506E-55EB-4B60-9FF3-459A475B71E2', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '0674D8B8-C391-489B-ACE4-EE5F40DEBFCA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('43420CD5-8BD8-403E-AC04-F4DEF51CC19B', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '0674D8B8-C391-489B-ACE4-EE5F40DEBFCA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4D6DFECF-9BD9-4C39-ACCA-F42D78567A69', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '0674D8B8-C391-489B-ACE4-EE5F40DEBFCA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('28B51D4C-3538-4AA1-BA69-04B67986971E', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '1D726F44-E6B2-4D91-BD06-11B36C579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0910A822-778E-4136-8E10-29A66E7CCADE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '1D726F44-E6B2-4D91-BD06-11B36C579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5B087553-8E28-4CC9-B459-41B6235CE6E9', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '1D726F44-E6B2-4D91-BD06-11B36C579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3E2FC848-8942-4069-BF26-90699C2A7086', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '1D726F44-E6B2-4D91-BD06-11B36C579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8703C3E5-A586-4853-8D51-B32AFE9ED39F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'B46F012E-EBBF-47D2-A9C3-FBE8669B7F82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89A9F82D-B837-4FAE-BEB2-90534C0C4AB7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'B46F012E-EBBF-47D2-A9C3-FBE8669B7F82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CF15C327-7B94-4439-9B9D-A3A0F8D87622', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'B46F012E-EBBF-47D2-A9C3-FBE8669B7F82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E7B6A987-768E-4DE2-91E6-6B5E089209C8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'B46F012E-EBBF-47D2-A9C3-FBE8669B7F82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1F9DEE92-C67D-4502-B435-FC5ED418BA96', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/AutoPistol', '2025-05-09 10:44:56.198218-05:00', 'AutoPistol', '16120F2A-35B7-4DBC-A543-A39D7FFD78BE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D177191B-5022-4802-9019-29515B26522E', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/AutoPistol', '2025-05-09 10:44:56.198218-05:00', 'AutoPistol', '16120F2A-35B7-4DBC-A543-A39D7FFD78BE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B306B3A9-1FE5-4F8F-A346-9FF94548B390', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '16120F2A-35B7-4DBC-A543-A39D7FFD78BE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77F2E80B-52F0-4750-9F73-57B081860A59', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/Pistol', '2025-05-09 10:44:56.198218-05:00', 'Pistol', 'A476979B-E665-4960-9503-1B89C5F36D0B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C5BC38FF-9D4A-4724-92A6-79190A0BA9BB', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'A476979B-E665-4960-9503-1B89C5F36D0B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FE2A0153-569D-4BEB-B388-9E026153324B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'A476979B-E665-4960-9503-1B89C5F36D0B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('96C5A946-6D28-4228-8FCD-F8E43EE8FF82', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'A476979B-E665-4960-9503-1B89C5F36D0B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1CC13D60-E6A7-4CAC-B347-0C6FC6C2E540', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTChassisComponent', 'DF27FC53-0436-41C6-925D-14039F1A8CF7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F8C232E7-FFE2-41AD-AEB0-D725030DE9FE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTHelmetComponent', 'DF27FC53-0436-41C6-925D-14039F1A8CF7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AFCFF78A-2811-4DAF-8F51-529EB9A2709D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTSystemsComponent', 'DF27FC53-0436-41C6-925D-14039F1A8CF7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('80E8B20E-871E-4A09-BB08-47567048D824', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'DF27FC53-0436-41C6-925D-14039F1A8CF7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('22B960E1-D95E-4D8E-B32C-E24FB1EE3523', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '29B473BF-E2A7-42C3-93CB-0FCF22582BD3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2193F8D9-3479-428E-BF70-10F9DDE03AD2', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '29B473BF-E2A7-42C3-93CB-0FCF22582BD3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6E684D74-07A8-4120-9777-35C26AF9ED30', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '29B473BF-E2A7-42C3-93CB-0FCF22582BD3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('81DCC0C1-DB39-49C0-B789-A0AD3861401A', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'C282C1E1-2BAD-4D5C-8925-CFCF855B7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5B9D792E-7886-428D-A1CE-ACD70FAE81D3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'C282C1E1-2BAD-4D5C-8925-CFCF855B7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3466B2EA-12CC-4A87-81E2-1A2731693EA3', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'C282C1E1-2BAD-4D5C-8925-CFCF855B7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FAB1D45F-C946-4A4D-B775-178087073177', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'C282C1E1-2BAD-4D5C-8925-CFCF855B7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B98CC47B-9F36-4440-90EC-206F92A41353', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '24EC315D-5FE5-4F2B-9583-C97838BED289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EE7EA636-25BD-4C18-837C-014E5EAEE8AE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '24EC315D-5FE5-4F2B-9583-C97838BED289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('97C2EFE5-4265-4D46-B1FA-9097EF8F365E', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '24EC315D-5FE5-4F2B-9583-C97838BED289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4CB92A8D-DD45-4D8D-9ADB-AF5B83495BA7', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '24EC315D-5FE5-4F2B-9583-C97838BED289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A14D8905-76FD-4D83-9D27-87653C2E663F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburChassisComponent', 'B882EE82-5A0D-41B8-9106-83BAD0DAD22C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C916348D-A1CB-4E69-B2BE-F061EC3BCD49', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburHelmetComponent', 'B882EE82-5A0D-41B8-9106-83BAD0DAD22C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('60541976-4BB4-47EA-A818-ABCE8705107D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburSystemsComponent', 'B882EE82-5A0D-41B8-9106-83BAD0DAD22C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2A644F56-BD41-429B-881C-1985846AC3F6', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'B882EE82-5A0D-41B8-9106-83BAD0DAD22C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F912DA75-C32E-4349-8CB2-2DBD4BE392F2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '0F1646CF-BF81-4AC2-853E-273A5C218D6E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('521E6297-7644-423E-B375-5CF3BB611060', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '0F1646CF-BF81-4AC2-853E-273A5C218D6E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('28F74DF9-180B-4194-8788-F87B87287089', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '0F1646CF-BF81-4AC2-853E-273A5C218D6E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8B50566B-57CB-4C2D-9B91-6F40168B9E61', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '7A0546FC-2AA7-4E85-97A8-DF61173F7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('73109F71-B5EF-408D-A479-89E88D948C52', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '7A0546FC-2AA7-4E85-97A8-DF61173F7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9F3CB970-B75C-4152-A472-B99B8AF42AE0', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '7A0546FC-2AA7-4E85-97A8-DF61173F7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('10D4E2E2-C991-4494-836C-09AC25610A82', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '7A0546FC-2AA7-4E85-97A8-DF61173F7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1CD0CD8E-74D4-4218-8DA9-54BAAC731154', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '7BF7022A-599F-4FEF-A924-3B42DE79055D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6E5D0D3A-6477-4C62-9522-EE8B1022864D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '7BF7022A-599F-4FEF-A924-3B42DE79055D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4AE06BDA-AB91-4A22-A867-228BF09B292F', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7BF7022A-599F-4FEF-A924-3B42DE79055D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D28EAE49-F456-4637-86CB-F5F9A354F6D0', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '7BF7022A-599F-4FEF-A924-3B42DE79055D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9F65CBD0-0FB3-4D2B-BE98-E50FFF911EB0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKIChassisComponent', 'C5617551-57A7-4C2F-B7EF-A60F5558DB91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C1F00A68-2EB9-453E-9950-F06A6F26C0B5', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKIHelmetComponent', 'C5617551-57A7-4C2F-B7EF-A60F5558DB91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('04924CF6-157A-4F67-8BE0-2A0A85688D50', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKISystemsComponent', 'C5617551-57A7-4C2F-B7EF-A60F5558DB91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8F230C30-51D2-4ECB-843B-D42FD49B6E6E', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'C5617551-57A7-4C2F-B7EF-A60F5558DB91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('68B471B2-55FB-40E5-AA98-6E87C5F0FF12', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '481D0084-3267-449B-A6F1-F636C96D7C9A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BA47862F-6C97-4AE7-AED9-98C2C8D12E6C', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '481D0084-3267-449B-A6F1-F636C96D7C9A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EDBBC3C7-1881-45B1-B391-E0BCD1E4F41B', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '481D0084-3267-449B-A6F1-F636C96D7C9A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4081A677-9BA9-4DAF-9452-A8A7F463A98A', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'CCC442FF-C65E-47C1-AF34-27DA8AB76D85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E368061E-E5D0-4BCB-AEB8-4B94FA17665F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'CCC442FF-C65E-47C1-AF34-27DA8AB76D85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('44262E2C-1F1B-4859-9A2C-0FD1DD76D3BF', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'CCC442FF-C65E-47C1-AF34-27DA8AB76D85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F026300F-4C97-4F7A-BBDE-26DE5A5BD16E', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'CCC442FF-C65E-47C1-AF34-27DA8AB76D85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BCECC285-DB4D-48AF-9EE7-B1095325F4CE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '7CF2643E-0302-4099-ADDF-35598D3917ED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2FE534FB-BBE1-4638-9874-F59E64A586CB', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '7CF2643E-0302-4099-ADDF-35598D3917ED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E136DBEB-3219-4E60-AC09-D99A8FD6E210', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7CF2643E-0302-4099-ADDF-35598D3917ED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3670728A-BC71-4869-996B-4F5B9F037833', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '7CF2643E-0302-4099-ADDF-35598D3917ED');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('359D5840-B5E4-4430-ADCE-AE86070761C6', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '3041CABE-43AC-4FA5-ADF9-70CA812D9C94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F8DE734D-C764-4091-AF5C-F292ADB1BE1C', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '3041CABE-43AC-4FA5-ADF9-70CA812D9C94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5DDC9CF8-9256-488B-ADA1-002DF67431B3', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '3041CABE-43AC-4FA5-ADF9-70CA812D9C94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BDE1CDEF-1126-40C5-AC21-DD116BCF666B', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '3041CABE-43AC-4FA5-ADF9-70CA812D9C94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C97B46CE-7A42-4C62-9C67-08E25BBCB2CC', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'E6A801BC-E2E5-4E67-ADD9-F8373FA8F321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DDC8F0C7-A816-4409-8800-BFACFD5965A8', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'E6A801BC-E2E5-4E67-ADD9-F8373FA8F321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E6607E3F-D4FF-43E4-87D3-AFC69CBC48A4', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'E6A801BC-E2E5-4E67-ADD9-F8373FA8F321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8B67FE9D-64EE-467B-9E44-AADD960A1C74', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'E6A801BC-E2E5-4E67-ADD9-F8373FA8F321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('98E0FB61-DE5E-44F9-8E37-2256FE43A864', '2025-05-09 10:44:56.198218-05:00', 4, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '8FFC2717-46C6-428B-AE37-091A8574847F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E65C9BEA-0A1B-4784-A0B4-568B41288E84', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '8FFC2717-46C6-428B-AE37-091A8574847F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('36121B73-DD2C-4B2B-9A84-360BFC987374', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '8FFC2717-46C6-428B-AE37-091A8574847F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('11A83B86-C747-4DBA-A838-79360DB10487', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8FFC2717-46C6-428B-AE37-091A8574847F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DEAEDFB8-9B99-4438-8A76-91F8180B8319', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxHelmetComponent', '46891BD1-10D4-409A-8E44-FC9C97416B3F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ECAF84FA-133A-4C2D-B99B-C1D5B8402C9D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxChassisComponent', '46891BD1-10D4-409A-8E44-FC9C97416B3F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ABB73A3B-6FBC-465F-BB5A-79C3215CDEDB', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxSystemsComponent', '46891BD1-10D4-409A-8E44-FC9C97416B3F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85C8891C-9C5A-4451-9B4C-44D0D978BD8F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '46891BD1-10D4-409A-8E44-FC9C97416B3F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('62920F1B-689D-49D0-8375-117D8FA8CBF3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '8821C513-3769-48D8-A4E2-18FF0CDFDB23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DD51B9F1-9D03-452E-A0C7-8DC40A3B2317', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '8821C513-3769-48D8-A4E2-18FF0CDFDB23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2A93A9D1-8DCD-4C7A-9956-DDC6A11A2259', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '8821C513-3769-48D8-A4E2-18FF0CDFDB23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DFF43F9E-E120-4BFD-AA28-21FA877ABA7A', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8429B40F-E244-4A45-92FD-271174824EF6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1FDC2523-225E-43EB-843D-E6030DECFF5E', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '8429B40F-E244-4A45-92FD-271174824EF6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B3C5AB0C-7F1F-4FAD-9F52-88009B78DBD5', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '8429B40F-E244-4A45-92FD-271174824EF6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3F1B2BAF-AC1A-4837-87AA-F640A327461F', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '8429B40F-E244-4A45-92FD-271174824EF6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('65637C7F-EBF1-46AE-8B0F-08AE08A5FA2C', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '6152A9C2-3A18-4DC6-B2B1-55D16E09C894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0E553013-5303-446C-9E24-9AE32C911555', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '6152A9C2-3A18-4DC6-B2B1-55D16E09C894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C4034A75-FF99-49D6-B5FF-6DBE6D2BE57A', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '6152A9C2-3A18-4DC6-B2B1-55D16E09C894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('34898E0D-81AC-4815-907E-EB255AEB3296', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '6152A9C2-3A18-4DC6-B2B1-55D16E09C894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D57D8843-68A9-4FAC-BD82-09756C638060', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostHelmetComponent', 'C8A34C48-B406-4F0E-8BDB-FF762BEFA3EE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('232E84A4-AE4F-44E2-9BB5-362ACC7A8DA8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostChassisComponent', 'C8A34C48-B406-4F0E-8BDB-FF762BEFA3EE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BCEADD3A-A441-4CB1-8716-CCEBB144C226', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostSystemsComponent', 'C8A34C48-B406-4F0E-8BDB-FF762BEFA3EE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2CD37C4B-8D8E-490C-A5C9-798B8448A654', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'C8A34C48-B406-4F0E-8BDB-FF762BEFA3EE');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('62A2B3A0-1EFA-4DD4-AD49-5541A3B76B1A', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'D2560DFE-9A59-49AC-905F-534A9F161F42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4654869B-52ED-4FA3-A3A2-D73B2D0BA6ED', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'D2560DFE-9A59-49AC-905F-534A9F161F42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0B98AACA-6AD6-44AE-95ED-A5210D56B269', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'D2560DFE-9A59-49AC-905F-534A9F161F42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('339B766A-BDE2-45F8-B2B7-47A58CF15155', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '4CB709EB-DC30-4C09-847E-E24AD68C8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D5E17790-DCFA-46EE-A2D6-B522AADD179D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '4CB709EB-DC30-4C09-847E-E24AD68C8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8EE587A7-B1C2-411D-A647-09870399F78B', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '4CB709EB-DC30-4C09-847E-E24AD68C8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A3AA340F-C474-4733-B2A8-68C571AFF3A5', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '4CB709EB-DC30-4C09-847E-E24AD68C8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('684704C7-F4ED-43D5-8378-8C5BF87BA3B2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '641C3E5C-A85C-478C-87FC-FF8A5C1EED5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1EA76D46-2986-4699-A652-2828E97FAD61', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '641C3E5C-A85C-478C-87FC-FF8A5C1EED5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A02D8E9E-493B-4138-BBA0-EBFFF80528EA', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '641C3E5C-A85C-478C-87FC-FF8A5C1EED5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77C417FD-CDC6-4849-86B4-13678AC70C6F', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '641C3E5C-A85C-478C-87FC-FF8A5C1EED5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D62EF98B-FD87-493F-8003-ADFA8BD9C513', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '8E133CAA-24E0-4372-A77C-734B867C4A6C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1207392A-E1B8-45BE-B9BD-92BAF9E4C8FC', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8E133CAA-24E0-4372-A77C-734B867C4A6C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E8CB1C09-DC0E-4CEE-9386-842F70EF181F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '8E133CAA-24E0-4372-A77C-734B867C4A6C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F6925A67-7599-453B-98F8-A9025931C081', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '8E133CAA-24E0-4372-A77C-734B867C4A6C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('369ECCFB-8AD8-48F1-8A89-F60023DAA980', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '12AF99FA-10E8-4960-BFEB-D66BA499B268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('86400B6E-C5A3-4DC4-A29E-8D4B2E179D29', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '12AF99FA-10E8-4960-BFEB-D66BA499B268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77F3C56E-5810-4A05-B6DE-5FA2421171D0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '12AF99FA-10E8-4960-BFEB-D66BA499B268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D7355204-B2E9-48D7-8A29-9BACC9FA5E66', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '12AF99FA-10E8-4960-BFEB-D66BA499B268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('38F3D988-771D-4097-AD02-7842D42C4814', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '6F419860-3551-4454-93E2-EB7007618E86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6AC75EC8-6A46-4194-9FA8-79189346521E', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '6F419860-3551-4454-93E2-EB7007618E86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('31DCF771-CD38-4D3D-8FA4-C1719111C2B4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '6F419860-3551-4454-93E2-EB7007618E86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8BBA8161-1AB7-4F29-A851-32CB41F7B8F1', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '6F419860-3551-4454-93E2-EB7007618E86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('36AB2EA0-0731-4FF4-8058-520C8F32C0CE', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '9F1E2186-B9DF-4631-BDE6-6AB8F0B2F17E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DA8214B3-73C5-4EFE-9958-7EDEB74A5EE0', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '9F1E2186-B9DF-4631-BDE6-6AB8F0B2F17E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('86F460BF-4C24-44DB-B272-D1487186843B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '9F1E2186-B9DF-4631-BDE6-6AB8F0B2F17E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FA720396-3A32-426B-BCEA-39F82E80811D', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '9F1E2186-B9DF-4631-BDE6-6AB8F0B2F17E');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A1740003-3EFA-4029-8001-26645070BBD0', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'DAD8CA0C-690A-4AA8-B9B1-27726CF18F24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('56681FB1-E613-4D65-838E-221CAAE732B5', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'DAD8CA0C-690A-4AA8-B9B1-27726CF18F24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A48D005E-6359-4066-B119-52C6D89DE809', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'DAD8CA0C-690A-4AA8-B9B1-27726CF18F24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CCD27F91-EC7B-41A9-93FB-7DAF17EE0E31', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'DAD8CA0C-690A-4AA8-B9B1-27726CF18F24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5D94CDD2-E35D-42BB-8A03-8329D46E0EC5', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'D41590CD-00C2-4756-912B-AEB84B8F036F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CBE120F0-8B3B-41DC-8C43-50CD144D2B26', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'D41590CD-00C2-4756-912B-AEB84B8F036F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ACF63CFD-9D6A-4167-A48B-DACC29C51F28', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'D41590CD-00C2-4756-912B-AEB84B8F036F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FDE7C543-5CF1-4C16-AB7E-0EA5EA883742', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'D41590CD-00C2-4756-912B-AEB84B8F036F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('528FA0AE-EE22-4BB0-9352-45454C1C4297', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '545439ED-70D2-4580-8D92-7FAC5EEE4B5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1840D725-E542-488D-BA53-516F20A633A1', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '545439ED-70D2-4580-8D92-7FAC5EEE4B5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B64AEBD4-9F87-421D-8262-A8B7B6BCF263', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '545439ED-70D2-4580-8D92-7FAC5EEE4B5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E9458192-11AF-4066-99D7-5CA50D79F6E9', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '545439ED-70D2-4580-8D92-7FAC5EEE4B5B');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E3AD840B-EF5C-4782-94D9-B06FAF00C856', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '2AB269CB-00FB-41FD-9721-B7406894F357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2A3C81A0-A3B8-4830-9247-66383331F2F4', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '2AB269CB-00FB-41FD-9721-B7406894F357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DA4A22EE-1048-40B5-B786-5592EE1E0783', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '2AB269CB-00FB-41FD-9721-B7406894F357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CEB2A9DE-AC29-4356-891D-48C8C5E1E20E', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '2AB269CB-00FB-41FD-9721-B7406894F357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A56C35AD-08F9-43C4-89CD-5C772A18B646', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'B41FFB22-5F4E-4F5D-9FDA-223AF215C936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D5B460AD-F310-4814-A482-04B97D2757A4', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'B41FFB22-5F4E-4F5D-9FDA-223AF215C936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4A709BE6-A799-44F6-8064-F1B7EC65AF48', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'B41FFB22-5F4E-4F5D-9FDA-223AF215C936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FB8512FA-D24C-43DA-B546-D0D585E6F708', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'B41FFB22-5F4E-4F5D-9FDA-223AF215C936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B09430CA-EB01-4EA7-95D7-5C94961FDBB2', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '533BE73A-CC8D-4159-89D6-3EAA0A39FB7A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('190FEE00-DB37-4827-BE21-1B81B10C27AF', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '533BE73A-CC8D-4159-89D6-3EAA0A39FB7A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AB5DCBAB-7D14-4829-987D-0E7F1DD07854', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '533BE73A-CC8D-4159-89D6-3EAA0A39FB7A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D8A54574-DE91-4854-86AA-E84686338DF6', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '533BE73A-CC8D-4159-89D6-3EAA0A39FB7A');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B1AF38D0-619D-465C-B8F8-2D79DF8F4242', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/CrossBow', '2025-05-09 10:44:56.198218-05:00', 'CrossBow', 'BEBEA877-DB0A-45DA-B126-FAE30BDCF034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A7F08690-289A-4B90-B3AC-B2498FA853AE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/CrossBow', '2025-05-09 10:44:56.198218-05:00', 'CrossBow', 'BEBEA877-DB0A-45DA-B126-FAE30BDCF034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9748C503-E990-4033-8A3B-6F732DA29EF7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'BEBEA877-DB0A-45DA-B126-FAE30BDCF034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('42DB7582-724D-4D70-AB14-CEEDCA388EDB', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '7EE3FA22-D976-4B2F-9B20-1AB7BCB0FAD9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D73CFE9D-FDEC-4D76-86F2-4708F05C4BE3', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '7EE3FA22-D976-4B2F-9B20-1AB7BCB0FAD9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7E559C49-6662-431D-9D1E-133128273291', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7EE3FA22-D976-4B2F-9B20-1AB7BCB0FAD9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A9C4CDD8-5393-4E3D-971D-CF5516FCF080', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '7EE3FA22-D976-4B2F-9B20-1AB7BCB0FAD9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('033D8E20-CC3E-4FDE-9F75-0ACFD1ACADE7', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'EEBEAAFE-62BC-4568-873B-DD41E838C92C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8821A8D4-0305-48AA-A332-5A9546589690', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'EEBEAAFE-62BC-4568-873B-DD41E838C92C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('155F6205-C3D6-48D2-A5AE-36BC61CA7358', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'EEBEAAFE-62BC-4568-873B-DD41E838C92C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('03807E12-F07B-4FB7-9E0B-7F9A7B9F111E', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'EEBEAAFE-62BC-4568-873B-DD41E838C92C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('327AB608-2247-4770-A454-34DC19910649', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'B38D441E-0E68-4C39-9D72-FD2E96EA1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('70428839-D878-4343-9451-70E1A8801D30', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'B38D441E-0E68-4C39-9D72-FD2E96EA1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C403F71E-1187-42DC-AA18-D57D6B6304ED', '2025-05-09 10:44:56.198218-05:00', 850, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'B38D441E-0E68-4C39-9D72-FD2E96EA1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2445501B-EB9E-4753-8DD5-1A57BE855493', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'B38D441E-0E68-4C39-9D72-FD2E96EA1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FC398CEE-8C95-40C0-A352-43554A167C0A', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '49F91A40-AB15-4A4C-9424-C18AC225A5E1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3511E609-F5EA-4C7C-BB75-9F3E4F06B7A5', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '49F91A40-AB15-4A4C-9424-C18AC225A5E1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('389DF448-4EC7-40AB-99A3-63CD11CD8728', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '49F91A40-AB15-4A4C-9424-C18AC225A5E1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('84FE3273-77CD-4D3B-92B3-FCD5E094CECF', '2025-05-09 10:44:56.198218-05:00', 120, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '49F91A40-AB15-4A4C-9424-C18AC225A5E1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B0500140-EF6F-409F-9788-4BCB6B61C066', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'E52AE0C2-01AB-4E97-B6A8-5649E69AA6E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('73F3F0B1-6B72-412D-81D6-58E60D233B37', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'E52AE0C2-01AB-4E97-B6A8-5649E69AA6E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85BFD63C-D97A-4622-A642-3C14A84F2DC2', '2025-05-09 10:44:56.198218-05:00', 250, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'E52AE0C2-01AB-4E97-B6A8-5649E69AA6E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AB7AEE4D-C818-4C69-9AEF-282C6F7CBD1D', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'E52AE0C2-01AB-4E97-B6A8-5649E69AA6E3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('30926E11-8DE7-4E73-88FF-60326B2BDBDC', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'D5C4BB0A-33E8-4C18-B0E7-F1AF815FB366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9B5C5A5C-7D7F-457D-ADE5-F92286C9E42A', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'D5C4BB0A-33E8-4C18-B0E7-F1AF815FB366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4FB35BD2-4A5A-4259-865B-A10E0E9F8C5E', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'D5C4BB0A-33E8-4C18-B0E7-F1AF815FB366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24D149B6-6574-476C-8AD6-F065E2EBF0EA', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', 'D5C4BB0A-33E8-4C18-B0E7-F1AF815FB366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A3DAC9B8-B63A-4911-A0B8-7F881539BEA7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '66DFCA4D-01FB-4E40-9D8D-C4B4637AF70D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1C181B06-AF72-4F81-8C57-F1CB8773859F', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '66DFCA4D-01FB-4E40-9D8D-C4B4637AF70D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8C214B34-ABD1-4973-A490-972A182B72E7', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '66DFCA4D-01FB-4E40-9D8D-C4B4637AF70D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8B41C7F3-F487-4A75-81D5-370F1867ED04', '2025-05-09 10:44:56.198218-05:00', 1250, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '66DFCA4D-01FB-4E40-9D8D-C4B4637AF70D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D1789644-841B-4072-8389-3666FD2F9B7D', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '113A1AFB-4CAC-40AA-826E-3F0AD6A434CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('57F622EA-F885-4A44-9C5C-08709A2BF700', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '113A1AFB-4CAC-40AA-826E-3F0AD6A434CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5B9BFA28-5465-4BD7-8FC2-7FAE16B8FC38', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '113A1AFB-4CAC-40AA-826E-3F0AD6A434CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FADF82C3-83F6-44B8-AD90-281EF95046B7', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '113A1AFB-4CAC-40AA-826E-3F0AD6A434CA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4DC5ECDB-37C0-4363-9BD1-1DB40E78E6E0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynHelmetComponent', 'BA3E23B6-0585-49BA-9EC0-0000ACA158D1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85A6AE85-87F6-4B8D-A1FB-CBE60703EDC2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynChassisComponent', 'BA3E23B6-0585-49BA-9EC0-0000ACA158D1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FA1624BC-1B90-43BC-A702-E3D2F7FC7BC4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynSystemsComponent', 'BA3E23B6-0585-49BA-9EC0-0000ACA158D1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('69F2FBD4-91A4-47B2-B2B4-24F05BA97F4B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'BA3E23B6-0585-49BA-9EC0-0000ACA158D1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3AE4A100-D310-43D6-AE99-A1643B829237', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '082A704B-1300-48B5-A9B6-B56C0E8BD76F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4E72823D-1CEE-49B0-A768-FCC78C290ACE', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '082A704B-1300-48B5-A9B6-B56C0E8BD76F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7C48C5A3-5358-4A2D-8675-E2906074A935', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '082A704B-1300-48B5-A9B6-B56C0E8BD76F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F63B27A6-4E1E-4A83-8C90-EDF33CA1AD45', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '709F4F55-00C8-4A40-AF8E-3ABD6FA5D7FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2176E069-8FED-42D5-9913-2F679C9D2EC3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '709F4F55-00C8-4A40-AF8E-3ABD6FA5D7FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('90E9B00B-52BE-49A5-ABC4-795FCF0ACD19', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '709F4F55-00C8-4A40-AF8E-3ABD6FA5D7FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8F856136-E810-4C74-B675-E2A22865F8A6', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '709F4F55-00C8-4A40-AF8E-3ABD6FA5D7FD');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9DF1B4CC-1984-4D66-A2A9-0F9839E72166', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '499F2A6D-4BF2-43FB-B097-0B3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A9AE36DF-BC1F-4E77-9FC8-2769E815DF35', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '499F2A6D-4BF2-43FB-B097-0B3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DCC644D0-B26B-4578-AC28-A9E02D80A623', '2025-05-09 10:44:56.198218-05:00', 550, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '499F2A6D-4BF2-43FB-B097-0B3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('551FA1A0-5801-408E-BBB9-27DD2E54569D', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '499F2A6D-4BF2-43FB-B097-0B3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4E7B018F-6D91-4A5A-8C86-FF3738FA8A81', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeHelmetComponent', '1ADF0512-A41D-49A1-9E76-F5909B8EE540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1C9D9619-1C86-4A8B-A687-679669716C2C', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeChassisComponent', '1ADF0512-A41D-49A1-9E76-F5909B8EE540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F6F9C83B-AC21-47BE-BC4B-91CE1CAABB91', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeSystemsComponent', '1ADF0512-A41D-49A1-9E76-F5909B8EE540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A6200730-45F0-48CF-8810-90397E0C123B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '1ADF0512-A41D-49A1-9E76-F5909B8EE540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9B80EC5F-6EC9-46DF-B47C-1418DFC7CCEF', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '6520405A-B438-482F-B6DC-63CFFA463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A2E89807-0677-4375-BC7F-4F64F6BF5291', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '6520405A-B438-482F-B6DC-63CFFA463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7A6689F1-4E7E-42FC-88ED-E35F63F47FCF', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '6520405A-B438-482F-B6DC-63CFFA463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('47B22210-621F-4C32-B627-DFB46A15246A', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '230224F6-D67C-46F5-A5FE-F033AE040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('95237F13-925A-410C-B9AD-C9A1C5BA9FEF', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '230224F6-D67C-46F5-A5FE-F033AE040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('57D6410C-B264-4C99-9F9B-7051E4FD524A', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '230224F6-D67C-46F5-A5FE-F033AE040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C099B685-DEE3-468F-85C9-B1C8657857FD', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '230224F6-D67C-46F5-A5FE-F033AE040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1FE267F6-52F4-4945-9CCE-28F49DC3E06F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', 'D160892D-1DFB-4311-B95E-D9290173A1B6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B0106370-EAE6-4746-B6C3-0078C83DEC4B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'D160892D-1DFB-4311-B95E-D9290173A1B6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24968079-FA66-4467-BE67-FA0BB05CF13C', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'D160892D-1DFB-4311-B95E-D9290173A1B6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C5775881-3366-4006-B2E0-D4F0F0D3DBBD', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'D160892D-1DFB-4311-B95E-D9290173A1B6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17D87551-6E34-45EA-8C88-507076AADE1B', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '912A7AFE-3117-4814-9374-777FC90C0FA8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17A150DA-4D64-472C-9D45-DBCB388C8908', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '912A7AFE-3117-4814-9374-777FC90C0FA8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('75D63DE8-471B-4991-849D-215AE4DB6797', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '912A7AFE-3117-4814-9374-777FC90C0FA8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('03AD6903-27F5-4962-B54B-B826739A49DD', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '912A7AFE-3117-4814-9374-777FC90C0FA8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0C1C93BD-2C11-4FC0-A00E-879E8D2B3E3F', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '42EB5A8B-1699-46BD-9C45-E73C6C84ED6F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AE22FA4C-2419-4D2A-92FB-4E240DBFFDE6', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '42EB5A8B-1699-46BD-9C45-E73C6C84ED6F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BCF44EAE-95D0-4B26-8F82-44CE671EDFF4', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '42EB5A8B-1699-46BD-9C45-E73C6C84ED6F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('54CDE7C2-113E-422B-A886-6241CF751A02', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '42EB5A8B-1699-46BD-9C45-E73C6C84ED6F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2500FEF1-DE59-4BA3-A5D2-C211AF40B2B8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '16EFB209-E206-4690-BC0A-A95C3D8BAFA3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4ABADAE1-159D-4965-8E01-22B94302776C', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '16EFB209-E206-4690-BC0A-A95C3D8BAFA3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9A251BFE-F4CC-4F12-8FBB-919D736722E2', '2025-05-09 10:44:56.198218-05:00', 550, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '16EFB209-E206-4690-BC0A-A95C3D8BAFA3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('EEC08BEB-DA0C-4B9F-A703-5CDF66364FF4', '2025-05-09 10:44:56.198218-05:00', 1200, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '16EFB209-E206-4690-BC0A-A95C3D8BAFA3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A2159F76-8885-41E6-AE25-95CE83EF9FC4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'C525CC08-F3CF-4B27-9290-FFA3AC0C5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('496FA55B-2A7A-444D-A728-086BC0A5B26F', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'C525CC08-F3CF-4B27-9290-FFA3AC0C5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('435DC3D0-18D5-47D2-9E75-6399BB7DDE72', '2025-05-09 10:44:56.198218-05:00', 650, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'C525CC08-F3CF-4B27-9290-FFA3AC0C5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CB5CD817-F0F9-4137-AA34-C56F42316F27', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'C525CC08-F3CF-4B27-9290-FFA3AC0C5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4922A908-9043-4C3E-B486-A09D7DA7BBF3', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '747D6146-8B34-4AAE-AD7E-B6643BDC4BE7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9BD6C9DF-4A15-4694-855A-41F2C4A1338D', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '747D6146-8B34-4AAE-AD7E-B6643BDC4BE7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3C1A949C-9959-47F9-AC37-252761F987DB', '2025-05-09 10:44:56.198218-05:00', 250, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '747D6146-8B34-4AAE-AD7E-B6643BDC4BE7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2CBB05CD-76B4-4A50-91D1-CC3B86CB9348', '2025-05-09 10:44:56.198218-05:00', 60, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '747D6146-8B34-4AAE-AD7E-B6643BDC4BE7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5490E8A0-5F51-4D3D-9E4E-60F5DCB75C83', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '61F4AD96-F5A2-4592-B3FB-98AE30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0055CFB9-5D12-4CEA-8A90-7F7DDF0F6107', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '61F4AD96-F5A2-4592-B3FB-98AE30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17DA1411-67D4-4F79-9EFF-6C70B496DC88', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '61F4AD96-F5A2-4592-B3FB-98AE30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BFEF3498-FC7D-45D9-B19D-3AED692E6BE5', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '61F4AD96-F5A2-4592-B3FB-98AE30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('AF80788D-324E-4F4F-943B-4A759FA8BC93', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'D4FBB92E-2E0B-480B-95DF-0C6017E652BA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E5FBFCF9-548F-4657-8D70-CADEBD9FF9C0', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'D4FBB92E-2E0B-480B-95DF-0C6017E652BA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6F1E7E56-9180-4EDC-ADFD-2080B528EC1B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'D4FBB92E-2E0B-480B-95DF-0C6017E652BA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1CC43A6E-8A1A-4FD1-9822-9FBBCA97F56C', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'D4FBB92E-2E0B-480B-95DF-0C6017E652BA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DF86F244-5076-421D-B3D1-F0451F5E216D', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'C911BC4E-7696-44A2-9BB0-79C98D47073C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A2BCE2F1-60F6-4287-9845-53503A71E1C9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'C911BC4E-7696-44A2-9BB0-79C98D47073C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('96BD833E-A563-4291-814B-E209A96EBAB2', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'C911BC4E-7696-44A2-9BB0-79C98D47073C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E7ACEB18-FE5F-4D12-89AB-AFF9529A31BA', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'C911BC4E-7696-44A2-9BB0-79C98D47073C');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F8F67094-0DE4-44DD-966D-B8BA80170E28', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '6500674A-0083-4A4A-8220-5BA94483C3B7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2750081E-C545-46F9-A21E-5843BD347573', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '6500674A-0083-4A4A-8220-5BA94483C3B7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('45FA2F0F-5249-4785-B4BE-1AD32094E888', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '6500674A-0083-4A4A-8220-5BA94483C3B7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8F5FEAB8-F637-41FF-98D0-2100A3270EC7', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '6500674A-0083-4A4A-8220-5BA94483C3B7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('967DEC3E-A880-48A0-B257-D5EFC143187F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', '2025-05-09 10:44:56.198218-05:00', 'GrineerLightPistol', '75C39EAF-FB46-4A55-AEDD-9806516325E8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('F61DC2B1-6143-4DA3-8C48-E5A668C06AC5', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', '2025-05-09 10:44:56.198218-05:00', 'GrineerLightPistol', '75C39EAF-FB46-4A55-AEDD-9806516325E8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('BF7E0A14-FEC9-4D91-B4B5-534B308A7D43', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '75C39EAF-FB46-4A55-AEDD-9806516325E8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('83C2036D-4CE3-4CF4-B7FA-13BAD01CF15B', '2025-05-09 10:44:56.198218-05:00', 5, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'F687E946-5F7B-4E17-ACE6-965B8F7916E5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6CBFA592-46E3-4BAA-B5E8-A66B49684159', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'F687E946-5F7B-4E17-ACE6-965B8F7916E5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0C333CE6-937B-43CF-BE66-D4E3AC2B74F7', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'F687E946-5F7B-4E17-ACE6-965B8F7916E5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D38DC6CB-652C-40C2-ADCF-52C5132FAD41', '2025-05-09 10:44:56.198218-05:00', 1200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', 'F687E946-5F7B-4E17-ACE6-965B8F7916E5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3E371FEF-0A8E-4204-A4E2-81A787E9D06D', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'CFD6DBEF-CEC1-4F1E-A84A-EA6CA87356D8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C86343AB-8532-45B8-B541-4DADA9BDA20D', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'CFD6DBEF-CEC1-4F1E-A84A-EA6CA87356D8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8A4B3C38-9EB8-4711-9EE8-053609DC7F7D', '2025-05-09 10:44:56.198218-05:00', 850, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'CFD6DBEF-CEC1-4F1E-A84A-EA6CA87356D8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('CEE41B29-31E3-40F4-A8F4-0AC77E345590', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'CFD6DBEF-CEC1-4F1E-A84A-EA6CA87356D8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1B5B583A-494E-4DBB-805B-2F0147FA0105', '2025-05-09 10:44:56.198218-05:00', 10, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '1C479545-A926-4E12-919D-E438E138DF27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('590FF71B-03BA-4C73-85B9-AA64073A6368', '2025-05-09 10:44:56.198218-05:00', 5000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '1C479545-A926-4E12-919D-E438E138DF27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B39592FD-09DB-4EE3-B105-3676BE68422E', '2025-05-09 10:44:56.198218-05:00', 6000, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '1C479545-A926-4E12-919D-E438E138DF27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B08FC354-47DE-4AAD-B8FA-EB59E56696C8', '2025-05-09 10:44:56.198218-05:00', 4500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '1C479545-A926-4E12-919D-E438E138DF27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DBC84751-7809-41AE-A7FF-CDFE95FA376D', '2025-05-09 10:44:56.198218-05:00', 700, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '19F771E1-180A-4B9B-AAD7-76F4D12A471D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('23CB944A-A401-4EAC-A869-44FB9D653A46', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '19F771E1-180A-4B9B-AAD7-76F4D12A471D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('50880CEC-BB16-4BB6-B7D6-617DD949B477', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '19F771E1-180A-4B9B-AAD7-76F4D12A471D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89205BDA-CC8D-488C-A595-1068B8834B53', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '19F771E1-180A-4B9B-AAD7-76F4D12A471D');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('B606445D-6964-4E18-8EC5-83224FF4ECBA', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'A7AB4F31-DF77-42CF-9CBB-879DF9555ACF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D3134D89-C46F-4674-8760-AC2B2C9AE861', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'A7AB4F31-DF77-42CF-9CBB-879DF9555ACF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('E7A2734C-FE76-4894-910A-B8FEF8B9EB1D', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'A7AB4F31-DF77-42CF-9CBB-879DF9555ACF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('16BA12B0-17D1-4993-B15D-08A63DEA9762', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'A7AB4F31-DF77-42CF-9CBB-879DF9555ACF');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7D3C2037-28A5-4D07-89B0-96DE85194283', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeHelmetComponent', '896BA6E7-CD0E-4258-A275-77814CF9491F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9E49C429-F44A-47EC-8BB6-605F635D2A3B', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeChassisComponent', '896BA6E7-CD0E-4258-A275-77814CF9491F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('D5A8203A-7C8F-4864-85FB-88BAB0540B25', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeSystemsComponent', '896BA6E7-CD0E-4258-A275-77814CF9491F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('81C33CBC-32AD-458D-B074-1EA6EFDA575F', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '896BA6E7-CD0E-4258-A275-77814CF9491F');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9590127D-D04A-4781-A55A-FDD08B4482DC', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '04AA47DC-AC0C-466E-A5C5-E305E3CD0E16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85FDAB25-5511-41CF-933C-43E1C9682013', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '04AA47DC-AC0C-466E-A5C5-E305E3CD0E16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5D4A061B-B5BB-4A8E-BA1F-F1E6A8AB4F51', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '04AA47DC-AC0C-466E-A5C5-E305E3CD0E16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('C10F8B59-7B55-4C36-8A36-381E3C78970E', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'AE8BD670-7014-466E-98EA-5F46C0A48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1EFB0E8F-DA92-4D5F-9900-2D918A734029', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'AE8BD670-7014-466E-98EA-5F46C0A48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DE4F3F64-E377-4D5E-BE99-E062F9B15A2A', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'AE8BD670-7014-466E-98EA-5F46C0A48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FA06BDD8-F79B-4D2E-9A73-3868387A520B', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'AE8BD670-7014-466E-98EA-5F46C0A48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1764E083-37E8-4EFC-9ED2-CC3AC8E413E6', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', 'E428899B-6130-4313-BAF6-78EA5CBF7BEA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24EC7DCA-559C-4D8A-AD80-429EFDBE8D40', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'E428899B-6130-4313-BAF6-78EA5CBF7BEA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2AEE1A60-7352-4B54-8BED-7F39145796DD', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'E428899B-6130-4313-BAF6-78EA5CBF7BEA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('FC683FDD-BBBA-41C6-A41C-ACA82A9F5475', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'E428899B-6130-4313-BAF6-78EA5CBF7BEA');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0E3FBB00-4EB0-4270-A32A-6065A80F6ECE', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'AshSystemsComponent', '732D0662-7068-494C-9F4F-A69CB2AE3875');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('23880B88-6BA7-4D55-BC4C-12F61EFC2C00', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'AshChassisComponent', '732D0662-7068-494C-9F4F-A69CB2AE3875');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('95CDB10E-6EBF-4026-9D1E-8369A8BE3BCB', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'AshHelmetComponent', '732D0662-7068-494C-9F4F-A69CB2AE3875');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('DD4D022D-0F4F-4BF2-A2DE-8650882FA903', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '732D0662-7068-494C-9F4F-A69CB2AE3875');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A1A856A7-9EEF-436D-83A3-3AABD82D2BC7', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '748C804F-332C-4EF9-AFF2-B6441909EB07');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('A3D9B9EE-AA64-4DCB-A205-8B92A9FC3F77', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '748C804F-332C-4EF9-AFF2-B6441909EB07');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('45CA125E-F457-4FF8-A6E7-367B4550D5F9', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '748C804F-332C-4EF9-AFF2-B6441909EB07');


");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}