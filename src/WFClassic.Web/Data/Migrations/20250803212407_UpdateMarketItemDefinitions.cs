using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMarketItemDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
delete from MarketPackageDefinitions where 1=1;
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D490331C-7A03-47EC-903E-FBF7143226D5', '/Lotus/Types/Restoratives/Cipher', 1, 250, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Restoratives/Cipher');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/Ninja', 1, 0, 375, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Ninja/Ninja');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/Banshee', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Banshee/Banshee');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/Ember', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Ember/Ember');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/ExcaliburPrime', 1, 0, 10000000, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Excalibur/ExcaliburPrime');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/Excalibur', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Excalibur/Excalibur');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/FrostPrime', 1, 0, 375, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Frost/FrostPrime');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/Frost', 1, 0, 375, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Frost/Frost');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/Jade', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Jade/Jade');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/Loki', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Loki/Loki');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/Mag', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Mag/Mag');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/Rhino', 1, 0, 375, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Rhino/Rhino');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/Saryn', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Saryn/Saryn');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Trapper/Trapper', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Trapper/Trapper');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/Trinity', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Trinity/Trinity');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/Volt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Powersuits/Volt/Volt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('E0ABE029-14A3-4AF8-BC97-A625B8240697', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7DD15D12-040D-4765-87FB-6DF87EA672D3', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('0C503A5A-AA6C-4629-BF78-321C7F024240', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('DB1C72F8-0B08-4C73-ACEB-86997B63E43D', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('CB9E333D-E02D-4418-9B2D-85856FF9EBBB', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('425627BC-AAA0-4292-AEFC-7DCF875A554E', '/Lotus/Types/Recipes/DarkSwordBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/DarkSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('05A846D6-B7D6-4435-94BA-B04D96BD42A2', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('483FABF2-F6D5-4890-B3C0-6E51B15352FA', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('55AA9DBD-729E-4F32-B877-6F747D69D21E', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('8B157839-DAFF-44E1-925A-FEDEB2AF2F49', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('663AC222-62FC-4AC8-9A03-6908F32CC729', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3A8A2BF0-C3E2-4E8B-9B68-251577C93084', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7234398A-BBDF-4BE7-94EF-3F8F958AF85D', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('934B48B6-4724-44E0-835C-7086E086A2FF', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B655AFB8-8C04-46D9-89DB-90EDCDD80C32', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F91AC16A-7B9E-44FB-AEC7-FCB9296E1C05', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6B8E4D3E-9F9C-4584-BCE6-914B894BC35F', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('1C3D0FBF-C546-47B5-B310-6F958778E8E3', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('35A81525-AA10-4FE4-AC73-788659D19D26', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('90195144-D477-4FAC-919A-9ECFD3D07CA4', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('71731531-5836-4EE9-87E0-6BE98C4DFE29', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('26983D37-7CCB-4FFC-AC55-2F2C726D7380', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('FCAFCE6D-00B4-4A02-BEC0-D79242E6FD97', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/JawBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('41A7508F-FC0D-4A08-8544-0AB6D2501D10', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('98E9EE12-1ADB-4022-AC15-8DCC99099CB8', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C45ACCCB-2FB1-453E-8BB1-C404F0762C68', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('8737A90B-EE4D-4A87-A97F-AF5FA4A32B7D', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('74CC0E19-1199-4AEC-BA9D-31FF78D08E9A', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D1B85F28-3E0B-4804-932B-162270B592E1', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 1, 0, 20, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Items/MiscItems/OrokinCatalyst');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6933A9A1-58BE-40F5-A4B1-903D0B7593EE', '/Lotus/Types/Items/MiscItems/OrokinReactor', 1, 0, 20, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Items/MiscItems/OrokinReactor');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('87B7C2C0-1B97-4B6B-AF3B-ADAD4C3A2182', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('ACD843B8-9317-4BBA-B63E-828DE1451553', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('900A5615-092A-4541-8DEB-006AA592F6D5', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('9E0CFA1D-17EB-4926-83B1-FCB6F89AB781', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F222EE33-4500-4E0C-9026-BD3403FDC445', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6508A4E9-3814-4A0C-9D8C-901BCE8FDBF3', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 1, 0, 0, 0, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2BA29F31-41A0-4C53-9B15-8A95F82CD8AA', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Axe/DaggerAxe');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A2F3D60F-99F6-45C1-8E84-C84A7F8F4553', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('0BBF61DC-52E1-4022-AB9D-227AD16AC2B0', '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail', 1, 0, 15, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B9338A79-75AA-4AF1-85FD-FC95BF8D1700', '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings', 1, 0, 15, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('95E000F0-205D-47A8-BBB1-E01049D22E60', '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings', 1, 0, 20, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2BE17D46-B2FB-4C37-8112-A2383EB8EA2A', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D2D9DC6F-5529-4A6B-87D9-5CE55DF08675', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F828D697-A3A1-492F-B4CF-13A11FCA874F', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D4047180-5EBF-47CA-AAFA-5D853671CB03', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A14A5413-05C9-466A-BE1D-4CA7634D7A76', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C9D5E84A-ECEC-4583-BF8E-9B8323F75A0A', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Hammer/GrnHammer');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C6330998-6086-4887-B4B5-E980C2265B4A', '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask', 1, 0, 15, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2DC9F3F4-E2DC-4FDC-AF23-569905263B16', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7670A272-4B30-4EC3-81A2-1D4EA655EAAB', '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask', 1, 0, 20, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('83F3B955-A1D1-4139-BF6C-3A5D2D6A4CA9', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5EA0B0A4-6D29-466C-A5D7-723AB88162A2', '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask', 1, 0, 30, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2C57AE87-7FA0-4860-BE31-79D5C077CEBD', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('00D25FCF-2BC3-4468-A2D3-580DB5BF3C86', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('CD91356C-2B38-4AE4-AE2E-99DCB1F19F10', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3B80BB4F-B63A-4CBD-A1E9-E23FC3EDED5A', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('183F66D6-0980-4637-8AD4-B13D4BD92C1C', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('62A51CC2-EE3B-4488-BA02-122AEC8C2718', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('61E2389F-C0CD-4332-A30D-B91D8E99FFC0', 'ColourPickerItem', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'ColourPickerItem');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C078E750-5612-4792-8811-E61EC1B28A85', 'ColourPickerItemB', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'ColourPickerItemB');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2803120B-14F9-4265-97C3-4047440B5332', 'ColourPickerItemC', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'ColourPickerItemC');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9', 'ColourPickerFireItemA', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'ColourPickerFireItemA');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('16B2D787-17D3-439D-B5C9-9CD774570B94', 'ColourPickerIceItemA', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'ColourPickerIceItemA');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('ADC5F7AA-947E-4DE4-860F-C91BC511BFB3', 'NinjaColourPickerItem', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 'NinjaColourPickerItem');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5023F862-F2E1-4D7F-ADA6-63E2C2294F62', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3AB49431-CC00-4B76-AFC4-0E04401A6498', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('4DCCACCC-89B3-4D19-9745-0622E5FF5489', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5FC5E3C1-B7F6-461A-A60D-D0621375C77C', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('28BE0F34-341A-4B90-976B-AFA5A4297362', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 1, 12000, 75, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('FA83A1D9-7FD5-4123-B58E-945A5BDA488B', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('DB0383C0-B105-41F4-9233-FF0BEAE304DA', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 1, 15000, 120, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/AutoPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('83D094C4-0D9F-4AB1-B2C4-6664AF557725', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/AxeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F93DEF90-2CB6-4CB1-A240-CF76A98FD2DE', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('446D27A7-BC61-4CF9-AC0D-E94BB270C7CC', '/Lotus/Weapons/Tenno/Beam/BeamWeapon', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Beam/BeamWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C3523855-A5C7-4D5F-85EF-193B252E286C', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('969A3677-EBE2-4FC2-99EC-C62A05CFBDB5', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B454090F-22C5-4B67-813C-BD25A40B31D0', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('EC7CBAEE-DA55-4554-81A3-FB8A051C7246', '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('211E136C-41AA-492A-9596-66F6DEDA95A7', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 1, 12000, 120, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/BurstPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('24C2E164-49F8-4EF7-BA00-4433608ED47C', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 1, 12000, 120, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/BurstRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6045B75E-2EFE-4514-A69C-271B29FF5736', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 1, 15000, 150, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C3CAB743-C4B8-4613-A909-497E2B7608A1', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('82419219-7214-4531-986A-422F164E07B8', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/CrossBow');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D7B34ADF-30B6-4045-8ACC-076C35A9035B', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D05A3B66-D044-42CA-98B7-0B0AE883481E', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 1, 15000, 150, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C746BD6D-7A78-42B8-A624-F719255097FD', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 1, 4000, 100, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A6F7B83A-C512-415D-8C91-C4FAF910A398', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C547BD95-B70E-4105-9AF2-280922085777', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('0CCCB485-E91A-4ED2-893E-539838CF67C2', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('9FFA3AFE-451C-4569-AF34-6C8D73E30463', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 1, 0, 135, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C0C008CA-3D2C-4336-8E27-BFEFF6E2E384', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2811AD60-0885-4409-9DB6-A82E22D8D3F3', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('59D11652-4406-4810-A6AD-78C7E642E685', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6258DB7A-2D19-4556-872A-990C164517C6', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5378E489-14C2-41D3-954C-40FAF81CDC86', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 1, 0, 175, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('9A260C26-C169-4966-8BC4-2822CDE7C113', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 1, 45000, 125, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7AB61A0F-CA2F-48FC-8759-97C0264927C0', '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword', 1, 4000, 100, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('4356B60B-AB8F-458B-95C2-E035C08E4924', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 1, 30000, 125, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Fist/Fist');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3E985677-1CCD-4DA0-9986-504359CEE4F9', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 1, 50000, 225, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('233FE1AA-EA41-4B17-A1C5-5B20CB442D7C', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('765A240F-67CE-4EBD-9FCA-AA5B4AF3ED5B', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 1, 0, 125, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('D131820F-EF5E-4705-8E6A-60F3D0344047', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C25B76F3-09AD-49AB-940E-6015EC8FEBFC', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 1, 0, 75, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('8630426E-ED49-4B6C-B562-52B1A92B9D82', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('308436FF-6B56-4D53-BEE0-C91BD8DD7B44', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 1, 0, 125, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('E5216354-82EA-4B65-902C-9D1AA6B2DE67', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 1, 0, 120, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C4EAEB74-DE1F-454F-A44B-683D1E6D630C', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('EA4EC6AF-D0D4-4304-B841-753A6A36E5ED', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/HammerBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('4FC210B0-E000-42BA-BBE6-FB60226B8602', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2ECA4F5D-94D3-49C1-876C-6691C0B881DC', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 1, 35000, 190, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/HandShotGun');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5DC92261-55E2-44DE-ABC1-195CA930AE0C', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 1, 0, 100, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('E814421F-2513-4A48-91B3-641181E54BA2', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 1, 35000, 190, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('BBBEA529-6034-4583-80F4-A0AEAAF7CBBE', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 1, 50000, 225, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B0445840-A84A-4FFA-A552-5CE79FD5C9B5', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Bows/HuntingBow');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('5C49F1C0-AA8E-44E7-B232-F7BFFAC9A136', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('476D1BF1-165C-49D8-AF29-FF92722DAEA4', '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai', 1, 4000, 250, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('13BFBC0A-6448-4BAC-8D94-F0687FC28D35', '/Lotus/Weapons/Tenno/Pistol/LatoPrime', 1, 0, 10000000, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/LatoPrime');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('22024336-F7A9-4585-B505-C2FC33BF9C73', '/Lotus/Weapons/Tenno/Pistol/LatoVandal', 1, 1, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/LatoVandal');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('763E914E-6911-4358-9106-C926CD8FEFD5', '/Lotus/Weapons/Tenno/Rifle/LatronPrime', 1, 0, 10000000, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/LatronPrime');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('2A4B76A8-2875-4452-9A88-F55C598CCDD6', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A7C4CD29-E091-4D1C-95E1-D47FAD799F3A', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 1, 15000, 150, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('29104D79-418F-400D-BB4F-FE0B9585D473', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 1, 0, 150, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('95020669-D82F-45B3-AA6D-D37582BBFA8A', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('F317007A-A395-4DDE-B4F6-8F5602AECA2B', '/Lotus/Weapons/Tenno/Pistol/Pistol', 1, 4000, 50, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Pistol/Pistol');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A0050D8A-E690-4BC7-9800-A5E6C6F442F2', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 1, 20000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7C9EF2E8-AD2E-43C3-ACAA-40DA5868B402', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C62959DE-F670-4A6E-9E90-FF7F8D1747AB', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('6735E281-AF57-4DC2-9788-C42C128612B4', '/Lotus/Weapons/Tenno/Rifle/Rifle', 1, 10000, 75, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/Rifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('33EBC6DC-7DB2-46C8-A66E-F0134E9ADA87', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 1, 50000, 225, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('35215FC7-1AB0-47BC-9F47-71524EC20F74', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 1, 17500, 175, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Shotgun/Shotgun');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('30864001-44B5-430B-84C0-3EEB1BAC9C25', '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime', 1, 0, 10000000, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('8CA88984-FDAF-4877-A256-99D7354C549E', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 1, 50000, 225, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/SniperRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('022D3E1C-F679-4463-827F-0A03642FDBF1', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 1, 15000, 65, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Melee/Staff/Staff');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('4864334B-9F64-4B47-B017-D9870484AF42', '/Lotus/Weapons/Tenno/Bows/StalkerBow', 1, 0, 225, 1, 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Bows/StalkerBow');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('3864CBB1-9334-48DF-8CC9-4127E3D56E12', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 1, 8000, 50, 1, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/StartingRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('054DAD3B-1987-44EC-A19F-6AC676D1A5FF', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 1, 15000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('1F081E15-6C53-499F-881A-BF81116AA39B', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 1, 1, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Weapons/Tenno/Rifle/VIPRifle');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('05110E92-7191-4279-A368-62254E7318B2', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 1, 100000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('38E00EA5-84F9-4DAE-B539-9BD083D9DF2B', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 1, 100000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('7E33BAFB-F29F-448F-BCD5-D44F8E560F9A', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('A23D031B-1B1F-470E-AE7D-9CFACCB707E0', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('43CE3073-01E6-4ED5-9D18-95D25353AF9F', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('64C60898-F0E1-4136-9D12-21E8291F0AF9', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('13A25547-006E-481B-B3A6-DB797FFC1375', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('C9136A7B-43C7-4398-902B-B755B6463891', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B4246319-7FBF-4977-B622-50CAE7CA30BA', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('B81196E3-55F7-4774-9FAF-C97D54EFCE54', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('8E5BB300-ABE7-4D87-A40A-9C295640B971', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('17D6A96D-52A2-4216-BB36-0E0F6775C4CE', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('DD9B8BD5-5CB7-4FFA-A3F7-BBDA253D860E', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('94E40EF9-E5E4-4A78-8F29-02FCECCEB965', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 1, 25000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp, WarframeItemType)
VALUES('4B321E1B-2907-4EAA-B799-8FA95B63013F', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 1, 35000, 0, 0, 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint');

INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D490331C-7A03-47EC-903E-FBF7143226D5', '/Lotus/Types/Restoratives/Cipher', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/Ninja', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/Banshee', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/Ember', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/ExcaliburPrime', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/Excalibur', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/FrostPrime', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/Frost', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/Jade', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/Loki', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/Mag', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/Rhino', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/Saryn', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Trapper/Trapper', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/Trinity', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/Volt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E0ABE029-14A3-4AF8-BC97-A625B8240697', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7DD15D12-040D-4765-87FB-6DF87EA672D3', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0C503A5A-AA6C-4629-BF78-321C7F024240', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DB1C72F8-0B08-4C73-ACEB-86997B63E43D', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('CB9E333D-E02D-4418-9B2D-85856FF9EBBB', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('425627BC-AAA0-4292-AEFC-7DCF875A554E', '/Lotus/Types/Recipes/DarkSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('05A846D6-B7D6-4435-94BA-B04D96BD42A2', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('483FABF2-F6D5-4890-B3C0-6E51B15352FA', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('55AA9DBD-729E-4F32-B877-6F747D69D21E', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8B157839-DAFF-44E1-925A-FEDEB2AF2F49', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('663AC222-62FC-4AC8-9A03-6908F32CC729', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3A8A2BF0-C3E2-4E8B-9B68-251577C93084', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7234398A-BBDF-4BE7-94EF-3F8F958AF85D', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('934B48B6-4724-44E0-835C-7086E086A2FF', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B655AFB8-8C04-46D9-89DB-90EDCDD80C32', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F91AC16A-7B9E-44FB-AEC7-FCB9296E1C05', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6B8E4D3E-9F9C-4584-BCE6-914B894BC35F', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1C3D0FBF-C546-47B5-B310-6F958778E8E3', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('35A81525-AA10-4FE4-AC73-788659D19D26', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('90195144-D477-4FAC-919A-9ECFD3D07CA4', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('71731531-5836-4EE9-87E0-6BE98C4DFE29', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('26983D37-7CCB-4FFC-AC55-2F2C726D7380', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FCAFCE6D-00B4-4A02-BEC0-D79242E6FD97', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('41A7508F-FC0D-4A08-8544-0AB6D2501D10', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('98E9EE12-1ADB-4022-AC15-8DCC99099CB8', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C45ACCCB-2FB1-453E-8BB1-C404F0762C68', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8737A90B-EE4D-4A87-A97F-AF5FA4A32B7D', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('74CC0E19-1199-4AEC-BA9D-31FF78D08E9A', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D1B85F28-3E0B-4804-932B-162270B592E1', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6933A9A1-58BE-40F5-A4B1-903D0B7593EE', '/Lotus/Types/Items/MiscItems/OrokinReactor', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('87B7C2C0-1B97-4B6B-AF3B-ADAD4C3A2182', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ACD843B8-9317-4BBA-B63E-828DE1451553', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('900A5615-092A-4541-8DEB-006AA592F6D5', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9E0CFA1D-17EB-4926-83B1-FCB6F89AB781', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F222EE33-4500-4E0C-9026-BD3403FDC445', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6508A4E9-3814-4A0C-9D8C-901BCE8FDBF3', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2BA29F31-41A0-4C53-9B15-8A95F82CD8AA', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A2F3D60F-99F6-45C1-8E84-C84A7F8F4553', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0BBF61DC-52E1-4022-AB9D-227AD16AC2B0', '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B9338A79-75AA-4AF1-85FD-FC95BF8D1700', '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('95E000F0-205D-47A8-BBB1-E01049D22E60', '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2BE17D46-B2FB-4C37-8112-A2383EB8EA2A', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D2D9DC6F-5529-4A6B-87D9-5CE55DF08675', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F828D697-A3A1-492F-B4CF-13A11FCA874F', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D4047180-5EBF-47CA-AAFA-5D853671CB03', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A14A5413-05C9-466A-BE1D-4CA7634D7A76', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C9D5E84A-ECEC-4583-BF8E-9B8323F75A0A', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C6330998-6086-4887-B4B5-E980C2265B4A', '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2DC9F3F4-E2DC-4FDC-AF23-569905263B16', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7670A272-4B30-4EC3-81A2-1D4EA655EAAB', '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('83F3B955-A1D1-4139-BF6C-3A5D2D6A4CA9', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5EA0B0A4-6D29-466C-A5D7-723AB88162A2', '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2C57AE87-7FA0-4860-BE31-79D5C077CEBD', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('00D25FCF-2BC3-4468-A2D3-580DB5BF3C86', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('CD91356C-2B38-4AE4-AE2E-99DCB1F19F10', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3B80BB4F-B63A-4CBD-A1E9-E23FC3EDED5A', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('183F66D6-0980-4637-8AD4-B13D4BD92C1C', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('62A51CC2-EE3B-4488-BA02-122AEC8C2718', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('61E2389F-C0CD-4332-A30D-B91D8E99FFC0', 'ColourPickerItem', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C078E750-5612-4792-8811-E61EC1B28A85', 'ColourPickerItemB', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2803120B-14F9-4265-97C3-4047440B5332', 'ColourPickerItemC', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9', 'ColourPickerFireItemA', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('16B2D787-17D3-439D-B5C9-9CD774570B94', 'ColourPickerIceItemA', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('ADC5F7AA-947E-4DE4-860F-C91BC511BFB3', 'NinjaColourPickerItem', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5023F862-F2E1-4D7F-ADA6-63E2C2294F62', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3AB49431-CC00-4B76-AFC4-0E04401A6498', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4DCCACCC-89B3-4D19-9745-0622E5FF5489', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5FC5E3C1-B7F6-461A-A60D-D0621375C77C', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('28BE0F34-341A-4B90-976B-AFA5A4297362', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FA83A1D9-7FD5-4123-B58E-945A5BDA488B', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DB0383C0-B105-41F4-9233-FF0BEAE304DA', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('83D094C4-0D9F-4AB1-B2C4-6664AF557725', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F93DEF90-2CB6-4CB1-A240-CF76A98FD2DE', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('446D27A7-BC61-4CF9-AC0D-E94BB270C7CC', '/Lotus/Weapons/Tenno/Beam/BeamWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C3523855-A5C7-4D5F-85EF-193B252E286C', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('969A3677-EBE2-4FC2-99EC-C62A05CFBDB5', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B454090F-22C5-4B67-813C-BD25A40B31D0', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('EC7CBAEE-DA55-4554-81A3-FB8A051C7246', '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('211E136C-41AA-492A-9596-66F6DEDA95A7', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('24C2E164-49F8-4EF7-BA00-4433608ED47C', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6045B75E-2EFE-4514-A69C-271B29FF5736', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C3CAB743-C4B8-4613-A909-497E2B7608A1', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('82419219-7214-4531-986A-422F164E07B8', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D7B34ADF-30B6-4045-8ACC-076C35A9035B', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D05A3B66-D044-42CA-98B7-0B0AE883481E', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C746BD6D-7A78-42B8-A624-F719255097FD', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A6F7B83A-C512-415D-8C91-C4FAF910A398', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C547BD95-B70E-4105-9AF2-280922085777', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0CCCB485-E91A-4ED2-893E-539838CF67C2', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9FFA3AFE-451C-4569-AF34-6C8D73E30463', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C0C008CA-3D2C-4336-8E27-BFEFF6E2E384', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2811AD60-0885-4409-9DB6-A82E22D8D3F3', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('59D11652-4406-4810-A6AD-78C7E642E685', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6258DB7A-2D19-4556-872A-990C164517C6', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5378E489-14C2-41D3-954C-40FAF81CDC86', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9A260C26-C169-4966-8BC4-2822CDE7C113', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7AB61A0F-CA2F-48FC-8759-97C0264927C0', '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4356B60B-AB8F-458B-95C2-E035C08E4924', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3E985677-1CCD-4DA0-9986-504359CEE4F9', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('233FE1AA-EA41-4B17-A1C5-5B20CB442D7C', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('765A240F-67CE-4EBD-9FCA-AA5B4AF3ED5B', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D131820F-EF5E-4705-8E6A-60F3D0344047', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C25B76F3-09AD-49AB-940E-6015EC8FEBFC', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8630426E-ED49-4B6C-B562-52B1A92B9D82', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('308436FF-6B56-4D53-BEE0-C91BD8DD7B44', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E5216354-82EA-4B65-902C-9D1AA6B2DE67', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C4EAEB74-DE1F-454F-A44B-683D1E6D630C', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('EA4EC6AF-D0D4-4304-B841-753A6A36E5ED', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4FC210B0-E000-42BA-BBE6-FB60226B8602', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2ECA4F5D-94D3-49C1-876C-6691C0B881DC', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5DC92261-55E2-44DE-ABC1-195CA930AE0C', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E814421F-2513-4A48-91B3-641181E54BA2', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('BBBEA529-6034-4583-80F4-A0AEAAF7CBBE', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B0445840-A84A-4FFA-A552-5CE79FD5C9B5', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5C49F1C0-AA8E-44E7-B232-F7BFFAC9A136', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('476D1BF1-165C-49D8-AF29-FF92722DAEA4', '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('13BFBC0A-6448-4BAC-8D94-F0687FC28D35', '/Lotus/Weapons/Tenno/Pistol/LatoPrime', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('22024336-F7A9-4585-B505-C2FC33BF9C73', '/Lotus/Weapons/Tenno/Pistol/LatoVandal', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('763E914E-6911-4358-9106-C926CD8FEFD5', '/Lotus/Weapons/Tenno/Rifle/LatronPrime', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2A4B76A8-2875-4452-9A88-F55C598CCDD6', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A7C4CD29-E091-4D1C-95E1-D47FAD799F3A', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('29104D79-418F-400D-BB4F-FE0B9585D473', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('95020669-D82F-45B3-AA6D-D37582BBFA8A', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F317007A-A395-4DDE-B4F6-8F5602AECA2B', '/Lotus/Weapons/Tenno/Pistol/Pistol', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A0050D8A-E690-4BC7-9800-A5E6C6F442F2', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7C9EF2E8-AD2E-43C3-ACAA-40DA5868B402', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C62959DE-F670-4A6E-9E90-FF7F8D1747AB', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6735E281-AF57-4DC2-9788-C42C128612B4', '/Lotus/Weapons/Tenno/Rifle/Rifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('33EBC6DC-7DB2-46C8-A66E-F0134E9ADA87', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('35215FC7-1AB0-47BC-9F47-71524EC20F74', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('30864001-44B5-430B-84C0-3EEB1BAC9C25', '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8CA88984-FDAF-4877-A256-99D7354C549E', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('022D3E1C-F679-4463-827F-0A03642FDBF1', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4864334B-9F64-4B47-B017-D9870484AF42', '/Lotus/Weapons/Tenno/Bows/StalkerBow', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3864CBB1-9334-48DF-8CC9-4127E3D56E12', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('054DAD3B-1987-44EC-A19F-6AC676D1A5FF', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1F081E15-6C53-499F-881A-BF81116AA39B', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('05110E92-7191-4279-A368-62254E7318B2', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('38E00EA5-84F9-4DAE-B539-9BD083D9DF2B', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7E33BAFB-F29F-448F-BCD5-D44F8E560F9A', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A23D031B-1B1F-470E-AE7D-9CFACCB707E0', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('43CE3073-01E6-4ED5-9D18-95D25353AF9F', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('64C60898-F0E1-4136-9D12-21E8291F0AF9', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('13A25547-006E-481B-B3A6-DB797FFC1375', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C9136A7B-43C7-4398-902B-B755B6463891', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B4246319-7FBF-4977-B622-50CAE7CA30BA', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B81196E3-55F7-4774-9FAF-C97D54EFCE54', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8E5BB300-ABE7-4D87-A40A-9C295640B971', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('17D6A96D-52A2-4216-BB36-0E0F6775C4CE', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DD9B8BD5-5CB7-4FFA-A3F7-BBDA253D860E', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('94E40EF9-E5E4-4A78-8F29-02FCECCEB965', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4B321E1B-2907-4EAA-B799-8FA95B63013F', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 1, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00');


INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('89B45090-25A1-44EC-BE5A-CEDCB7E4E290', '10736359-2563-4FA1-A525-F0BA454EF1DC', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A1556975-B643-49F6-A1F9-D49A09646DAE', '436A22F9-DFF0-484F-BD9B-7130AAE6081E', '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0034C4A5-F8E4-41C3-B948-EF7BAB1014C9', '84DF8638-734F-4E12-8A99-653A142492FF', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0DCE676C-CDC6-41AF-9C0C-3D9787201C2F', '3BDD2A70-755B-4589-9AC4-272CCFFE1E66', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C2AD9883-F972-41E7-93D9-2FABC0577C23', 'C52C5B73-A3D2-4420-9E0A-53FD7E990C96', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('97F28075-12B7-443B-B306-3C31A56283AC', '472E31AF-D4AD-4BE7-BC86-D33C9576EAB3', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D6CFD990-1754-4A24-BD20-87B6619F73AA', '58142762-AE92-4956-BC0B-A1133738260D', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('90EEC485-60F7-4D63-94A5-CB4C4BEF242D', '108326D4-0212-466A-94FA-3CF287D4D6ED', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9E36E042-A3D1-4A4A-954A-B88996375211', '31A62EB1-8F97-4980-9174-41FF9C607727', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('89966DA8-67B9-4074-B0B9-7E37F153E2E6', '4F4F5BFA-7C83-4B5D-BAAC-00EA36F49182', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C1E840F3-8964-4A7A-9839-8B21F50747F6', 'B14AABF1-DD95-4DB9-B771-72D88E71A572', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8AEA4E36-537C-4106-9154-B16FB3A312D0', 'B9F2A163-267A-44A4-8782-7590A5042176', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A4D3E710-E280-4A8F-A25A-B0A7D47907D3', 'BA305264-3D3E-4BFD-8667-9B6C7C48DA58', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B1DFF47D-6871-41D3-B14A-D1C803435FED', '9A8B22EB-796F-4E93-842F-700A64F554B4', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B046E7F5-B66C-463C-B758-2206CEB87C31', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 'ShadePowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DB1BF5EB-B3F0-4C4A-A2EA-45EC4ACD811D', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPrecepts/Revenge', 'Revenge', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CCBF3317-D12A-4BF6-A4FF-D85FF0B4384F', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPrecepts/Ghost', 'Ghost', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A8C002FC-5357-4AD4-B0EF-9E4405C6D47E', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelWeapons/BurstLaserPistol', 'BurstLaserPistol', 16, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B6FEF217-C5BB-407B-BEAE-1AE90C3F9261', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 'WyrmPowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('61F0C273-B61C-4805-A23A-8D2B2C15A1F2', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPrecepts/Warrior', 'Warrior', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8BCB3A59-A1C7-4AF0-B44B-E512C2BADB73', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPrecepts/CrowdDispersion', 'CrowdDispersion', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0D660BE2-B8D5-473C-B1D0-F11F722F52E0', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelWeapons/LaserRifle', 'LaserRifle', 16, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B1920C6D-7680-4019-88B6-C853A932FEF0', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1F94E54D-084D-4304-A72F-381FC862C804', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/GlaiveAbilityCard', 'GlaiveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FF7006C1-E002-4A4D-8976-582313A60163', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/NinjaStormAbilityCard', 'NinjaStormAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('003A108E-51BB-4F61-BA92-53391B08BAE4', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/SmokeScreenAbilityCard', 'SmokeScreenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('39DF3D2E-9010-4CA1-AC36-D983D955387F', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/TelelportToAbilityCard', 'TelelportToAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A0B976CA-B2B4-4281-BF5E-768BD5DB1CC4', '5169AE6D-1418-4CD2-A128-82D9963E9515', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 'AshChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F8B398F7-6253-4CB5-9D5A-ABF204B8DBB6', '1D172C4A-2BA5-4C98-9B3F-87014587B129', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 'AshHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5EEF954C-0914-458E-87C7-ECC1F140DB0F', 'F7396968-C679-4A1F-9134-295384D68567', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 'AshSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3BCB0995-ABDB-438B-A456-8A736E252966', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('91AC659F-2483-4C36-8C50-44FC0ECCCECF', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/EarthQuakeAbilityCard', 'EarthQuakeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D4B27228-77A3-4B7A-A109-55A01FF6CC14', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/PushAbilityCard', 'PushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6008C1BC-C155-4682-9351-320CF4C57C5A', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/SilenceAbilityCard', 'SilenceAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('31717CCF-C2F9-4B19-BC26-F0362E541829', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/SonarAbilityCard', 'SonarAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F84E247F-1EAB-41C7-B2F3-2F5055E06B1C', '6B5EA26A-F695-4F1C-AA07-76454B5F3EC2', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 'BansheeChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BC53AF25-5894-4C5D-9462-B6115E8D40B0', '4D33C615-F6D4-4A62-BD7F-9CEB0B2C0A25', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 'BansheeHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B0E6325B-7849-4908-8115-26E9498E5CA6', 'D84F4C6E-F60A-47AD-A74C-89AC9A777735', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 'BansheeSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CB98B83E-F5C4-48E9-AD3C-19220688A3F8', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/Ember', 'Ember', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CC656A95-E61E-423C-BCB2-3ADDFF50EA54', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireBallAbilityCard', 'FireBallAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('92F20466-CD3F-4D10-9417-669C46128814', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireBlastAbilityCard', 'FireBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('17D8DEAE-516B-47E8-AB54-B0A63CBDD5C4', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireSkinAbilityCard', 'FireSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F9B1BE05-BF34-4332-ADA7-B2B3365777CF', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/WorldOnFireAbilityCard', 'WorldOnFireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('32DFF678-05BD-41F7-A177-C5E500EC7A40', '1C833EB3-07D7-47D5-B69F-F0870584FAF6', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 'EmberChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C4E87387-E8DA-4CF9-B4B8-C35C0CDB6A6B', '065E5572-89E9-4C4D-B57D-B7019B34E716', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 'EmberHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A67DBD0A-E48B-407B-A425-53218D8B47EF', '5D85229A-79D4-4499-AFD5-29F7A378CFB2', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 'EmberSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D464D367-9661-4F04-A921-11FB99900131', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('377D2101-277E-4488-93D0-9A17E543B3E9', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E770A19E-9E9C-454D-9EF0-1F54AC16D43D', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A7AEA77D-8718-42A6-9CF9-D8B578053CA5', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0DF53862-3D89-49F1-ADC0-065E93C36E37', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E2CC12F8-A9BF-4EE3-A47C-A58859CD0513', '4B9FF0E9-8089-4215-B9AE-60B1937D48C3', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 'ExcaliburChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6A51BB67-D757-46D2-95BF-05DB69570C52', 'D1CD31D9-A1EE-43EF-8243-C6021ECC1D7E', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 'ExcaliburHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B56F451-657C-4D60-93FF-DA5017AA2A85', '6D21D50D-854E-4202-9882-579912D0720D', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 'ExcaliburSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1337BE5C-317E-470D-BD72-B854BA011064', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/Frost', 'Frost', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B37C42EA-1956-421C-80DD-47F266025BDD', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C28868A4-FC82-4291-898E-4ABCDB377D4C', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('43CBF227-2453-4560-AEDB-ED89077C2466', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('10B18448-0BE2-4DA0-8D89-11EE02F0DB74', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FBD793A6-2973-46C0-948C-713F8EFB7107', 'E5709AF9-40DA-4DF8-AA97-8176C9DB2483', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 'FrostChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EB0A6046-95FC-4D2E-97E5-4CAE80490FD1', '397DC37B-5C41-44C0-9234-92F544032B87', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 'FrostHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('949A9348-F95E-436D-B04F-1622C2A6FC85', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B3239C93-4138-439A-8B04-FE202F0FDA7D', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C07CC643-F43E-4DEC-9E80-0BC25C07A8A9', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5C04903E-DBEC-4B65-B53F-3E2CB35384D4', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9687313E-6FE6-4A39-BEF6-AF655E98C1B1', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('797B5FEE-D901-45DA-BB5C-ACD79D627978', '5F50ADE1-E1FF-4816-87EB-ABD795E3160C', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 'FrostPrimeChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('05F46DC8-14F8-4C41-A16E-85FEDA9FA739', '43FA197D-91FB-488B-A5AC-2F162F754BBF', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 'FrostPrimeHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('12685958-2F53-4D41-BFCF-B4796F984F0F', '041F42D9-E344-493F-A74F-752D33FBAEBD', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 'FrostPrimeSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('34DAF3C5-5382-42ED-BB86-4629B7D3F96A', '0A9A6719-159B-4C20-AEB0-2BD2CABE2211', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 'FrostSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('75DB9D4B-5FC2-4293-9E93-708AB317511B', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/Loki', 'Loki', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('50DEB056-D2FC-4507-A4A8-EB901BD215A9', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/DecoyAbilityCard', 'DecoyAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EC9E1D0F-8454-40B5-A6F9-9636B0A54767', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/DisarmAbilityCard', 'DisarmAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('84C34E0E-89E4-4A1B-A927-D104FF56FAFF', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/InvisibilityAbilityCard', 'InvisibilityAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B7E3A3CC-4703-4683-A875-F4A8BD0B15EA', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/SwitchAbilityCard', 'SwitchAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('45223098-549F-4629-B6C1-15F5C1E77354', '678D5780-F10D-4CCC-B1A6-3665D9F2A2C9', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 'LOKIChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F2B13927-2B9C-4AB3-BC56-E0CAC6761150', 'B02C7ABB-8474-4384-B3E5-9F760C77BF1D', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 'LOKIHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FA09C8D8-76EF-4DE3-BF1B-97A21A4B37D7', 'AB36B899-C297-4FD7-B372-B07EC3124E70', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 'LOKISystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AD412E02-CDEF-4058-87FD-DBF7A1707450', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/Mag', 'Mag', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A03F13D5-400D-4066-B977-CF258A3BA3CC', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/BulletAttractorAbilityCard', 'BulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('15DFB9D3-324F-4675-9E20-3DDC1E8524EE', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/CrushAbilityCard', 'CrushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C47FE92A-B0C3-4617-986E-4F149665AAF5', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/PullAbilityCard', 'PullAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2C62C052-4256-4BD2-BB43-FC224E294BA6', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/ShieldRegenAbilityCard', 'ShieldRegenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A916F1B1-B5C9-4CAB-B90A-14F224763EFD', '09215D5C-6836-4F02-B070-5582C783ECB4', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 'MagChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('57B29E93-868C-4798-B712-6C91A54EEA86', '309E924A-F696-4F60-825F-9555ACF133C2', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 'MagHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('76CED69D-02F1-4AEE-8D0F-D1ED50F2C8FB', '443C4B5A-6D6F-46FB-802C-674A7BA845C0', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 'MagSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('64290B9F-B0A2-448D-A058-AB79C3839F46', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/Jade', 'Jade', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('701D1A69-A0DB-4AE3-915D-13D60A8221BB', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/MindControlAbilityCard', 'MindControlAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('94381AF8-1CFF-4736-B097-20C5183BAC2D', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/DaggerAbilityCard', 'DaggerAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CE8624DC-E90B-4A2B-9799-D5C210E0BEDD', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/ChaosAbilityCard', 'ChaosAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('207480EB-F91B-463B-B3BB-833908F5F43D', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/SelfBulletAttractorAbilityCard', 'SelfBulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AEA0A15A-1CF7-4A72-AF11-BAD9D096D2BE', '6660290C-BCCE-478B-AFF5-494224CD655C', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 'NyxChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DB7D0F62-BDE8-4C95-9C96-23361BD63407', '127FE047-F824-4B81-B66F-2B90E180CCAC', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 'NyxHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0665DAF9-FD0B-4D66-BBB7-D32263C40D7B', 'FDDE3FC2-B706-4EEE-B96D-E4CF364C742F', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 'NyxSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('41D341D5-1011-49F3-BA2E-D54766C8580B', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('29E2064F-BB93-4DF5-9F4B-8C73DAFF25BA', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B3CEF200-A6F7-483E-A744-5BD1FE092DE1', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EFFF44A4-F9AD-424A-9E40-95EE3A3FE179', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('79D6FEDB-8A08-4D1D-960A-1BFF85CAA142', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B1ED2BE8-9CAA-4879-85E9-79CFD30BDC6D', '0D0C9609-41FF-4234-9FAA-61E6E3DD5634', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 'RhinoChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C9A6D420-7FE1-4536-AD8D-AF34ACBE7BB5', 'D6A821AE-7D16-4743-AA2F-BB363A973488', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 'RhinoHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('61895FAA-5A06-42E5-987F-9837EE0A4C92', 'AE0D5D8B-AD9D-452C-88A2-26103F62AD60', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 'RhinoSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('36420B83-42D0-4F00-88A8-3A46626307C5', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1FBD3010-3FAA-49BF-8A56-E43C9711C9C5', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/ExplosiveDissolveAbilityCard', 'ExplosiveDissolveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('702E61D2-27FB-4DCD-95A2-AEC60BA712EC', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/PoisonAbilityCard', 'PoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F3BAD3A3-587F-4A9B-BE07-0E69798D1186', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/ShedAbilityCard', 'ShedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C3773E93-BE5A-48FC-B31A-AE3607901788', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/WeaponPoisonAbilityCard', 'WeaponPoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D09F3AF9-EE66-40CC-BA3F-A23029F873E6', '21D97FDB-9C0C-4D4E-B392-C2404134EE89', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 'SarynChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8BA8F813-F194-4140-BF33-6D073ACF3E6E', 'D686BF47-8D2B-4383-84E8-FFD90C45A7B4', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 'SarynHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('05A17F10-89D1-4A1C-8733-BCD1323A52A0', '35693BC7-20DD-4FC4-A90C-903633A7A912', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 'SarynSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D5085592-5CD1-4B64-9CE3-EF697277845F', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5EB3B3E6-D748-4BEA-AD58-A3510BED3FDA', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/BlessingAbilityCard', 'BlessingAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FA6254A2-A46A-4E62-8A63-47B00FEEA7ED', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/EnergyVampireAbilityCard', 'EnergyVampireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9D715276-B3E7-4A5B-9ACD-77B3D76E84EF', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/LinkAbilityCard', 'LinkAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('103E75C4-2B60-43DC-AE94-71C51C53EF67', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/WellOfLifeAbilityCard', 'WellOfLifeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A921017A-A265-4762-9158-6E9DA7101E8E', '718A42A0-73B5-4193-BAC4-E043AF3A7638', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 'TrinityChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2AA72D5A-FFF6-4EC0-9C0A-A438F8A7A3F3', '08DD305E-0FD1-4868-86CB-AAF3972C7BB7', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 'TrinityHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('95393FA3-B7ED-4377-ADEE-C78FC516F4AD', 'EF63036D-09B5-45A2-805F-DB3510CF0AD7', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 'TrinitySystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9CDFEBE6-2637-4DE8-857A-FFFB89FDAB60', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/Volt', 'Volt', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1A0C27B9-2260-4426-B6CA-640F4AC2397B', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/OverloadAbilityCard', 'OverloadAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4F925488-E0B9-4F4B-BD01-5533FE6158C8', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/ShieldAbilityCard', 'ShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7335F88B-1D6E-433A-AFBA-FC795545C914', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/ShockAbilityCard', 'ShockAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C0CAFBB9-A3FD-496B-832F-A3FA66267AC1', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/SpeedAbilityCard', 'SpeedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4700039B-E0A2-41E2-8BAE-BC411E5E0C33', '24DEA1F6-980C-4BF2-897B-F9D7D70D897E', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 'VOLTChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('76B31BDD-546A-446E-9481-1ED244A2A04E', '916EAC52-6C86-4E83-9333-E0691435278C', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 'VOLTHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('631B5EBA-C0BC-41D7-9265-E38CFE09858A', '3E2DCF37-B89A-4ED4-8C28-3172E5EA6FE7', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 'VOLTSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5239230D-86BD-4309-9145-82792AD43DF8', 'E893D687-72EA-4112-A056-EC6A118D7EC4', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7CF9A854-D11B-420D-958B-FFFA9DD55DA6', 'FDB40FA5-EA03-4D73-9CA0-EF4A1CFAE746', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CAB2F767-BB58-4B5D-9109-435FD71F33DB', '53A61315-A390-4F64-B616-EA35597EF245', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4C8197BE-052F-4A47-A6BD-C60C80CD6B19', '3B2CEBAB-6910-4595-8457-2862BFBDE60C', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1108D70B-F8F2-4089-BD26-ED9263971B0E', '5DB68574-6039-4CA6-8459-5DB17B29414D', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DD27CC23-2C83-4F66-B425-16E5EC260396', '464B3060-6444-445E-AF6B-F682D04C4333', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('308D4EB8-5AB1-4B11-ABED-1794E5AE425A', '250ED2DF-ED03-4EE1-A640-49198195A199', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E521D04A-302D-4A30-AF5C-8031DB524588', '70568EBA-C7CA-482C-B4A7-2392DF606B88', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C6BD6586-336C-4F74-9539-8B1B4D31D2FA', '96F3472F-C6F7-4674-800B-0F6EBB8C34B1', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F8B0D5E3-FD11-4EE1-9293-C6663DE72DC2', 'A47EBF70-2861-4003-889C-62332FD8D929', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('14F9E9BA-93D0-4E06-BC81-E673172F3D3A', '4E121F5F-B29C-43DB-8FC1-69CCD724574B', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DA69B44D-27B7-414B-881D-E3CE58816B36', '87EE4503-5D29-400F-BA36-1011E85E29AC', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D3C62AD7-3AA6-420A-AB8A-370F41B859FE', '7E8A0FF4-6852-4889-B38D-7235F0C0C910', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BB21A723-B7CE-4826-9A2E-484BE4447E4E', '990F7DCD-363C-4FED-A682-A4A083288E30', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DE02F693-BE85-4696-994F-4DED529260A6', 'B2126F16-A977-48C1-A26A-38B2BEA1DBD9', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('87043C5D-008F-45CB-B1B4-280B5B90BB8E', '8297E185-ECF1-4A16-B306-163DD67B8D8F', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C9DDF44A-EF7D-4B44-8817-E3441014A909', '64723CB0-740D-4F2C-9064-88072EDE5447', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('51D7973D-9DD8-4050-9132-A9DE26879F5E', 'CBABABFB-97CB-48DB-B59E-811AC433694C', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('31FE397E-D7CD-462F-B0D2-CE533AE9B7F9', '53005AE7-4062-4278-A930-BD21BFDA91B3', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('003646F8-A381-4946-9396-2FAB2757F9CA', 'A76E800D-0855-47B8-9A00-FFE733A98D3C', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CD42542D-C70E-4CCA-9D33-2F8568CD59EE', '9BDD5D06-30C3-4825-8CAD-DD5B87256444', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('36C21D57-A8CD-4000-91FB-24A9404B771C', 'D71EA677-7F69-4123-BA56-229AF3381AD3', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E67D3BA5-BB2B-400B-916D-FAF413FC23D2', '01A86450-0713-4CC9-B3D7-1015E8F33210', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E958A2B8-4E8B-438B-BC65-17039D9C24D3', 'F954D25F-97FF-4354-A8B6-8D4621B9F5C3', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('411339CD-FCE0-43C0-A22D-9BC4B5640C61', 'FE658793-D2C4-4D0D-95FA-F079E99D677F', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FCDDEB9F-8000-42F8-A4B8-2D8C4B3A9319', '6662BAC1-0144-4D94-89D4-823C44A550A9', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8071ECCF-23BA-450F-890E-B2F860C76B5D', '0C490485-4444-44BE-BEE9-A821F8BB769A', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('62595B7D-4B51-4C3B-A397-0AE9868C8CFE', 'A0E5F2D9-4C56-4260-AF56-529F46BC32AD', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FC406A85-8C0B-41E6-BC8E-6B6859219DB1', 'FB86D76A-5490-49CD-8F97-CEF030F74D22', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0C216E6A-ECF9-4FC4-9783-D5C2C79BA7B8', 'B83279F4-21B7-449B-9710-3540FB659B0A', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6AF91AC3-A89C-4676-A596-EC3858DBE283', 'A59D44C7-F394-4D80-8C40-02905640FD3D', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('39433279-4F37-4D24-A932-15ED151E1DA7', '70F30D72-4787-435C-87A4-0D44177EE191', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6D22335E-A45F-4C46-A6A9-AE7B36B5B0A6', '28721969-C80A-415C-9F52-419536022FF0', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2E526A4C-C05B-4078-97FC-4D618A3C9371', 'E75A0AE8-9AB6-43E7-B2B4-00930C1A9147', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E1140656-07A6-4618-ADD9-C2D8C91A9F9A', '875BAF15-BB59-49C5-9782-3795274A64E0', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7546AE4C-957E-469D-9021-FD757CFFCA8D', '872EF610-CAD8-41D5-ADC9-5B734E7426BE', '/Lotus/Upgrades/Modules/Crafted/IncendiaryRifleMod', 'IncendiaryRifleMod', 4, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00', 0, NULL, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('654D7E9D-46A0-43D2-857A-AB79342D01D2', 'D490331C-7A03-47EC-903E-FBF7143226D5', '/Lotus/Types/Restoratives/Cipher', 'Cipher', 2, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1566749B-71AD-4222-AC43-C303F829B6AB', '60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('72C7DE57-3857-4400-93BA-07E9DB986564', '60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/GlaiveAbilityCard', 'GlaiveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('06A50C41-7147-4999-8F10-B486BB3DEB50', '60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/NinjaStormAbilityCard', 'NinjaStormAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F7081B0B-1F42-4345-BEC7-0850097133C5', '60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/SmokeScreenAbilityCard', 'SmokeScreenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4F24A770-FA3E-48B5-A0C6-547DB6B23489', '60492270-B2A9-4FB0-B24E-025E7A2F8B93', '/Lotus/Powersuits/Ninja/TelelportToAbilityCard', 'TelelportToAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1A57B420-2AB0-4F7D-AD01-58A79D58188A', 'D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7E3A5A2C-4E46-4ECE-8A47-B49281C1225A', 'D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/EarthQuakeAbilityCard', 'EarthQuakeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BFB07E3B-3C6E-41C7-95E8-01F2B93233D5', 'D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/PushAbilityCard', 'PushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B36A054-AA4A-4244-8C42-B12046B8B245', 'D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/SilenceAbilityCard', 'SilenceAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7DB4BFBB-420B-4115-ABBE-FCDE9A14AA25', 'D721536F-C685-40CD-A3D4-CE29C9B83F5D', '/Lotus/Powersuits/Banshee/SonarAbilityCard', 'SonarAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DCEA669D-47AB-48BE-B0FD-B4946DAE2E00', '982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/Ember', 'Ember', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C393A4F6-9919-4B26-B7E6-9050CD30E57E', '982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/FireBallAbilityCard', 'FireBallAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9849F8BF-02F3-40AF-BF4F-8F0382A82A1E', '982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/FireBlastAbilityCard', 'FireBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B4E8C43-6D45-40EB-9BEB-231B5CAAAF1E', '982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/FireSkinAbilityCard', 'FireSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C80A62CD-F48D-47E8-802B-E4796945309B', '982DEAED-67AE-4F0A-8DC7-E2C631B02C53', '/Lotus/Powersuits/Ember/WorldOnFireAbilityCard', 'WorldOnFireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('10A8AD7F-B479-47B0-97BF-82321997DA0D', 'DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/ExcaliburPrime', 'ExcaliburPrime', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('58769176-9791-48CD-A95A-060C09FD4079', 'DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0A6EB962-359E-4587-AE74-B3E9F0BC7090', 'DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9053583F-8562-4A7A-9B3A-2F046B82F769', 'DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F15C3427-1777-46BA-8947-6AE6852FC15E', 'DDC93949-5200-4C98-AFB7-050A5DC626DD', '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9380113D-1E08-43C5-95BF-B3065B45259E', 'FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B42F3C4A-1EC2-4E89-B4BD-D43508DDC608', 'FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('02BA4FDA-0B30-46A4-AE11-2195CA907D80', 'FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A9F4C368-D116-4903-8231-54734164ECD9', 'FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9CB73A17-1048-4F05-80D8-0E43EB626307', 'FC422D6E-82EC-4D19-84AA-BA3814514084', '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E6260C10-830D-49D6-BB6E-4961E25AEB36', '5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9E620BB1-FF8E-4D7C-9DFD-DAC369660A44', '5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('58413B9E-FD35-4488-BB92-44759BB7B218', '5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9124CF13-43CD-4699-8A90-654FACEA1DF3', '5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B67BA510-BD7F-457C-BBFC-1449AB78EC7C', '5D6B27D4-3C5A-40A7-9375-C4E6E5B9BA54', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('106E0C26-147D-4976-9E72-E8870796C9F4', '3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/Frost', 'Frost', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('145D25E0-4D83-49E8-9ED2-D368D0217C68', '3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('191C727F-C5BD-4BF2-8B32-C59D7D923B7C', '3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('978CA4EC-7FBE-491B-976B-58BF7632AC5F', '3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3787DAE2-DF43-4B60-9FB1-E740BE565433', '3D2C770A-27FF-4B33-94E4-F60E1672CF98', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DDB6B284-24E1-4466-AC7D-060F0B542891', '498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/Jade', 'Jade', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D7C010D4-811B-4200-87B2-3DF72DA6BB16', '498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/MindControlAbilityCard', 'MindControlAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E1977A8F-FD33-4BF1-B60F-FA7090B08579', '498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/DaggerAbilityCard', 'DaggerAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2F59A637-2B58-42D4-8807-8F1BDFB6A0C5', '498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/ChaosAbilityCard', 'ChaosAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BA4FCE28-D27C-4D19-B4EC-6CB806EC14F0', '498BFBEB-BEC6-49AD-8B01-FE667AB226D2', '/Lotus/Powersuits/Jade/SelfBulletAttractorAbilityCard', 'SelfBulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F51CEF79-885A-42E0-BB68-0C9459DD315A', 'F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/Loki', 'Loki', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ECC14DCA-C1E4-48E4-8CD6-D2E7C71ADD97', 'F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/DecoyAbilityCard', 'DecoyAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('08A148EA-FC46-4BCF-AA62-858735CB646C', 'F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/DisarmAbilityCard', 'DisarmAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C908A281-AEC4-4E33-86DC-F32013603D15', 'F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/InvisibilityAbilityCard', 'InvisibilityAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('456DACBD-CA00-4876-94F1-D5A5446D01A1', 'F49F8D34-716E-44B7-8E7F-F43537F6B45B', '/Lotus/Powersuits/Loki/SwitchAbilityCard', 'SwitchAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C3478BEA-E598-4084-A434-7B46DD16E993', 'D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/Mag', 'Mag', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9FF89E7F-15EF-49F4-ABF7-D1CBE0DFBC87', 'D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/BulletAttractorAbilityCard', 'BulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B760CAA-09DD-4273-9129-5B7CBB7EB583', 'D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/CrushAbilityCard', 'CrushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EEF06F06-2308-4377-82AE-99D2F07283E4', 'D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/PullAbilityCard', 'PullAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C83D43D1-5CF3-429D-B3A4-785B36C82744', 'D3E500AA-D193-404E-8BA9-6A68F7EBCB39', '/Lotus/Powersuits/Mag/ShieldRegenAbilityCard', 'ShieldRegenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('36CA78D3-10F4-4705-9B7F-8F37C2AE735C', '572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('05435039-DE29-4DAE-882C-AC4553B80B4E', '572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0944BF91-507D-4F96-9688-D9277D934E11', '572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D203FAE2-A0C5-4F83-8AF4-64C1C4285655', '572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C5B421E3-BAEF-468B-9596-A0445B9693B4', '572BF2B8-0030-4FC5-A227-25E00425CA50', '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C9A217B1-BCA1-46EF-A5B1-BE578096A7AF', '9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6BB1D335-6766-46C1-B44C-DBD3FCB232D7', '9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/ExplosiveDissolveAbilityCard', 'ExplosiveDissolveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4CE155BE-401B-41DA-A770-6793CD8D7809', '9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/PoisonAbilityCard', 'PoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BD5F7CA4-CC7D-4B2D-BC34-D6D50334A80A', '9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/ShedAbilityCard', 'ShedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('89AB08C9-76F0-434C-9776-8C080E249676', '9214F358-2607-4C5A-A18C-1B1B641492EE', '/Lotus/Powersuits/Saryn/WeaponPoisonAbilityCard', 'WeaponPoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('07768674-8006-4C8F-99F0-7261975E5BB1', 'D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Trapper/Trapper', 'Trapper', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4742BE87-FDE3-4A5C-9AE5-E3441D90ECE6', 'D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('57AF8F6C-2B65-4F51-862F-A5746B67F241', 'D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7A4ABDE0-4D7D-4A16-8754-B6951B1F4D51', 'D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0D3B0470-18A2-4944-BD87-7859FEA5827B', 'D2ADF37E-F711-4733-A365-E39066968833', '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C511421B-51F1-4B02-85A0-FC3A3701C1AC', 'A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0539B25A-E5DF-4E31-A5EC-2650BB260981', 'A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/BlessingAbilityCard', 'BlessingAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('91EA9979-B8E6-48BC-BF45-B507C382B6F6', 'A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/EnergyVampireAbilityCard', 'EnergyVampireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('24EBE2CF-9811-4A83-BE98-5CE29FBA6234', 'A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/LinkAbilityCard', 'LinkAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C92C6D84-7FE9-4675-B0CC-40C64F5B7B62', 'A9A3928B-3D61-419C-A660-494350DE5D23', '/Lotus/Powersuits/Trinity/WellOfLifeAbilityCard', 'WellOfLifeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('317068A4-8A09-4F43-AC99-C285B2F6E227', '58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/Volt', 'Volt', 3, 1, 1, 101, 0, 1, 4, 4, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 0, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9DF28691-5454-45EB-831E-819C8CE1E5A8', '58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/OverloadAbilityCard', 'OverloadAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('872CFAF1-467D-4AEA-83E9-381C16C37F06', '58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/ShieldAbilityCard', 'ShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('828C5E1A-A5F0-472E-8FDC-8D0E950004F2', '58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/ShockAbilityCard', 'ShockAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('435DE8B0-5861-45E1-AE55-A2AC994D1F1D', '58F0FD52-F242-4650-9BDC-AF66E2EA0DCC', '/Lotus/Powersuits/Volt/SpeedAbilityCard', 'SpeedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CA794877-01E3-4148-B2E6-4145DC786DA4', 'E0ABE029-14A3-4AF8-BC97-A625B8240697', '/Lotus/Types/Recipes/Helmets/AshAltHelmetBlueprint', 'AshAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4B095A01-D021-46F4-BB15-BF6C9D3002A8', '7DD15D12-040D-4765-87FB-6DF87EA672D3', '/Lotus/Types/Recipes/Helmets/BansheeAltHelmetBlueprint', 'BansheeAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('15465496-6229-45F1-BEBF-4CFB158D3AB0', '0C503A5A-AA6C-4629-BF78-321C7F024240', '/Lotus/Types/Recipes/Weapons/CeramicDaggerBlueprint', 'CeramicDaggerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('218C2728-41A2-439D-A930-061EEFC412D0', 'DB1C72F8-0B08-4C73-ACEB-86997B63E43D', '/Lotus/Types/Recipes/Weapons/Skins/DaggerAxeBlueprint', 'DaggerAxeBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F1F84173-52A5-4489-800C-E13A1A66E265', 'CB9E333D-E02D-4418-9B2D-85856FF9EBBB', '/Lotus/Types/Recipes/Weapons/DarkDaggerBlueprint', 'DarkDaggerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2AF50EA5-4A4E-456D-AA9E-C5A5458F7994', '425627BC-AAA0-4292-AEFC-7DCF875A554E', '/Lotus/Types/Recipes/DarkSwordBlueprint', 'DarkSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2F646A66-B6A6-4CA2-92F3-6E0027F7F36C', '05A846D6-B7D6-4435-94BA-B04D96BD42A2', '/Lotus/Types/Recipes/Weapons/Skins/DualDaggerAxeBlueprint', 'DualDaggerAxeBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BFCBE05C-756F-435F-8406-49DF21CA8C79', '483FABF2-F6D5-4890-B3C0-6E51B15352FA', '/Lotus/Types/Recipes/Weapons/DualHeatSwordBlueprint', 'DualHeatSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('86260CB5-2392-41A8-9B46-504F58079969', '55AA9DBD-729E-4F32-B877-6F747D69D21E', '/Lotus/Types/Recipes/Helmets/EmberAltHelmetBlueprint', 'EmberAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('763321C5-4499-4324-B28E-18DE7D97DDDD', '8B157839-DAFF-44E1-925A-FEDEB2AF2F49', '/Lotus/Types/Recipes/Helmets/ExcaliburAltHelmetBlueprint', 'ExcaliburAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D8FB67BF-224F-43F4-A9C2-2D32C237127A', '663AC222-62FC-4AC8-9A03-6908F32CC729', '/Lotus/Types/Recipes/Helmets/FrostAltHelmetBlueprint', 'FrostAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1393979C-0A1B-4689-8ED9-E09B974048F1', '3A8A2BF0-C3E2-4E8B-9B68-251577C93084', '/Lotus/Types/Recipes/Weapons/GlaiveBlueprint', 'GlaiveBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EC9A8044-ADD5-4EDA-9E90-7A5BCBA11704', '7234398A-BBDF-4BE7-94EF-3F8F958AF85D', '/Lotus/Types/Recipes/Weapons/GreatSwordBlueprint', 'GreatSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('508A4765-28B0-4C76-B9A5-EE49B7214B2B', '934B48B6-4724-44E0-835C-7086E086A2FF', '/Lotus/Types/Recipes/Weapons/GrineerLightPistolBlueprint', 'GrineerLightPistolBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AB46CE6B-D004-492B-9814-774FD280540C', 'B655AFB8-8C04-46D9-89DB-90EDCDD80C32', '/Lotus/Types/Recipes/Weapons/Skins/GrnAxeBlueprint', 'GrnAxeBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EB7EE0F2-7284-4192-8B6C-44CEF162B17A', 'F91AC16A-7B9E-44FB-AEC7-FCB9296E1C05', '/Lotus/Types/Recipes/Weapons/Skins/GrnHammerBlueprint', 'GrnHammerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9D57BE8A-F27B-4383-8B44-27F256F8244E', '6B8E4D3E-9F9C-4584-BCE6-914B894BC35F', '/Lotus/Types/Recipes/Weapons/GrnHeavyPistolBlueprint', 'GrnHeavyPistolBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A1023B8D-B051-4D1B-9170-6ED070A31594', '1C3D0FBF-C546-47B5-B310-6F958778E8E3', '/Lotus/Types/Recipes/Weapons/GrnStaffBlueprint', 'GrnStaffBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('493B61D9-A0CE-414A-8761-CC9C8E56929A', '35A81525-AA10-4FE4-AC73-788659D19D26', '/Lotus/Types/Recipes/Weapons/HeatDaggerBlueprint', 'HeatDaggerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5E78A459-14E5-4AB5-BA21-54B741F0E26C', '90195144-D477-4FAC-919A-9ECFD3D07CA4', '/Lotus/Types/Recipes/Weapons/HeatSwordBlueprint', 'HeatSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4F15B4C9-C96D-4D73-AEF1-5B82FB07D285', '71731531-5836-4EE9-87E0-6BE98C4DFE29', '/Lotus/Types/Recipes/Weapons/HuntingBowBlueprint', 'HuntingBowBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6862282D-F3C8-4730-876D-6AA73F1A6C89', '26983D37-7CCB-4FFC-AC55-2F2C726D7380', '/Lotus/Types/Recipes/IncendiaryRifleModBlueprint', 'IncendiaryRifleModBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1FC8D229-BEEA-48E7-A312-7F20E83D1643', 'FCAFCE6D-00B4-4A02-BEC0-D79242E6FD97', '/Lotus/Types/Recipes/Weapons/JawBlueprint', 'JawBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C2EBF4ED-0D53-44BC-825B-097C5A725B50', '41A7508F-FC0D-4A08-8544-0AB6D2501D10', '/Lotus/Types/Recipes/Helmets/LokiAltHelmetBlueprint', 'LokiAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('88378410-06E8-47D6-8482-A9FBE4B84E11', '98E9EE12-1ADB-4022-AC15-8DCC99099CB8', '/Lotus/Types/Recipes/Helmets/MagAltHelmetBlueprint', 'MagAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('439D228B-BB0D-4604-8312-5DEEE3049B40', 'C45ACCCB-2FB1-453E-8BB1-C404F0762C68', '/Lotus/Types/Recipes/Weapons/MireSwordBlueprint', 'MireSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6E212E64-11B7-4F7D-A5EB-CD4478D06B3C', '8737A90B-EE4D-4A87-A97F-AF5FA4A32B7D', '/Lotus/Types/Recipes/Helmets/NyxAltHelmetBlueprint', 'NyxAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('ACE8C975-298B-49EC-A80A-6DFDFE9DDD96', '74CC0E19-1199-4AEC-BA9D-31FF78D08E9A', '/Lotus/Types/Recipes/Components/OrokinCatalystBlueprint', 'OrokinCatalystBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E23786C4-6CE3-4C43-B91D-2398AB940676', 'D1B85F28-3E0B-4804-932B-162270B592E1', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F5B2D3AA-AB89-40F6-8075-707AE2E8AD23', '6933A9A1-58BE-40F5-A4B1-903D0B7593EE', '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2A2474FF-AA4D-43DB-8BA7-4553ACA5447F', '87B7C2C0-1B97-4B6B-AF3B-ADAD4C3A2182', '/Lotus/Types/Recipes/Weapons/PangolinSwordBlueprint', 'PangolinSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('58171FFE-7CB7-4A41-95AD-7A93BC2BF491', 'ACD843B8-9317-4BBA-B63E-828DE1451553', '/Lotus/Types/Recipes/Weapons/PlasmaSwordBlueprint', 'PlasmaSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EF7ECA8F-72E3-4717-885D-3986B09A2CF5', '900A5615-092A-4541-8DEB-006AA592F6D5', '/Lotus/Types/Recipes/Helmets/RhinoAltHelmetBlueprint', 'RhinoAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('605D7F6A-C85F-498E-8269-6BB5DC68F324', '9E0CFA1D-17EB-4926-83B1-FCB6F89AB781', '/Lotus/Types/Recipes/Helmets/SarynAltHelmetBlueprint', 'SarynAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EC030CD5-803D-482A-AEF7-CFFBE8972726', 'F222EE33-4500-4E0C-9026-BD3403FDC445', '/Lotus/Types/Recipes/Helmets/TrinityAltHelmetBlueprint', 'TrinityAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D0B75155-7463-4AD1-9371-D16F0FC9EF02', '6508A4E9-3814-4A0C-9D8C-901BCE8FDBF3', '/Lotus/Types/Recipes/Helmets/VoltAltHelmetBlueprint', 'VoltAltHelmetBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9380D682-AD4A-4385-BB79-760F88608B4A', '9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 'ShadePowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 3, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DA92BA65-2924-4CD3-919F-7726668DF84D', '9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelPrecepts/Revenge', 'Revenge', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7002C2BD-17B3-4DE2-9EEB-F41475A4639C', '9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelPrecepts/Ghost', 'Ghost', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AEEF8DDE-2168-47FB-8FFC-2FEC391A1A25', '9E83C5E7-F4E2-4C8D-BA25-BA45B310141C', '/Lotus/Types/Sentinels/SentinelWeapons/BurstLaserPistol', 'BurstLaserPistol', 16, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 3, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1B1B0D23-ED1C-40CB-A725-48D9045CC673', 'F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 'WyrmPowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 3, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E419E9B8-608F-44FF-884C-A53706008B53', 'F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelPrecepts/Warrior', 'Warrior', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8703F0D2-6134-4DE9-B8E5-F2DF0608673A', 'F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelPrecepts/CrowdDispersion', 'CrowdDispersion', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6A3CA0D7-2A62-4AC7-A433-35A6905552A7', 'F075DCA9-94F5-4622-890F-9B33A977350E', '/Lotus/Types/Sentinels/SentinelWeapons/LaserRifle', 'LaserRifle', 16, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 3, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CC069271-CA0C-458D-9E0E-E7AC94D34105', '2BA29F31-41A0-4C53-9B15-8A95F82CD8AA', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DB3C5104-C409-4FEA-B611-A917505D869E', 'A2F3D60F-99F6-45C1-8E84-C84A7F8F4553', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1173B347-FD12-4BE2-9D40-95FE7D86E50F', '0BBF61DC-52E1-4022-AB9D-227AD16AC2B0', '/Lotus/Upgrades/Skins/Sentinels/Tails/CapsuleTail', 'CapsuleTail', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B18696BF-52D3-460A-BC33-FF7413B77C10', 'B9338A79-75AA-4AF1-85FD-FC95BF8D1700', '/Lotus/Upgrades/Skins/Sentinels/Wings/DiamondWings', 'DiamondWings', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CCC02F7A-B00A-4D79-B8D8-296F4AB3DE9F', '95E000F0-205D-47A8-BBB1-E01049D22E60', '/Lotus/Upgrades/Skins/Sentinels/Wings/DomeWings', 'DomeWings', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('E85CDAF7-8D94-45E1-ADD2-FB1C8C9D8DB0', '2BE17D46-B2FB-4C37-8112-A2383EB8EA2A', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0F295075-C308-4543-ABC5-913C059604A0', 'D2D9DC6F-5529-4A6B-87D9-5CE55DF08675', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EB71D64E-DFB6-4613-ABB2-4A9D62F3A89C', 'F828D697-A3A1-492F-B4CF-13A11FCA874F', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B2F827B7-7213-4541-93EA-DEC6BB736C9F', 'D4047180-5EBF-47CA-AAFA-5D853671CB03', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('99092096-BAF7-46F2-9EFF-FEB859C26936', 'A14A5413-05C9-466A-BE1D-4CA7634D7A76', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('44ACF20A-1D47-4DFB-B2FF-F9AF886C1EE0', 'C9D5E84A-ECEC-4583-BF8E-9B8323F75A0A', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B3BFF63B-F2DB-4227-8C53-68D4867E741E', 'C6330998-6086-4887-B4B5-E980C2265B4A', '/Lotus/Upgrades/Skins/Sentinels/Masks/HunhowMask', 'HunhowMask', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F5387873-D1F1-485E-8067-D3F6BCA0C28D', '2DC9F3F4-E2DC-4FDC-AF23-569905263B16', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4391CFF9-A04E-4249-9993-48C4B1710441', '7670A272-4B30-4EC3-81A2-1D4EA655EAAB', '/Lotus/Upgrades/Skins/Sentinels/Masks/KubrowMask', 'KubrowMask', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('38473B27-1FF1-47BE-81C2-0C6CD97E625F', '83F3B955-A1D1-4139-BF6C-3A5D2D6A4CA9', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B9B2A0A4-C16D-4913-9393-916641C3EBA1', '5EA0B0A4-6D29-466C-A5D7-723AB88162A2', '/Lotus/Upgrades/Skins/Sentinels/Masks/LotusMask', 'LotusMask', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0D35C179-971C-4169-84B4-66F6058B70B8', '2C57AE87-7FA0-4860-BE31-79D5C077CEBD', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('30C7B2E8-C67A-4832-9D3F-4C64891DD06B', '00D25FCF-2BC3-4468-A2D3-580DB5BF3C86', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6A147575-37EF-425E-BBE3-3425C9442623', 'CD91356C-2B38-4AE4-AE2E-99DCB1F19F10', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('86E92E86-07DD-4CF3-9A1B-D41C855965F5', '3B80BB4F-B63A-4CBD-A1E9-E23FC3EDED5A', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6977F50C-3F52-4D29-9E77-06F500056751', '183F66D6-0980-4637-8AD4-B13D4BD92C1C', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9C500FA2-F145-4D72-822F-AC042E4B4DA7', '62A51CC2-EE3B-4488-BA02-122AEC8C2718', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D37A3796-A9CC-42D4-BF2C-D61B98037AD6', '61E2389F-C0CD-4332-A30D-B91D8E99FFC0', 'ColourPickerItem', 'ColourPickerItem', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B2F24E2D-872B-4F52-BDE9-22277EA894A9', 'C078E750-5612-4792-8811-E61EC1B28A85', 'ColourPickerItemB', 'ColourPickerItemB', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A231E9D7-582E-4636-8529-3B0F22E78EE2', '2803120B-14F9-4265-97C3-4047440B5332', 'ColourPickerItemC', 'ColourPickerItemC', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9FE5F352-BDF3-467E-9846-117AEDF515B8', 'CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9', 'ColourPickerFireItemA', 'ColourPickerFireItemA', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AE3691A9-75FF-4A09-9A22-5DFDFCD398FE', '16B2D787-17D3-439D-B5C9-9CD774570B94', 'ColourPickerIceItemA', 'ColourPickerIceItemA', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D2B2E2CF-2341-4C5A-9DDA-3293039E18C7', 'ADC5F7AA-947E-4DE4-860F-C91BC511BFB3', 'NinjaColourPickerItem', 'NinjaColourPickerItem', 10, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BFF82A46-A0EC-4270-AE53-425FF0953290', '5023F862-F2E1-4D7F-ADA6-63E2C2294F62', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 'AFurisBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D4D4765D-FE27-4912-BCAF-A00B9D66BD90', '3AB49431-CC00-4B76-AFC4-0E04401A6498', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 'AkBoltoBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B9308D7E-08B0-4B9C-84F3-A60ADEF8729E', '4DCCACCC-89B3-4D19-9745-0622E5FF5489', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EBF1228D-2B7B-44F5-8FBD-788E0EC25847', '5FC5E3C1-B7F6-461A-A60D-D0621375C77C', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('679FD9C8-E7C3-4BDA-8A19-E96289A118FE', '28BE0F34-341A-4B90-976B-AFA5A4297362', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 'AkimboPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4A808727-9416-41AC-8785-BD17F98B7CBB', 'FA83A1D9-7FD5-4123-B58E-945A5BDA488B', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2AEBEDB9-47D7-469F-A19A-9444B2AA9E94', 'DB0383C0-B105-41F4-9233-FF0BEAE304DA', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 'AutoPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9CB2EA53-FCA1-4A3F-8456-8E4AAC80D7D7', '83D094C4-0D9F-4AB1-B2C4-6664AF557725', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'AxeBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C7DE6B08-6E53-4EF4-8FDF-07CC7D9624CF', 'F93DEF90-2CB6-4CB1-A240-CF76A98FD2DE', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4207A8D3-C35C-4BCF-8834-7E838F9C05C5', '446D27A7-BC61-4CF9-AC0D-E94BB270C7CC', '/Lotus/Weapons/Tenno/Beam/BeamWeapon', 'BeamWeapon', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2881399C-D74A-407A-A574-73FE5E238133', 'C3523855-A5C7-4D5F-85EF-193B252E286C', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 'BoltoBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0F61E1BE-108E-476B-920E-909698D07C54', '969A3677-EBE2-4FC2-99EC-C62A05CFBDB5', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 'BoltorBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B74621E2-8336-4F57-AD3B-D5E979F474AA', 'B454090F-22C5-4B67-813C-BD25A40B31D0', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3B8EBC43-85F5-4115-B0D0-F3D3432DADEE', 'EC7CBAEE-DA55-4554-81A3-FB8A051C7246', '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon', 'BoomerangWeapon', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1B9E1530-71C1-45A7-8068-F016E632343D', '211E136C-41AA-492A-9596-66F6DEDA95A7', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 'BurstPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('573FA58A-6599-4577-9C00-396C900D2B27', '24C2E164-49F8-4EF7-BA00-4433608ED47C', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 'BurstRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6713D8CA-7439-49A9-A411-36A76529B242', '6045B75E-2EFE-4514-A69C-271B29FF5736', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7544EC44-E06A-4C75-B5C7-1DFDC9F294C7', 'C3CAB743-C4B8-4613-A909-497E2B7608A1', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8BCCC33B-E121-4FC4-91E6-06EE663DCE58', '82419219-7214-4531-986A-422F164E07B8', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B1C81D07-0AB9-4DF2-A9C3-18841C2017CA', 'D7B34ADF-30B6-4045-8ACC-076C35A9035B', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CA41514B-2B47-4517-85BB-24E18C28A109', 'D05A3B66-D044-42CA-98B7-0B0AE883481E', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3F4DDC39-CA02-4343-ADA6-7A97A52CD221', 'C746BD6D-7A78-42B8-A624-F719255097FD', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4438B350-C576-48C6-9C9C-FE56308AB900', 'A6F7B83A-C512-415D-8C91-C4FAF910A398', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'DualAxeBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('B9B7D7E9-9F8F-4C7A-83B3-92CE10EA78E5', 'C547BD95-B70E-4105-9AF2-280922085777', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('4FD9FF0C-7169-4D5D-9979-EAD90AA8BE74', '0CCCB485-E91A-4ED2-893E-539838CF67C2', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 'DualDaggerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D59F21F7-0686-4BFE-B7BB-EABA2CD05EFD', '9FFA3AFE-451C-4569-AF34-6C8D73E30463', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9B84FADB-4C1B-4719-851C-55D10610F677', 'C0C008CA-3D2C-4336-8E27-BFEFF6E2E384', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 'DualEtherDaggerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0E597CDF-8AC3-481F-9BD3-26B33890C1C3', '2811AD60-0885-4409-9DB6-A82E22D8D3F3', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B7284B9-40FB-48AF-9D6E-C8C6695FA701', '59D11652-4406-4810-A6AD-78C7E642E685', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 'DualEtherSwordBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F9D6A3E5-0924-4BCB-93FA-2C5A1D4A9BFB', '6258DB7A-2D19-4556-872A-990C164517C6', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C059E087-D5C5-49BD-8CFB-78378875DCF3', '5378E489-14C2-41D3-954C-40FAF81CDC86', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('09F01F52-3C47-4C08-8486-390DCCA32235', '9A260C26-C169-4966-8BC4-2822CDE7C113', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 'DualShortSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DF1578B6-F82D-484A-BB85-49D930EE30F2', '7AB61A0F-CA2F-48FC-8759-97C0264927C0', '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword', 'FinLongSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('68C2E36B-38C3-4F30-BC44-F1E6230FEB47', '4356B60B-AB8F-458B-95C2-E035C08E4924', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 'Fist', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F7756103-EBC9-4116-86D8-B36601BCB4F9', '3E985677-1CCD-4DA0-9986-504359CEE4F9', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 'FullAutoShotgun', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('17E348C0-EEE6-4A9A-A8B8-088CE93322EF', '233FE1AA-EA41-4B17-A1C5-5B20CB442D7C', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 'GauntletBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1AFCCE1D-13E3-4E44-B463-30B8C0B69B23', '765A240F-67CE-4EBD-9FCA-AA5B4AF3ED5B', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('9D124179-E7FD-4110-8B2A-3EA7F216982C', 'D131820F-EF5E-4705-8E6A-60F3D0344047', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('2FD51304-3FFD-495E-8F7B-24371E8F0D12', 'C25B76F3-09AD-49AB-940E-6015EC8FEBFC', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5F6870AB-0F37-4EC4-8272-03A85FB1B6C9', '8630426E-ED49-4B6C-B562-52B1A92B9D82', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'GrnAssaultRifleBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EF4F0F8C-A9EA-4C4E-9182-F8AB12F788BB', '308436FF-6B56-4D53-BEE0-C91BD8DD7B44', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FF276427-48EC-4752-9CEE-D5519109D2D7', 'E5216354-82EA-4B65-902C-9D1AA6B2DE67', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('5B0DD61A-1D97-4F7B-8485-A7AFBFF487CF', 'C4EAEB74-DE1F-454F-A44B-683D1E6D630C', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('7C485429-F77E-426C-B750-5FDDB06F79B3', 'EA4EC6AF-D0D4-4304-B841-753A6A36E5ED', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 'HammerBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('060DFE50-6353-46E0-B3A7-40AA3EC7C352', '4FC210B0-E000-42BA-BBE6-FB60226B8602', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('97F33EFE-7568-4A64-AAE8-3A0F7F26988E', '2ECA4F5D-94D3-49C1-876C-6691C0B881DC', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 'HandShotGun', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C5DED03E-417D-471A-B855-1550F1045AF7', '5DC92261-55E2-44DE-ABC1-195CA930AE0C', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1A1E3C1D-9477-448B-B2DC-A1CFDD43E183', 'E814421F-2513-4A48-91B3-641181E54BA2', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 'HeavyPistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('817A0119-3342-41FC-8CC8-0451EB3906D7', 'BBBEA529-6034-4583-80F4-A0AEAAF7CBBE', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 'HeavyRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('235BD6CE-BF10-4C71-83DE-A7627F10131E', 'B0445840-A84A-4FFA-A552-5CE79FD5C9B5', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D84F3080-97D3-4496-9645-C49DBEFA1B53', '5C49F1C0-AA8E-44E7-B232-F7BFFAC9A136', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8EF1F4A5-B28D-4F07-A97C-159FA8FB76E7', '476D1BF1-165C-49D8-AF29-FF92722DAEA4', '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai', 'Kunai', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('DE977AE9-DAA5-40D0-8174-8EF2D6BA80EE', '13BFBC0A-6448-4BAC-8D94-F0687FC28D35', '/Lotus/Weapons/Tenno/Pistol/LatoPrime', 'LatoPrime', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('AD62B3FF-E1E2-4FE9-8379-4FC546EADC41', '22024336-F7A9-4585-B505-C2FC33BF9C73', '/Lotus/Weapons/Tenno/Pistol/LatoVandal', 'LatoVandal', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FE2936E1-213C-49C6-8C94-26327CC6F1E4', '763E914E-6911-4358-9106-C926CD8FEFD5', '/Lotus/Weapons/Tenno/Rifle/LatronPrime', 'LatronPrime', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('C217929F-0AC6-4013-845A-20E093C748DB', '2A4B76A8-2875-4452-9A88-F55C598CCDD6', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D28F6C96-F572-4391-9E71-8B6B1B1B2718', 'A7C4CD29-E091-4D1C-95E1-D47FAD799F3A', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 'LongSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('0B023A12-ADB8-42D7-A774-84D27C0E1BF0', '29104D79-418F-400D-BB4F-FE0B9585D473', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('73D3208F-6A78-431C-97DD-E57CDFC1E889', '95020669-D82F-45B3-AA6D-D37582BBFA8A', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3F15A59C-B35A-44C9-B2E7-40813A2A543E', 'F317007A-A395-4DDE-B4F6-8F5602AECA2B', '/Lotus/Weapons/Tenno/Pistol/Pistol', 'Pistol', 0, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('3089A6FA-3008-472D-A5E1-F74F44E26576', 'A0050D8A-E690-4BC7-9800-A5E6C6F442F2', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('1F62B32E-3798-4996-ACD8-4D5861840ACC', '7C9EF2E8-AD2E-43C3-ACAA-40DA5868B402', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 'QuadShotgunBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FA06027B-BAED-4407-8165-A209FA9691B2', 'C62959DE-F670-4A6E-9E90-FF7F8D1747AB', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('24D9D387-8DC1-4AB7-89C5-106D3393C0C1', '6735E281-AF57-4DC2-9788-C42C128612B4', '/Lotus/Weapons/Tenno/Rifle/Rifle', 'Rifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('BC18600C-ECC7-458A-BD48-22C0BC184CE8', '33EBC6DC-7DB2-46C8-A66E-F0134E9ADA87', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 'SemiAutoRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('90679452-58FB-4FA3-863B-BFA86B93F8C6', '35215FC7-1AB0-47BC-9F47-71524EC20F74', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 'Shotgun', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('17443962-D162-429D-871E-745017FDDF1C', '30864001-44B5-430B-84C0-3EEB1BAC9C25', '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime', 'SkanaPrime', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('A1A7C199-FF90-4337-8FDE-0046B850EFED', '8CA88984-FDAF-4877-A256-99D7354C549E', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 'SniperRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('EBDDEC40-55F1-4331-9E66-DCF720BB4151', '022D3E1C-F679-4463-827F-0A03642FDBF1', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 'Staff', 5, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('83963F3C-0EB5-4107-B606-A7001C45E2B5', '4864334B-9F64-4B47-B017-D9870484AF42', '/Lotus/Weapons/Tenno/Bows/StalkerBow', 'StalkerBow', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('FF0451E7-4899-4B9F-88B6-CD23D7EEF80F', '3864CBB1-9334-48DF-8CC9-4127E3D56E12', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 'StartingRifle', 1, 1, 1, 101, 0, 1, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F6BD71DB-2B44-4F38-AD90-FF5B0D7015D0', '054DAD3B-1987-44EC-A19F-6AC676D1A5FF', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 'TwinViperBlueprint', 13, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('92EF61BC-60AA-42D4-9221-BA7D9AA74785', '1F081E15-6C53-499F-881A-BF81116AA39B', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 'VIPRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 1, 1, 1);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('D3C0F93D-3E69-4122-99E0-97609AF2A677', '05110E92-7191-4279-A368-62254E7318B2', '/Lotus/Types/Recipes/SentinelRecipes/ShadeSentinelBlueprint', 'ShadeSentinelBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('00A5FE18-7912-46D1-B6D5-3D389D24B0D1', '38E00EA5-84F9-4DAE-B539-9BD083D9DF2B', '/Lotus/Types/Recipes/SentinelRecipes/WyrmSentinelBlueprint', 'WyrmSentinelBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6E0986C0-54A7-458A-80C4-C76576198BD3', '7E33BAFB-F29F-448F-BCD5-D44F8E560F9A', '/Lotus/Types/Recipes/WarframeRecipes/AshBlueprint', 'AshBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('57D30CDF-B36F-408A-8A7D-8D0C04A3E563', 'A23D031B-1B1F-470E-AE7D-9CFACCB707E0', '/Lotus/Types/Recipes/WarframeRecipes/BansheeBlueprint', 'BansheeBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('33C9FCB2-2B87-47ED-B7E0-3ABA5B8CD331', '43CE3073-01E6-4ED5-9D18-95D25353AF9F', '/Lotus/Types/Recipes/WarframeRecipes/EmberBlueprint', 'EmberBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CF232FF0-B26C-4C13-87E3-5615F7980136', '64C60898-F0E1-4136-9D12-21E8291F0AF9', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburBlueprint', 'ExcaliburBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('24BD3B18-24FA-4F66-866C-9419FF6026FE', '13A25547-006E-481B-B3A6-DB797FFC1375', '/Lotus/Types/Recipes/WarframeRecipes/FrostBlueprint', 'FrostBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('09545D0E-0510-4D44-A837-034FB1291ACE', 'C9136A7B-43C7-4398-902B-B755B6463891', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeBlueprint', 'FrostPrimeBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('CB0D2E8D-601D-4276-9576-E24170EA44C3', 'B4246319-7FBF-4977-B622-50CAE7CA30BA', '/Lotus/Types/Recipes/WarframeRecipes/LOKIBlueprint', 'LOKIBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('275F3722-526D-4EBC-A0D5-D42A19CF3D60', 'B81196E3-55F7-4774-9FAF-C97D54EFCE54', '/Lotus/Types/Recipes/WarframeRecipes/MagBlueprint', 'MagBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('8812F72C-9AE3-46C6-8F47-17CFC51DF8C7', '8E5BB300-ABE7-4D87-A40A-9C295640B971', '/Lotus/Types/Recipes/WarframeRecipes/NyxBlueprint', 'NyxBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('F2E6913F-7E30-49A1-A041-D1C5F2FFE777', '17D6A96D-52A2-4216-BB36-0E0F6775C4CE', '/Lotus/Types/Recipes/WarframeRecipes/RhinoBlueprint', 'RhinoBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('31A440EA-56AC-4F7C-8084-C2A6F1BB2F54', 'DD9B8BD5-5CB7-4FFA-A3F7-BBDA253D860E', '/Lotus/Types/Recipes/WarframeRecipes/SarynBlueprint', 'SarynBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('6022F0C0-ADD9-4FA6-BEEB-1DCF51F0F746', '94E40EF9-E5E4-4A78-8F29-02FCECCEB965', '/Lotus/Types/Recipes/WarframeRecipes/TrinityBlueprint', 'TrinityBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd)
VALUES('02DC95A1-9AE2-4D3C-8B4E-DEBF46CDF683', '4B321E1B-2907-4EAA-B799-8FA95B63013F', '/Lotus/Types/Recipes/WarframeRecipes/VOLTBlueprint', 'VOLTBlueprint', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-08-03 00:00:00.000000-05:00', '2025-08-03 00:00:00.000000-05:00', 0, 4, 0);



");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
