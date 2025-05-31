using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRecipeDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from RecipeItems");
            migrationBuilder.Sql("Delete from Recipes");

            migrationBuilder.Sql(@"
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('16120f2a-35b7-4dbc-a543-a39d7ffd78be', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 'AFurisBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('a476979b-e665-4960-9503-1b89c5f36d0b', 0, '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 'BoltoBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('bebea877-db0a-45da-b126-fae30bdcf034', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 'AkBoltoBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('49f91a40-ab15-4a4c-9424-c18ac225a5e1', 0, '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 'GrnHeavyPistolBlueprint', 86400, 25000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d5c4bb0a-33e8-4c18-b0e7-f1af815fb366', 0, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 'GrineerLightPistolBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('75c39eaf-fb46-4a55-aedd-9806516325e8', 0, '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 'TwinViperBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0674d8b8-c391-489b-ace4-ee5f40debfca', 1, '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 'QuadShotgunBlueprint', 86400, 25000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7ee3fa22-d976-4b2f-9b20-1ab7bcb0fad9', 1, '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 'BoltorBlueprint', 86400, 25000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('66dfca4d-01fb-4e40-9d8d-c4b4637af70d', 1, '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 'HuntingBowBlueprint', 43200, 15000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('a7ab4f31-df77-42cf-9cbb-879df9555acf', 1, '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'GrnAssaultRifleBlueprint', 86400, 25000, 40, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('732D0662-7068-494C-9F4F-A69CB2AE3875', 3, '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'AshBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1d6ed9f5-8388-4f04-92bb-ca13e043a272', 3, '/Lotus/Powersuits/Ember/Ember', 'Ember', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'EmberBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('a8f93e5e-1586-4fec-9365-3e6d3b3046ee', 3, '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 'RhinoBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ef735264-eaae-46a3-a5f8-896a0512a953', 3, '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 'TrinityBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e601eff1-b742-4dbe-9e32-0e8f41181a89', 3, '/Lotus/Powersuits/Mag/Mag', 'Mag', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 'MagBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('df27fc53-0436-41c6-925d-14039f1a8cf7', 3, '/Lotus/Powersuits/Volt/Volt', 'Volt', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 'VOLTBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('b882ee82-5a0d-41b8-9106-83bad0dad22c', 3, '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 'ExcaliburBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c5617551-57a7-4c2f-b7ef-a60f5558db91', 3, '/Lotus/Powersuits/Loki/Loki', 'Loki', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 'LOKIBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('46891bd1-10d4-409a-8e44-fc9c97416b3f', 3, '/Lotus/Powersuits/Jade/Jade', 'Jade', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 'NyxBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c8a34c48-b406-4f0e-8bdb-ff762befa3ee', 3, '/Lotus/Powersuits/Frost/Frost', 'Frost', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 'FrostBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ba3e23b6-0585-49ba-9ec0-0000aca158d1', 3, '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 'SarynBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1adf0512-a41d-49a1-9e76-f5909b8ee540', 3, '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'BansheeBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('896ba6e7-cd0e-4258-a275-77814cf9491f', 3, '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 'FrostPrimeBlueprint', 259200, 25000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('5e2c0407-936d-4d29-b1b4-336ed5a7ffb2', 4, '/Lotus/Upgrades/Modules/Crafted/IncendiaryRifleMod', 'IncendiaryRifleMod', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 'IncendiaryRifleModBlueprint', 43200, 6000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('748c804f-332c-4ef9-aff2-b6441909eb07', 5, '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', '/Lotus/Types/Recipes/CronusBlueprint', 'CronusBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8123567d-7258-4335-a413-7938ae12f420', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 'CeramicDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ea1ea458-3732-4b57-9999-90e1a201896b', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 'DarkDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('15a14965-4bd8-4e16-926e-a1783c214c27', 5, '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 'HeatDaggerBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('f434d141-244c-4947-8920-90d3fba30b20', 5, '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 'HeatSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('40c474b8-7858-4161-b75a-8d703164e4f8', 5, '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 'JawBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('802e4871-5704-43c0-aad3-aac746c90706', 5, '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 'PangolinSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4f1dcb1e-1919-4abc-9ff1-69265fe664dd', 5, '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 'PlasmaSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('a035d87d-a503-4304-af00-05d58ac93ebc', 5, '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', '/Lotus/Types/Recipes/DarkSwordBlueprint', 'DarkSwordBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('3041cabe-43ac-4fa5-adf9-70ca812d9c94', 5, '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 'HammerBlueprint', 43200, 30000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e6a801bc-e2e5-4e67-add9-f8373fa8f321', 5, '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'AxeBlueprint', 43200, 30000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8ffc2717-46c6-428b-ae37-091a8574847f', 5, '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'DualAxeBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('eebeaafe-62bc-4568-873b-dd41e838c92c', 5, '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 'GreatSwordBlueprint', 43200, 30000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('b38d441e-0e68-4c39-9d72-fd2e96ea1922', 5, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 'DualHeatSwordBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e52ae0c2-01ab-4e97-b6a8-5649e69aa6e3', 5, '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 'GrnStaffBlueprint', 43200, 30000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('113a1afb-4cac-40aa-826e-3f0ad6a434ca', 5, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 'DualDaggerBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6500674a-0083-4a4a-8220-5ba94483c3b7', 5, '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 'MireSwordBlueprint', 43200, 20000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('f687e946-5f7b-4e17-ace6-965b8f7916e5', 5, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 'DualEtherDaggerBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('cfd6dbef-cec1-4f1e-a84a-ea6ca87356d8', 5, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 'DualEtherSwordBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1c479545-a926-4e12-919d-e438e138df27', 5, '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 'GlaiveBlueprint', 43200, 15000, 50, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('19f771e1-180a-4b9b-aad7-76f4d12a471d', 5, '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 'GauntletBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8e133caa-24e0-4372-a77c-734b867c4a6c', 6, '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 'AshAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('12af99fa-10e8-4960-bfeb-d66ba499b268', 6, '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 'EmberAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6f419860-3551-4454-93e2-eb7007618e86', 6, '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 'ExcaliburAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('9f1e2186-b9df-4631-bde6-6ab8f0b2f17e', 6, '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 'FrostAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('dad8ca0c-690a-4aa8-b9b1-27726cf18f24', 6, '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 'LokiAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d41590cd-00c2-4756-912b-aeb84b8f036f', 6, '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 'MagAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('545439ed-70d2-4580-8d92-7fac5eee4b5b', 6, '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 'NyxAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2ab269cb-00fb-41fd-9721-b7406894f357', 6, '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 'RhinoAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('b41ffb22-5f4e-4f5d-9fda-223af215c936', 6, '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 'TrinityAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('533be73a-cc8d-4159-89d6-3eaa0a39fb7a', 6, '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 'VoltAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('16efb209-e206-4690-bc0a-a95c3d8bafa3', 6, '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 'DaggerAxeBlueprint', 43200, 15000, 45, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c525cc08-f3cf-4b27-9290-ffa3ac0c5488', 6, '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 'DualDaggerAxeBlueprint', 43200, 20000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('747d6146-8b34-4aae-ad7e-b6643bdc4be7', 6, '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 'GrnHammerBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('61f4ad96-f5a2-4592-b3fb-98ae30343337', 6, '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 'BansheeAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d4fbb92e-2e0b-480b-95df-0c6017e652ba', 6, '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 'SarynAltHelmetBlueprint', 43200, 20000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c911bc4e-7696-44a2-9bb0-79c98d47073c', 6, '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 'GrnAxeBlueprint', 43200, 30000, 35, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8572fc81-e73e-45e5-9918-f7d45d80a954', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 'AshChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisBlueprint', 'AshChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('96f31d55-46e9-4b49-8291-5b18d71810d0', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 'AshHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetBlueprint', 'AshHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c69ac191-798b-4094-8a9e-de7ad2187549', 11, '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 'AshSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsBlueprint', 'AshSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('cecaea9b-37c3-4cf0-b309-efe49952c323', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 'EmberChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisBlueprint', 'EmberChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('2f462cd2-bfbb-44f3-891e-ef0698b7c92c', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 'EmberHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetBlueprint', 'EmberHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e6e71af6-8606-4c64-9a09-04f6c7a41b6d', 11, '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 'EmberSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsBlueprint', 'EmberSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e58dd103-94f0-4a47-9d39-2228a40c7ee2', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 'RhinoChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisBlueprint', 'RhinoChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('a88a784f-c9f8-4c9a-b878-c003c13e1a1a', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 'RhinoHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetBlueprint', 'RhinoHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8cfa3dbf-b1e9-4370-b594-86ab08f7ee75', 11, '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 'RhinoSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsBlueprint', 'RhinoSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('cbcd2d77-7455-4e08-ad14-0b1bfa449a88', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 'TrinityChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisBlueprint', 'TrinityChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('45612f91-6915-496c-84da-434759e390fc', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 'TrinityHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetBlueprint', 'TrinityHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('38d1842a-710d-4710-8734-32ad899a1028', 11, '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 'TrinitySystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsBlueprint', 'TrinitySystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0830e3ad-1fb7-4e37-a2bd-973bf1a298d6', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 'MagChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisBlueprint', 'MagChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7afb8da8-3d4c-411c-b185-a68101fe365d', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 'MagHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetBlueprint', 'MagHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d5c6ac77-65f6-4c38-9778-62e843615fd5', 11, '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 'MagSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsBlueprint', 'MagSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('1d726f44-e6b2-4d91-bd06-11b36c579471', 11, '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 'OrokinCatalystBlueprint', 86400, 25000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('b46f012e-ebbf-47d2-a9c3-fbe8669b7f82', 11, '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', '/Lotus/Types/Recipes/Components/OrokinReactorBlueprint', 'OrokinReactorBlueprint', 86400, 35000, 10, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('29b473bf-e2a7-42c3-93cb-0fcf22582bd3', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 'VOLTChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisBlueprint', 'VOLTChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('c282c1e1-2bad-4d5c-8925-cfcf855b7421', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 'VOLTHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetBlueprint', 'VOLTHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('24ec315d-5fe5-4f2b-9583-c97838bed289', 11, '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 'VOLTSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsBlueprint', 'VOLTSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('0f1646cf-bf81-4ac2-853e-273a5c218d6e', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 'ExcaliburChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisBlueprint', 'ExcaliburChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7a0546fc-2aa7-4e85-97a8-df61173f7070', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 'ExcaliburHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetBlueprint', 'ExcaliburHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7bf7022a-599f-4fef-a924-3b42de79055d', 11, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 'ExcaliburSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsBlueprint', 'ExcaliburSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('481d0084-3267-449b-a6f1-f636c96d7c9a', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 'LOKIChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisBlueprint', 'LOKIChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ccc442ff-c65e-47c1-af34-27da8ab76d85', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 'LOKIHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetBlueprint', 'LOKIHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('7cf2643e-0302-4099-addf-35598d3917ed', 11, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 'LOKISystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsBlueprint', 'LOKISystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8821c513-3769-48d8-a4e2-18ff0cdfdb23', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 'NyxChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisBlueprint', 'NyxChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('8429b40f-e244-4a45-92fd-271174824ef6', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 'NyxHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetBlueprint', 'NyxHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6152a9c2-3a18-4dc6-b2b1-55d16e09c894', 11, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 'NyxSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsBlueprint', 'NyxSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d2560dfe-9a59-49ac-905f-534a9f161f42', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 'FrostChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisBlueprint', 'FrostChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('4cb709eb-dc30-4c09-847e-e24ad68c8405', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 'FrostHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetBlueprint', 'FrostHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('641c3e5c-a85c-478c-87fc-ff8a5c1eed5b', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 'FrostSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsBlueprint', 'FrostSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('082a704b-1300-48b5-a9b6-b56c0e8bd76f', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 'SarynChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisBlueprint', 'SarynChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('709f4f55-00c8-4a40-af8e-3abd6fa5d7fd', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 'SarynHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetBlueprint', 'SarynHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('499f2a6d-4bf2-43fb-b097-0b3847330479', 11, '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 'SarynSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsBlueprint', 'SarynSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('6520405a-b438-482f-b6dc-63cffa463510', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 'BansheeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisBlueprint', 'BansheeChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('230224f6-d67c-46f5-a5fe-f033ae040564', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 'BansheeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetBlueprint', 'BansheeHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('d160892d-1dfb-4311-b95e-d9290173a1b6', 11, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 'BansheeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsBlueprint', 'BansheeSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('04aa47dc-ac0c-466e-a5c5-e305e3cd0e16', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 'FrostPrimeChassisComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisBlueprint', 'FrostPrimeChassisBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('ae8bd670-7014-466e-98ea-5f46c0a48498', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 'FrostPrimeHelmetComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetBlueprint', 'FrostPrimeHelmetBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('e428899b-6130-4313-baf6-78ea5cbf7bea', 11, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 'FrostPrimeSystemsComponent', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsBlueprint', 'FrostPrimeSystemsBlueprint', 43200, 15000, 0, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('912a7afe-3117-4814-9374-777fc90c0fa8', 15, '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 'ShadePowerSuit', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 'ShadeSentinelBlueprint', 86400, 15000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
INSERT INTO Recipes
(Id, InternalInventoryItemType, ResultItemName, ResultItemPrettyName, RecipeItemName, RecipeItemPrettyName, BuildTimeInSeconds, PriceInStandardCredits, SkipBuildPriceInPlatinum, CreationTimestamp, LastModificationTimestamp)
VALUES('42eb5a8b-1699-46bd-9c45-e73c6c84ed6f', 15, '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 'WyrmPowerSuit', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 'WyrmSentinelBlueprint', 86400, 15000, 30, '2025-05-09 10:44:56.198218-05:00', '2025-05-09 10:44:56.198218-05:00');
");


            migrationBuilder.Sql(@"
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('35f6d5dd-0bf4-4b45-b9ef-baffc8986eda', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'f434d141-244c-4947-8920-90d3fba30b20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e498ee92-7a57-4e22-a667-a25e5800bc61', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'f434d141-244c-4947-8920-90d3fba30b20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('707103b7-f569-494c-be42-78401b148e24', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', 'f434d141-244c-4947-8920-90d3fba30b20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85e1ca77-1f24-4b59-95c9-077609481a0b', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'f434d141-244c-4947-8920-90d3fba30b20');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f1f7c813-2293-4844-b9fa-eae9f12141a9', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '40c474b8-7858-4161-b75a-8d703164e4f8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d45d2dd7-c2d7-4125-8ea3-233e532961f9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '40c474b8-7858-4161-b75a-8d703164e4f8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8686fe60-9b9f-4657-a026-7cd008c9130c', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '40c474b8-7858-4161-b75a-8d703164e4f8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0e1a78a7-2bfe-4799-9373-f9c8c291634b', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '40c474b8-7858-4161-b75a-8d703164e4f8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89c65551-86de-4b0e-b839-91de99818522', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '802e4871-5704-43c0-aad3-aac746c90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4e0b6a79-b061-4053-9063-6ca460f4289a', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '802e4871-5704-43c0-aad3-aac746c90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4695468f-e8cf-4e17-b9e8-95d7b550ae07', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '802e4871-5704-43c0-aad3-aac746c90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6f892943-04f6-4410-aa24-f697390d3be0', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '802e4871-5704-43c0-aad3-aac746c90706');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5561e417-458b-4a28-beb0-06f642e7d09a', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '4f1dcb1e-1919-4abc-9ff1-69265fe664dd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5fd9835c-4526-4e5d-b05a-28e82f72dff9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '4f1dcb1e-1919-4abc-9ff1-69265fe664dd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('90634363-1c10-4388-8212-399fefde0d07', '2025-05-09 10:44:56.198218-05:00', 450, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '4f1dcb1e-1919-4abc-9ff1-69265fe664dd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ff0561aa-4005-431b-99fb-3a11aaa87fb6', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '4f1dcb1e-1919-4abc-9ff1-69265fe664dd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9fff1165-588d-485c-887b-b04ed95265b3', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'a035d87d-a503-4304-af00-05d58ac93ebc');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('008db677-a956-457a-ae0f-3bf3671a08c9', '2025-05-09 10:44:56.198218-05:00', 800, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'a035d87d-a503-4304-af00-05d58ac93ebc');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3ef5e134-9a8d-4159-a09b-bb668ed8a16f', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'a035d87d-a503-4304-af00-05d58ac93ebc');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9eb03c00-68bf-4ec0-bb0d-3aa02f221785', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'a035d87d-a503-4304-af00-05d58ac93ebc');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4f3690c3-1ae2-409e-b096-e346056a0bd0', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '0674d8b8-c391-489b-ace4-ee5f40debfca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e316506e-55eb-4b60-9ff3-459a475b71e2', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '0674d8b8-c391-489b-ace4-ee5f40debfca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('43420cd5-8bd8-403e-ac04-f4def51cc19b', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '0674d8b8-c391-489b-ace4-ee5f40debfca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4d6dfecf-9bd9-4c39-acca-f42d78567a69', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '0674d8b8-c391-489b-ace4-ee5f40debfca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('28b51d4c-3538-4aa1-ba69-04b67986971e', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '1d726f44-e6b2-4d91-bd06-11b36c579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0910a822-778e-4136-8e10-29a66e7ccade', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '1d726f44-e6b2-4d91-bd06-11b36c579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5b087553-8e28-4cc9-b459-41b6235ce6e9', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '1d726f44-e6b2-4d91-bd06-11b36c579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3e2fc848-8942-4069-bf26-90699c2a7086', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '1d726f44-e6b2-4d91-bd06-11b36c579471');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8703c3e5-a586-4853-8d51-b32afe9ed39f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'b46f012e-ebbf-47d2-a9c3-fbe8669b7f82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89a9f82d-b837-4fae-beb2-90534c0c4ab7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'b46f012e-ebbf-47d2-a9c3-fbe8669b7f82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('cf15c327-7b94-4439-9b9d-a3a0f8d87622', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'b46f012e-ebbf-47d2-a9c3-fbe8669b7f82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e7b6a987-768e-4de2-91e6-6b5e089209c8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'b46f012e-ebbf-47d2-a9c3-fbe8669b7f82');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1f9dee92-c67d-4502-b435-fc5ed418ba96', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/AutoPistol', '2025-05-09 10:44:56.198218-05:00', 'AutoPistol', '16120f2a-35b7-4dbc-a543-a39d7ffd78be');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d177191b-5022-4802-9019-29515b26522e', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/AutoPistol', '2025-05-09 10:44:56.198218-05:00', 'AutoPistol', '16120f2a-35b7-4dbc-a543-a39d7ffd78be');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b306b3a9-1fe5-4f8f-a346-9ff94548b390', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '16120f2a-35b7-4dbc-a543-a39d7ffd78be');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77f2e80b-52f0-4750-9f73-57b081860a59', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/Pistol', '2025-05-09 10:44:56.198218-05:00', 'Pistol', 'a476979b-e665-4960-9503-1b89c5f36d0b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c5bc38ff-9d4a-4724-92a6-79190a0ba9bb', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'a476979b-e665-4960-9503-1b89c5f36d0b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fe2a0153-569d-4beb-b388-9e026153324b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'a476979b-e665-4960-9503-1b89c5f36d0b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('96c5a946-6d28-4228-8fcd-f8e43ee8ff82', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'a476979b-e665-4960-9503-1b89c5f36d0b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1cc13d60-e6a7-4cac-b347-0c6fc6c2e540', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTChassisComponent', 'df27fc53-0436-41c6-925d-14039f1a8cf7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f8c232e7-ffe2-41ad-aeb0-d725030de9fe', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTHelmetComponent', 'df27fc53-0436-41c6-925d-14039f1a8cf7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('afcff78a-2811-4daf-8f51-529eb9a2709d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'VOLTSystemsComponent', 'df27fc53-0436-41c6-925d-14039f1a8cf7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('80e8b20e-871e-4a09-bb08-47567048d824', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'df27fc53-0436-41c6-925d-14039f1a8cf7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('22b960e1-d95e-4d8e-b32c-e24fb1ee3523', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '29b473bf-e2a7-42c3-93cb-0fcf22582bd3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2193f8d9-3479-428e-bf70-10f9dde03ad2', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '29b473bf-e2a7-42c3-93cb-0fcf22582bd3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6e684d74-07a8-4120-9777-35c26af9ed30', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '29b473bf-e2a7-42c3-93cb-0fcf22582bd3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('81dcc0c1-db39-49c0-b789-a0ad3861401a', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'c282c1e1-2bad-4d5c-8925-cfcf855b7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5b9d792e-7886-428d-a1ce-acd70fae81d3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'c282c1e1-2bad-4d5c-8925-cfcf855b7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3466b2ea-12cc-4a87-81e2-1a2731693ea3', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'c282c1e1-2bad-4d5c-8925-cfcf855b7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fab1d45f-c946-4a4d-b775-178087073177', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'c282c1e1-2bad-4d5c-8925-cfcf855b7421');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b98cc47b-9f36-4440-90ec-206f92a41353', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '24ec315d-5fe5-4f2b-9583-c97838bed289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ee7ea636-25bd-4c18-837c-014e5eaee8ae', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '24ec315d-5fe5-4f2b-9583-c97838bed289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('97c2efe5-4265-4d46-b1fa-9097ef8f365e', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '24ec315d-5fe5-4f2b-9583-c97838bed289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4cb92a8d-dd45-4d8d-9adb-af5b83495ba7', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '24ec315d-5fe5-4f2b-9583-c97838bed289');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a14d8905-76fd-4d83-9d27-87653c2e663f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburChassisComponent', 'b882ee82-5a0d-41b8-9106-83bad0dad22c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c916348d-a1cb-4e69-b2be-f061ec3bcd49', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburHelmetComponent', 'b882ee82-5a0d-41b8-9106-83bad0dad22c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('60541976-4bb4-47ea-a818-abce8705107d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'ExcaliburSystemsComponent', 'b882ee82-5a0d-41b8-9106-83bad0dad22c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2a644f56-bd41-429b-881c-1985846ac3f6', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'b882ee82-5a0d-41b8-9106-83bad0dad22c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f912da75-c32e-4349-8cb2-2dbd4be392f2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '0f1646cf-bf81-4ac2-853e-273a5c218d6e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('521e6297-7644-423e-b375-5cf3bb611060', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '0f1646cf-bf81-4ac2-853e-273a5c218d6e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('28f74df9-180b-4194-8788-f87b87287089', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '0f1646cf-bf81-4ac2-853e-273a5c218d6e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8b50566b-57cb-4c2d-9b91-6f40168b9e61', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '7a0546fc-2aa7-4e85-97a8-df61173f7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('73109f71-b5ef-408d-a479-89e88d948c52', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '7a0546fc-2aa7-4e85-97a8-df61173f7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9f3cb970-b75c-4152-a472-b99b8af42ae0', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '7a0546fc-2aa7-4e85-97a8-df61173f7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('10d4e2e2-c991-4494-836c-09ac25610a82', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '7a0546fc-2aa7-4e85-97a8-df61173f7070');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1cd0cd8e-74d4-4218-8da9-54baac731154', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '7bf7022a-599f-4fef-a924-3b42de79055d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6e5d0d3a-6477-4c62-9522-ee8b1022864d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '7bf7022a-599f-4fef-a924-3b42de79055d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4ae06bda-ab91-4a22-a867-228bf09b292f', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7bf7022a-599f-4fef-a924-3b42de79055d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d28eae49-f456-4637-86cb-f5f9a354f6d0', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '7bf7022a-599f-4fef-a924-3b42de79055d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9f65cbd0-0fb3-4d2b-be98-e50fff911eb0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKIChassisComponent', 'c5617551-57a7-4c2f-b7ef-a60f5558db91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c1f00a68-2eb9-453e-9950-f06a6f26c0b5', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKIHelmetComponent', 'c5617551-57a7-4c2f-b7ef-a60f5558db91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('04924cf6-157a-4f67-8be0-2a0a85688d50', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'LOKISystemsComponent', 'c5617551-57a7-4c2f-b7ef-a60f5558db91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8f230c30-51d2-4ecb-843b-d42fd49b6e6e', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'c5617551-57a7-4c2f-b7ef-a60f5558db91');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('68b471b2-55fb-40e5-aa98-6e87c5f0ff12', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '481d0084-3267-449b-a6f1-f636c96d7c9a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ba47862f-6c97-4ae7-aed9-98c2c8d12e6c', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '481d0084-3267-449b-a6f1-f636c96d7c9a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('edbbc3c7-1881-45b1-b391-e0bcd1e4f41b', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '481d0084-3267-449b-a6f1-f636c96d7c9a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4081a677-9ba9-4daf-9452-a8a7f463a98a', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'ccc442ff-c65e-47c1-af34-27da8ab76d85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e368061e-e5d0-4bcb-aeb8-4b94fa17665f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'ccc442ff-c65e-47c1-af34-27da8ab76d85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('44262e2c-1f1b-4859-9a2c-0fd1dd76d3bf', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'ccc442ff-c65e-47c1-af34-27da8ab76d85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f026300f-4c97-4f7a-bbde-26de5a5bd16e', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'ccc442ff-c65e-47c1-af34-27da8ab76d85');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bcecc285-db4d-48af-9ee7-b1095325f4ce', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '7cf2643e-0302-4099-addf-35598d3917ed');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2fe534fb-bbe1-4638-9874-f59e64a586cb', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '7cf2643e-0302-4099-addf-35598d3917ed');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e136dbeb-3219-4e60-ac09-d99a8fd6e210', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7cf2643e-0302-4099-addf-35598d3917ed');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3670728a-bc71-4869-996b-4f5b9f037833', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '7cf2643e-0302-4099-addf-35598d3917ed');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('359d5840-b5e4-4430-adce-ae86070761c6', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '3041cabe-43ac-4fa5-adf9-70ca812d9c94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f8de734d-c764-4091-af5c-f292adb1be1c', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '3041cabe-43ac-4fa5-adf9-70ca812d9c94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5ddc9cf8-9256-488b-ada1-002df67431b3', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '3041cabe-43ac-4fa5-adf9-70ca812d9c94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bde1cdef-1126-40c5-ac21-dd116bcf666b', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '3041cabe-43ac-4fa5-adf9-70ca812d9c94');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c97b46ce-7a42-4c62-9c67-08e25bbcb2cc', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'e6a801bc-e2e5-4e67-add9-f8373fa8f321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ddc8f0c7-a816-4409-8800-bfacfd5965a8', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'e6a801bc-e2e5-4e67-add9-f8373fa8f321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e6607e3f-d4ff-43e4-87d3-afc69cbc48a4', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'e6a801bc-e2e5-4e67-add9-f8373fa8f321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8b67fe9d-64ee-467b-9e44-aadd960a1c74', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'e6a801bc-e2e5-4e67-add9-f8373fa8f321');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('98e0fb61-de5e-44f9-8e37-2256fe43a864', '2025-05-09 10:44:56.198218-05:00', 4, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '8ffc2717-46c6-428b-ae37-091a8574847f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e65c9bea-0a1b-4784-a0b4-568b41288e84', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '8ffc2717-46c6-428b-ae37-091a8574847f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('36121b73-dd2c-4b2b-9a84-360bfc987374', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '8ffc2717-46c6-428b-ae37-091a8574847f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('11a83b86-c747-4dba-a838-79360db10487', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8ffc2717-46c6-428b-ae37-091a8574847f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('deaedfb8-9b99-4438-8a76-91f8180b8319', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxHelmetComponent', '46891bd1-10d4-409a-8e44-fc9c97416b3f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ecaf84fa-133a-4c2d-b99b-c1d5b8402c9d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxChassisComponent', '46891bd1-10d4-409a-8e44-fc9c97416b3f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('abb73a3b-6fbc-465f-bb5a-79c3215cdedb', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'NyxSystemsComponent', '46891bd1-10d4-409a-8e44-fc9c97416b3f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85c8891c-9c5a-4451-9b4c-44d0d978bd8f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '46891bd1-10d4-409a-8e44-fc9c97416b3f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('62920f1b-689d-49d0-8375-117d8fa8cbf3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '8821c513-3769-48d8-a4e2-18ff0cdfdb23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('dd51b9f1-9d03-452e-a0c7-8dc40a3b2317', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '8821c513-3769-48d8-a4e2-18ff0cdfdb23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2a93a9d1-8dcd-4c7a-9956-ddc6a11a2259', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '8821c513-3769-48d8-a4e2-18ff0cdfdb23');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('dff43f9e-e120-4bfd-aa28-21fa877aba7a', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8429b40f-e244-4a45-92fd-271174824ef6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1fdc2523-225e-43eb-843d-e6030decff5e', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '8429b40f-e244-4a45-92fd-271174824ef6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b3c5ab0c-7f1f-4fad-9f52-88009b78dbd5', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '8429b40f-e244-4a45-92fd-271174824ef6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3f1b2baf-ac1a-4837-87aa-f640a327461f', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '8429b40f-e244-4a45-92fd-271174824ef6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('65637c7f-ebf1-46ae-8b0f-08ae08a5fa2c', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '6152a9c2-3a18-4dc6-b2b1-55d16e09c894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0e553013-5303-446c-9e24-9ae32c911555', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '6152a9c2-3a18-4dc6-b2b1-55d16e09c894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c4034a75-ff99-49d6-b5ff-6dbe6d2be57a', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '6152a9c2-3a18-4dc6-b2b1-55d16e09c894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('34898e0d-81ac-4815-907e-eb255aeb3296', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '6152a9c2-3a18-4dc6-b2b1-55d16e09c894');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d57d8843-68a9-4fac-bd82-09756c638060', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostHelmetComponent', 'c8a34c48-b406-4f0e-8bdb-ff762befa3ee');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('232e84a4-ae4f-44e2-9bb5-362acc7a8da8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostChassisComponent', 'c8a34c48-b406-4f0e-8bdb-ff762befa3ee');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bceadd3a-a441-4cb1-8716-ccebb144c226', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostSystemsComponent', 'c8a34c48-b406-4f0e-8bdb-ff762befa3ee');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2cd37c4b-8d8e-490c-a5c9-798b8448a654', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'c8a34c48-b406-4f0e-8bdb-ff762befa3ee');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('62a2b3a0-1efa-4dd4-ad49-5541a3b76b1a', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'd2560dfe-9a59-49ac-905f-534a9f161f42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4654869b-52ed-4fa3-a3a2-d73b2d0ba6ed', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'd2560dfe-9a59-49ac-905f-534a9f161f42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0b98aaca-6ad6-44ae-95ed-a5210d56b269', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'd2560dfe-9a59-49ac-905f-534a9f161f42');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('339b766a-bde2-45f8-b2b7-47a58cf15155', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '4cb709eb-dc30-4c09-847e-e24ad68c8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d5e17790-dcfa-46ee-a2d6-b522aadd179d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '4cb709eb-dc30-4c09-847e-e24ad68c8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8ee587a7-b1c2-411d-a647-09870399f78b', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '4cb709eb-dc30-4c09-847e-e24ad68c8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a3aa340f-c474-4733-b2a8-68c571aff3a5', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '4cb709eb-dc30-4c09-847e-e24ad68c8405');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('684704c7-f4ed-43d5-8378-8c5bf87ba3b2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '641c3e5c-a85c-478c-87fc-ff8a5c1eed5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1ea76d46-2986-4699-a652-2828e97fad61', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '641c3e5c-a85c-478c-87fc-ff8a5c1eed5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a02d8e9e-493b-4138-bba0-ebfff80528ea', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '641c3e5c-a85c-478c-87fc-ff8a5c1eed5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77c417fd-cdc6-4849-86b4-13678ac70c6f', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '641c3e5c-a85c-478c-87fc-ff8a5c1eed5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d62ef98b-fd87-493f-8003-adfa8bd9c513', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '8e133caa-24e0-4372-a77c-734b867c4a6c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1207392a-e1b8-45be-b9bd-92baf9e4c8fc', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '8e133caa-24e0-4372-a77c-734b867c4a6c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e8cb1c09-dc0e-4cee-9386-842f70ef181f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '8e133caa-24e0-4372-a77c-734b867c4a6c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f6925a67-7599-453b-98f8-a9025931c081', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '8e133caa-24e0-4372-a77c-734b867c4a6c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('369eccfb-8ad8-48f1-8a89-f60023daa980', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '12af99fa-10e8-4960-bfeb-d66ba499b268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('86400b6e-c5a3-4dc4-a29e-8d4b2e179d29', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '12af99fa-10e8-4960-bfeb-d66ba499b268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('77f3c56e-5810-4a05-b6de-5fa2421171d0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '12af99fa-10e8-4960-bfeb-d66ba499b268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d7355204-b2e9-48d7-8a29-9bacc9fa5e66', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '12af99fa-10e8-4960-bfeb-d66ba499b268');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('38f3d988-771d-4097-ad02-7842d42c4814', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '6f419860-3551-4454-93e2-eb7007618e86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6ac75ec8-6a46-4194-9fa8-79189346521e', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '6f419860-3551-4454-93e2-eb7007618e86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('31dcf771-cd38-4d3d-8fa4-c1719111c2b4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '6f419860-3551-4454-93e2-eb7007618e86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8bba8161-1ab7-4f29-a851-32cb41f7b8f1', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '6f419860-3551-4454-93e2-eb7007618e86');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('36ab2ea0-0731-4ff4-8058-520c8f32c0ce', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '9f1e2186-b9df-4631-bde6-6ab8f0b2f17e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('da8214b3-73c5-4efe-9958-7edeb74a5ee0', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '9f1e2186-b9df-4631-bde6-6ab8f0b2f17e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('86f460bf-4c24-44db-b272-d1487186843b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '9f1e2186-b9df-4631-bde6-6ab8f0b2f17e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fa720396-3a32-426b-bcea-39f82e80811d', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '9f1e2186-b9df-4631-bde6-6ab8f0b2f17e');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a1740003-3efa-4029-8001-26645070bbd0', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'dad8ca0c-690a-4aa8-b9b1-27726cf18f24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('56681fb1-e613-4d65-838e-221caae732b5', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'dad8ca0c-690a-4aa8-b9b1-27726cf18f24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a48d005e-6359-4066-b119-52c6d89de809', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'dad8ca0c-690a-4aa8-b9b1-27726cf18f24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ccd27f91-ec7b-41a9-93fb-7daf17ee0e31', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'dad8ca0c-690a-4aa8-b9b1-27726cf18f24');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5d94cdd2-e35d-42bb-8a03-8329d46e0ec5', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'd41590cd-00c2-4756-912b-aeb84b8f036f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('cbe120f0-8b3b-41dc-8c43-50cd144d2b26', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'd41590cd-00c2-4756-912b-aeb84b8f036f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('acf63cfd-9d6a-4167-a48b-dacc29c51f28', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'd41590cd-00c2-4756-912b-aeb84b8f036f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fde7c543-5cf1-4c16-ab7e-0ea5ea883742', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'd41590cd-00c2-4756-912b-aeb84b8f036f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('528fa0ae-ee22-4bb0-9352-45454c1c4297', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '545439ed-70d2-4580-8d92-7fac5eee4b5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1840d725-e542-488d-ba53-516f20a633a1', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '545439ed-70d2-4580-8d92-7fac5eee4b5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b64aebd4-9f87-421d-8262-a8b7b6bcf263', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '545439ed-70d2-4580-8d92-7fac5eee4b5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e9458192-11af-4066-99d7-5ca50d79f6e9', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '545439ed-70d2-4580-8d92-7fac5eee4b5b');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e3ad840b-ef5c-4782-94d9-b06faf00c856', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '2ab269cb-00fb-41fd-9721-b7406894f357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2a3c81a0-a3b8-4830-9247-66383331f2f4', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '2ab269cb-00fb-41fd-9721-b7406894f357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('da4a22ee-1048-40b5-b786-5592ee1e0783', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '2ab269cb-00fb-41fd-9721-b7406894f357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ceb2a9de-ac29-4356-891d-48c8c5e1e20e', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '2ab269cb-00fb-41fd-9721-b7406894f357');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a56c35ad-08f9-43c4-89cd-5c772a18b646', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'b41ffb22-5f4e-4f5d-9fda-223af215c936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d5b460ad-f310-4814-a482-04b97d2757a4', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'b41ffb22-5f4e-4f5d-9fda-223af215c936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4a709be6-a799-44f6-8064-f1b7ec65af48', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'b41ffb22-5f4e-4f5d-9fda-223af215c936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fb8512fa-d24c-43da-b546-d0d585e6f708', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'b41ffb22-5f4e-4f5d-9fda-223af215c936');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b09430ca-eb01-4ea7-95d7-5c94961fdbb2', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '533be73a-cc8d-4159-89d6-3eaa0a39fb7a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('190fee00-db37-4827-be21-1b81b10c27af', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '533be73a-cc8d-4159-89d6-3eaa0a39fb7a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ab5dcbab-7d14-4829-987d-0e7f1dd07854', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '533be73a-cc8d-4159-89d6-3eaa0a39fb7a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d8a54574-de91-4854-86aa-e84686338df6', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '533be73a-cc8d-4159-89d6-3eaa0a39fb7a');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b1af38d0-619d-465c-b8f8-2d79df8f4242', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/CrossBow', '2025-05-09 10:44:56.198218-05:00', 'CrossBow', 'bebea877-db0a-45da-b126-fae30bdcf034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a7f08690-289a-4b90-b3ac-b2498fa853ae', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Tenno/Pistol/CrossBow', '2025-05-09 10:44:56.198218-05:00', 'CrossBow', 'bebea877-db0a-45da-b126-fae30bdcf034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9748c503-e990-4033-8a3b-6f732da29ef7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'bebea877-db0a-45da-b126-fae30bdcf034');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('42db7582-724d-4d70-ab14-ceedca388edb', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '7ee3fa22-d976-4b2f-9b20-1ab7bcb0fad9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d73cfe9d-fdec-4d76-86f2-4708f05c4be3', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '7ee3fa22-d976-4b2f-9b20-1ab7bcb0fad9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7e559c49-6662-431d-9d1e-133128273291', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '7ee3fa22-d976-4b2f-9b20-1ab7bcb0fad9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a9c4cdd8-5393-4e3d-971d-cf5516fcf080', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '7ee3fa22-d976-4b2f-9b20-1ab7bcb0fad9');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('033d8e20-cc3e-4fde-9f75-0acfd1acade7', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'eebeaafe-62bc-4568-873b-dd41e838c92c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8821a8d4-0305-48aa-a332-5a9546589690', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'eebeaafe-62bc-4568-873b-dd41e838c92c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('155f6205-c3d6-48d2-a5ae-36bc61ca7358', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'eebeaafe-62bc-4568-873b-dd41e838c92c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('03807e12-f07b-4fb7-9e0b-7f9a7b9f111e', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'eebeaafe-62bc-4568-873b-dd41e838c92c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('327ab608-2247-4770-a454-34dc19910649', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'b38d441e-0e68-4c39-9d72-fd2e96ea1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('70428839-d878-4343-9451-70e1a8801d30', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'b38d441e-0e68-4c39-9d72-fd2e96ea1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c403f71e-1187-42dc-aa18-d57d6b6304ed', '2025-05-09 10:44:56.198218-05:00', 850, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'b38d441e-0e68-4c39-9d72-fd2e96ea1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2445501b-eb9e-4753-8dd5-1a57be855493', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'b38d441e-0e68-4c39-9d72-fd2e96ea1922');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fc398cee-8c95-40c0-a352-43554a167c0a', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '49f91a40-ab15-4a4c-9424-c18ac225a5e1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3511e609-f5ea-4c7c-bb75-9f3e4f06b7a5', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '49f91a40-ab15-4a4c-9424-c18ac225a5e1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('389df448-4ec7-40ab-99a3-63cd11cd8728', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '49f91a40-ab15-4a4c-9424-c18ac225a5e1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('84fe3273-77cd-4d3b-92b3-fcd5e094cecf', '2025-05-09 10:44:56.198218-05:00', 120, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '49f91a40-ab15-4a4c-9424-c18ac225a5e1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b0500140-ef6f-409f-9788-4bcb6b61c066', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'e52ae0c2-01ab-4e97-b6a8-5649e69aa6e3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('73f3f0b1-6b72-412d-81d6-58e60d233b37', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'e52ae0c2-01ab-4e97-b6a8-5649e69aa6e3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85bfd63c-d97a-4622-a642-3c14a84f2dc2', '2025-05-09 10:44:56.198218-05:00', 250, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'e52ae0c2-01ab-4e97-b6a8-5649e69aa6e3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ab7aee4d-c818-4c69-9aef-282c6f7cbd1d', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'e52ae0c2-01ab-4e97-b6a8-5649e69aa6e3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('30926e11-8de7-4e73-88ff-60326b2bdbdc', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'd5c4bb0a-33e8-4c18-b0e7-f1af815fb366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9b5c5a5c-7d7f-457d-ade5-f92286c9e42a', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'd5c4bb0a-33e8-4c18-b0e7-f1af815fb366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4fb35bd2-4a5a-4259-865b-a10e0e9f8c5e', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'd5c4bb0a-33e8-4c18-b0e7-f1af815fb366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24d149b6-6574-476c-8ad6-f065e2ebf0ea', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', 'd5c4bb0a-33e8-4c18-b0e7-f1af815fb366');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a3dac9b8-b63a-4911-a0b8-7f881539bea7', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '66dfca4d-01fb-4e40-9d8d-c4b4637af70d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1c181b06-af72-4f81-8c57-f1cb8773859f', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '66dfca4d-01fb-4e40-9d8d-c4b4637af70d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8c214b34-abd1-4973-a490-972a182b72e7', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '66dfca4d-01fb-4e40-9d8d-c4b4637af70d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8b41c7f3-f487-4a75-81d5-370f1867ed04', '2025-05-09 10:44:56.198218-05:00', 1250, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '66dfca4d-01fb-4e40-9d8d-c4b4637af70d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d1789644-841b-4072-8389-3666fd2f9b7d', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '113a1afb-4cac-40aa-826e-3f0ad6a434ca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('57f622ea-f885-4a44-9c5c-08709a2bf700', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '113a1afb-4cac-40aa-826e-3f0ad6a434ca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5b9bfa28-5465-4bd7-8fc2-7fae16b8fc38', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '113a1afb-4cac-40aa-826e-3f0ad6a434ca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fadf82c3-83f6-44b8-ad90-281ef95046b7', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '113a1afb-4cac-40aa-826e-3f0ad6a434ca');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4dc5ecdb-37c0-4363-9bd1-1db40e78e6e0', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynHelmetComponent', 'ba3e23b6-0585-49ba-9ec0-0000aca158d1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85a6ae85-87f6-4b8d-a1fb-cbe60703edc2', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynChassisComponent', 'ba3e23b6-0585-49ba-9ec0-0000aca158d1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fa1624bc-1b90-43bc-a702-e3d2f7fc7bc4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'SarynSystemsComponent', 'ba3e23b6-0585-49ba-9ec0-0000aca158d1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('69f2fbd4-91a4-47b2-b2b4-24f05ba97f4b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'ba3e23b6-0585-49ba-9ec0-0000aca158d1');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3ae4a100-d310-43d6-ae99-a1643b829237', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '082a704b-1300-48b5-a9b6-b56c0e8bd76f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4e72823d-1cee-49b0-a768-fcc78c290ace', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '082a704b-1300-48b5-a9b6-b56c0e8bd76f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7c48c5a3-5358-4a2d-8675-e2906074a935', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '082a704b-1300-48b5-a9b6-b56c0e8bd76f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f63b27a6-4e1e-4a83-8c90-edf33ca1ad45', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '709f4f55-00c8-4a40-af8e-3abd6fa5d7fd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2176e069-8fed-42d5-9913-2f679c9d2ec3', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '709f4f55-00c8-4a40-af8e-3abd6fa5d7fd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('90e9b00b-52be-49a5-abc4-795fcf0acd19', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '709f4f55-00c8-4a40-af8e-3abd6fa5d7fd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8f856136-e810-4c74-b675-e2a22865f8a6', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '709f4f55-00c8-4a40-af8e-3abd6fa5d7fd');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9df1b4cc-1984-4d66-a2a9-0f9839e72166', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '499f2a6d-4bf2-43fb-b097-0b3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a9ae36df-bc1f-4e77-9fc8-2769e815df35', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '499f2a6d-4bf2-43fb-b097-0b3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('dcc644d0-b26b-4578-ac28-a9e02d80a623', '2025-05-09 10:44:56.198218-05:00', 550, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '499f2a6d-4bf2-43fb-b097-0b3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('551fa1a0-5801-408e-bbb9-27dd2e54569d', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', '499f2a6d-4bf2-43fb-b097-0b3847330479');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4e7b018f-6d91-4a5a-8c86-ff3738fa8a81', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeHelmetComponent', '1adf0512-a41d-49a1-9e76-f5909b8ee540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1c9d9619-1c86-4a8b-a687-679669716c2c', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeChassisComponent', '1adf0512-a41d-49a1-9e76-f5909b8ee540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f6f9c83b-ac21-47be-bc4b-91ce1caabb91', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'BansheeSystemsComponent', '1adf0512-a41d-49a1-9e76-f5909b8ee540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a6200730-45f0-48cf-8810-90397e0c123b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '1adf0512-a41d-49a1-9e76-f5909b8ee540');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9b80ec5f-6ec9-46df-b47c-1418dfc7ccef', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '6520405a-b438-482f-b6dc-63cffa463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a2e89807-0677-4375-bc7f-4f64f6bf5291', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '6520405a-b438-482f-b6dc-63cffa463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7a6689f1-4e7e-42fc-88ed-e35f63f47fcf', '2025-05-09 10:44:56.198218-05:00', 50, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '6520405a-b438-482f-b6dc-63cffa463510');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('47b22210-621f-4c32-b627-dfb46a15246a', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '230224f6-d67c-46f5-a5fe-f033ae040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('95237f13-925a-410c-b9ad-c9a1c5ba9fef', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '230224f6-d67c-46f5-a5fe-f033ae040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('57d6410c-b264-4c99-9f9b-7051e4fd524a', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '230224f6-d67c-46f5-a5fe-f033ae040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c099b685-dee3-468f-85c9-b1c8657857fd', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '230224f6-d67c-46f5-a5fe-f033ae040564');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1fe267f6-52f4-4945-9cce-28f49dc3e06f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', 'd160892d-1dfb-4311-b95e-d9290173a1b6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b0106370-eae6-4746-b6c3-0078c83dec4b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'd160892d-1dfb-4311-b95e-d9290173a1b6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24968079-fa66-4467-be67-fa0bb05cf13c', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'd160892d-1dfb-4311-b95e-d9290173a1b6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c5775881-3366-4006-b2e0-d4f0f0d3dbbd', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'd160892d-1dfb-4311-b95e-d9290173a1b6');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17d87551-6e34-45ea-8c88-507076aade1b', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '912a7afe-3117-4814-9374-777fc90c0fa8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17a150da-4d64-472c-9d45-dbcb388c8908', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '912a7afe-3117-4814-9374-777fc90c0fa8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('75d63de8-471b-4991-849d-215ae4db6797', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '912a7afe-3117-4814-9374-777fc90c0fa8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('03ad6903-27f5-4962-b54b-b826739a49dd', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '912a7afe-3117-4814-9374-777fc90c0fa8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0c1c93bd-2c11-4fc0-a00e-879e8d2b3e3f', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '42eb5a8b-1699-46bd-9c45-e73c6c84ed6f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('ae22fa4c-2419-4d2a-92fb-4e240dbffde6', '2025-05-09 10:44:56.198218-05:00', 400, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '42eb5a8b-1699-46bd-9c45-e73c6c84ed6f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bcf44eae-95d0-4b26-8f82-44ce671edff4', '2025-05-09 10:44:56.198218-05:00', 200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '42eb5a8b-1699-46bd-9c45-e73c6c84ed6f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('54cde7c2-113e-422b-a886-6241cf751a02', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', '42eb5a8b-1699-46bd-9c45-e73c6c84ed6f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2500fef1-de59-4ba3-a5d2-c211af40b2b8', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '16efb209-e206-4690-bc0a-a95c3d8bafa3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4abadae1-159d-4965-8e01-22b94302776c', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/Circuits', '2025-05-09 10:44:56.198218-05:00', 'Circuits', '16efb209-e206-4690-bc0a-a95c3d8bafa3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9a251bfe-f4cc-4f12-8fbb-919d736722e2', '2025-05-09 10:44:56.198218-05:00', 550, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', '16efb209-e206-4690-bc0a-a95c3d8bafa3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('eec08beb-da0c-4b9f-a703-5cdf66364ff4', '2025-05-09 10:44:56.198218-05:00', 1200, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '16efb209-e206-4690-bc0a-a95c3d8bafa3');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a2159f76-8885-41e6-ae25-95ce83ef9fc4', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'c525cc08-f3cf-4b27-9290-ffa3ac0c5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('496fa55b-2a7a-444d-a728-086bc0a5b26f', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'c525cc08-f3cf-4b27-9290-ffa3ac0c5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('435dc3d0-18d5-47d2-9e75-6399bb7dde72', '2025-05-09 10:44:56.198218-05:00', 650, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'c525cc08-f3cf-4b27-9290-ffa3ac0c5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('cb5cd817-f0f9-4137-aa34-c56f42316f27', '2025-05-09 10:44:56.198218-05:00', 750, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'c525cc08-f3cf-4b27-9290-ffa3ac0c5488');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('4922a908-9043-4c3e-b486-a09d7da7bbf3', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', '747d6146-8b34-4aae-ad7e-b6643bdc4be7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9bd6c9df-4a15-4694-855a-41f2c4a1338d', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '747d6146-8b34-4aae-ad7e-b6643bdc4be7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3c1a949c-9959-47f9-ac37-252761f987db', '2025-05-09 10:44:56.198218-05:00', 250, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '747d6146-8b34-4aae-ad7e-b6643bdc4be7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2cbb05cd-76b4-4a50-91d1-cc3b86cb9348', '2025-05-09 10:44:56.198218-05:00', 60, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '747d6146-8b34-4aae-ad7e-b6643bdc4be7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5490e8a0-5f51-4d3d-9e4e-60f5dcb75c83', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '61f4ad96-f5a2-4592-b3fb-98ae30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0055cfb9-5d12-4cea-8a90-7f7ddf0f6107', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '61f4ad96-f5a2-4592-b3fb-98ae30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('17da1411-67d4-4f79-9eff-6c70b496dc88', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '61f4ad96-f5a2-4592-b3fb-98ae30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bfef3498-fc7d-45d9-b19d-3aed692e6be5', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', '61f4ad96-f5a2-4592-b3fb-98ae30343337');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('af80788d-324e-4f4f-943b-4a759fa8bc93', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'd4fbb92e-2e0b-480b-95df-0c6017e652ba');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e5fbfcf9-548f-4657-8d70-cadebd9ff9c0', '2025-05-09 10:44:56.198218-05:00', 350, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'd4fbb92e-2e0b-480b-95df-0c6017e652ba');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6f1e7e56-9180-4edc-adfd-2080b528ec1b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', 'd4fbb92e-2e0b-480b-95df-0c6017e652ba');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1cc43a6e-8a1a-4fd1-9822-9fbbca97f56c', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'd4fbb92e-2e0b-480b-95df-0c6017e652ba');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('df86f244-5076-421d-b3d1-f0451f5e216d', '2025-05-09 10:44:56.198218-05:00', 3, '/Lotus/Types/Items/MiscItems/Gallium', '2025-05-09 10:44:56.198218-05:00', 'Gallium', 'c911bc4e-7696-44a2-9bb0-79c98d47073c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('a2bce2f1-60f6-4287-9845-53503a71e1c9', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'c911bc4e-7696-44a2-9bb0-79c98d47073c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('96bd833e-a563-4291-814b-e209a96ebab2', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'c911bc4e-7696-44a2-9bb0-79c98d47073c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e7aceb18-fe5f-4d12-89ab-aff9529a31ba', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'c911bc4e-7696-44a2-9bb0-79c98d47073c');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f8f67094-0de4-44dd-966d-b8ba80170e28', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', '6500674a-0083-4a4a-8220-5ba94483c3b7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2750081e-c545-46f9-a21e-5843bd347573', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '6500674a-0083-4a4a-8220-5ba94483c3b7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('45fa2f0f-5249-4785-b4be-1ad32094e888', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '6500674a-0083-4a4a-8220-5ba94483c3b7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8f5feab8-f637-41ff-98d0-2100a3270ec7', '2025-05-09 10:44:56.198218-05:00', 75, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '6500674a-0083-4a4a-8220-5ba94483c3b7');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('967dec3e-a880-48a0-b257-d5efc143187f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', '2025-05-09 10:44:56.198218-05:00', 'GrineerLightPistol', '75c39eaf-fb46-4a55-aedd-9806516325e8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('f61dc2b1-6143-4da3-8c48-e5a668c06ac5', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', '2025-05-09 10:44:56.198218-05:00', 'GrineerLightPistol', '75c39eaf-fb46-4a55-aedd-9806516325e8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('bf7e0a14-fec9-4d91-b4b5-534b308a7d43', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '75c39eaf-fb46-4a55-aedd-9806516325e8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('83c2036d-4ce3-4cf4-b7fa-13bad01cf15b', '2025-05-09 10:44:56.198218-05:00', 5, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'f687e946-5f7b-4e17-ace6-965b8f7916e5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('6cbfa592-46e3-4baa-b5e8-a66b49684159', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'f687e946-5f7b-4e17-ace6-965b8f7916e5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('0c333ce6-937b-43cf-be66-d4e3ac2b74f7', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'f687e946-5f7b-4e17-ace6-965b8f7916e5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d38dc6cb-652c-40c2-adcf-52c5132fad41', '2025-05-09 10:44:56.198218-05:00', 1200, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', 'f687e946-5f7b-4e17-ace6-965b8f7916e5');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('3e371fef-0a8e-4204-a4e2-81a787e9d06d', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'cfd6dbef-cec1-4f1e-a84a-ea6ca87356d8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c86343ab-8532-45b8-b541-4dada9bda20d', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'cfd6dbef-cec1-4f1e-a84a-ea6ca87356d8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('8a4b3c38-9eb8-4711-9ee8-053609dc7f7d', '2025-05-09 10:44:56.198218-05:00', 850, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', 'cfd6dbef-cec1-4f1e-a84a-ea6ca87356d8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('cee41b29-31e3-40f4-a8f4-0ac77e345590', '2025-05-09 10:44:56.198218-05:00', 80, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'cfd6dbef-cec1-4f1e-a84a-ea6ca87356d8');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1b5b583a-494e-4dbb-805b-2f0147fa0105', '2025-05-09 10:44:56.198218-05:00', 10, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '1c479545-a926-4e12-919d-e438e138df27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('590ff71b-03ba-4c73-85b9-aa64073a6368', '2025-05-09 10:44:56.198218-05:00', 5000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '1c479545-a926-4e12-919d-e438e138df27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b39592fd-09db-4ee3-b105-3676be68422e', '2025-05-09 10:44:56.198218-05:00', 6000, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '1c479545-a926-4e12-919d-e438e138df27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b08fc354-47de-4aad-b8fa-eb59e56696c8', '2025-05-09 10:44:56.198218-05:00', 4500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '1c479545-a926-4e12-919d-e438e138df27');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('dbc84751-7809-41ae-a7ff-cdfe95fa376d', '2025-05-09 10:44:56.198218-05:00', 700, '/Lotus/Types/Items/MiscItems/Nanospores', '2025-05-09 10:44:56.198218-05:00', 'Nanospores', '19f771e1-180a-4b9b-aad7-76f4d12a471d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('23cb944a-a401-4eac-a869-44fb9d653a46', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', '19f771e1-180a-4b9b-aad7-76f4d12a471d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('50880cec-bb16-4bb6-b7d6-617dd949b477', '2025-05-09 10:44:56.198218-05:00', 600, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '19f771e1-180a-4b9b-aad7-76f4d12a471d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('89205bda-cc8d-488c-a595-1068b8834b53', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', '19f771e1-180a-4b9b-aad7-76f4d12a471d');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('b606445d-6964-4e18-8ec5-83224ff4ecba', '2025-05-09 10:44:56.198218-05:00', 2, '/Lotus/Types/Items/MiscItems/Neurode', '2025-05-09 10:44:56.198218-05:00', 'Neurode', 'a7ab4f31-df77-42cf-9cbb-879df9555acf');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d3134d89-c46f-4674-8760-ac2b2c9ae861', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'a7ab4f31-df77-42cf-9cbb-879df9555acf');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('e7a2734c-fe76-4894-910a-b8fef8b9eb1d', '2025-05-09 10:44:56.198218-05:00', 900, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'a7ab4f31-df77-42cf-9cbb-879df9555acf');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('16ba12b0-17d1-4993-b15d-08a63dea9762', '2025-05-09 10:44:56.198218-05:00', 100, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'a7ab4f31-df77-42cf-9cbb-879df9555acf');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('7d3c2037-28a5-4d07-89b0-96de85194283', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeHelmetComponent', '896ba6e7-cd0e-4258-a275-77814cf9491f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9e49c429-f44a-47ec-8bb6-605f635d2a3b', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeChassisComponent', '896ba6e7-cd0e-4258-a275-77814cf9491f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('d5a8203a-7c8f-4864-85fb-88bab0540b25', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', '2025-05-09 10:44:56.198218-05:00', 'FrostPrimeSystemsComponent', '896ba6e7-cd0e-4258-a275-77814cf9491f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('81c33cbc-32ad-458d-b074-1ea6efda575f', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/OrokinCell', '2025-05-09 10:44:56.198218-05:00', 'OrokinCell', '896ba6e7-cd0e-4258-a275-77814cf9491f');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('9590127d-d04a-4781-a55a-fdd08b4482dc', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', '04aa47dc-ac0c-466e-a5c5-e305e3cd0e16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('85fdab25-5511-41cf-933c-43e1c9682013', '2025-05-09 10:44:56.198218-05:00', 1000, '/Lotus/Types/Items/MiscItems/Ferrite', '2025-05-09 10:44:56.198218-05:00', 'Ferrite', '04aa47dc-ac0c-466e-a5c5-e305e3cd0e16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('5d4a061b-b5bb-4a8e-ba1f-f1e6a8ab4f51', '2025-05-09 10:44:56.198218-05:00', 300, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', '04aa47dc-ac0c-466e-a5c5-e305e3cd0e16');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('c10f8b59-7b55-4c36-8a36-381e3c78970e', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/AlloyPlate', '2025-05-09 10:44:56.198218-05:00', 'AlloyPlate', 'ae8bd670-7014-466e-98ea-5f46c0a48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1efb0e8f-da92-4d5f-9900-2d918a734029', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/NeuralSensor', '2025-05-09 10:44:56.198218-05:00', 'NeuralSensor', 'ae8bd670-7014-466e-98ea-5f46c0a48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('de4f3f64-e377-4d5e-be99-e062f9b15a2a', '2025-05-09 10:44:56.198218-05:00', 150, '/Lotus/Types/Items/MiscItems/PolymerBundle', '2025-05-09 10:44:56.198218-05:00', 'PolymerBundle', 'ae8bd670-7014-466e-98ea-5f46c0a48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fa06bdd8-f79b-4d2e-9a73-3868387a520b', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Rubedo', '2025-05-09 10:44:56.198218-05:00', 'Rubedo', 'ae8bd670-7014-466e-98ea-5f46c0a48498');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('1764e083-37e8-4efc-9ed2-cc3ac8e413e6', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/ControlModule', '2025-05-09 10:44:56.198218-05:00', 'ControlModule', 'e428899b-6130-4313-baf6-78ea5cbf7bea');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('24ec7dca-559c-4d8a-ad80-429efdbe8d40', '2025-05-09 10:44:56.198218-05:00', 1, '/Lotus/Types/Items/MiscItems/Morphic', '2025-05-09 10:44:56.198218-05:00', 'Morphic', 'e428899b-6130-4313-baf6-78ea5cbf7bea');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('2aee1a60-7352-4b54-8bed-7f39145796dd', '2025-05-09 10:44:56.198218-05:00', 500, '/Lotus/Types/Items/MiscItems/Salvage', '2025-05-09 10:44:56.198218-05:00', 'Salvage', 'e428899b-6130-4313-baf6-78ea5cbf7bea');
INSERT INTO RecipeItems
(Id, CreationTimestamp, ItemCountNeeded, ItemName, LastModificationTimestamp, PrettyName, RecipeId)
VALUES('fc683fdd-bbba-41c6-a41c-aca82a9f5475', '2025-05-09 10:44:56.198218-05:00', 220, '/Lotus/Types/Items/MiscItems/Plastids', '2025-05-09 10:44:56.198218-05:00', 'Plastids', 'e428899b-6130-4313-baf6-78ea5cbf7bea');
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

");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
