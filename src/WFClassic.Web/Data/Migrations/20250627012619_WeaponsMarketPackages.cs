using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class WeaponsMarketPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('EA132648-676A-4781-91AE-01C104C3AA2F', '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('2CC820D4-9E32-43B4-BDD4-FEE11766CB15', '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('30C02561-7FF2-485A-A355-D89F40F702B5', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5E774F6F-8441-4C9F-8C12-D554AA33E54B', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('1955EE75-4684-4DC2-94BE-12F817229FF7', '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 1, 12000, 75, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('8B4A3A33-C856-464B-8B0E-B63A5E06320B', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('85A85154-A389-47DC-9A2A-420235E853B5', '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 1, 15000, 120, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('92FAF076-7B8D-4995-9405-07F20C6047D2', '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('795BDA88-85A9-4EF4-A628-1E5CE8606488', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('AB7E995B-5212-4F4C-80BE-FB24FA3C7E0E', '/Lotus/Weapons/Tenno/Beam/BeamWeapon', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('3312D3D6-D92A-4A7E-9330-E3BB272EF43F', '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B5B7DBB3-BDCE-4F68-8224-4E0F6C7AA07D', '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('10241CA7-ECE2-42DD-9B15-A618FE0369CD', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D2F0BE54-58DD-4AC8-80F6-2C02AE628294', '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('92386E03-F247-4ABA-BD64-9DE4C5588D2C', '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 1, 12000, 120, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B6A11584-A191-431D-B0E3-2259782C4157', '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 1, 12000, 120, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D7631A87-2BD2-4B0F-91AA-2EECCF0F609F', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 1, 15000, 150, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('463252D9-1074-4A63-9B71-C40F21D26D2D', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('01D590A9-E7BA-40A8-BD82-06DA5213A110', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 1, 0, 175, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('8639E743-8F4D-47C3-8505-AFB05E325405', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 1, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('601040D1-608B-4925-ADD6-657C45D8B442', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 1, 15000, 150, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('2AB91411-5486-442B-A69B-329D1BDB4945', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 1, 4000, 100, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('05DD7CD3-2161-4391-AE95-5797BDD0F2DC', '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('107D3B96-39ED-4E40-8985-0C341DFD6023', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 1, 0, 175, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9FB32DE1-CD2C-4FA9-A4DC-BDD6A2C3C6CC', '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('43F48F27-186A-4F72-BD82-90C7846115F0', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 1, 0, 135, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('E2D99BF5-62EA-425F-8339-7E1C5963B003', '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9E224C7A-8C63-428F-AA4B-41D695007A7F', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 1, 0, 175, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B7C4BF43-986C-4CA0-A826-1831B23DA34A', '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('B88EFE58-F1C3-4D51-9E86-C0982F086241', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 1, 0, 175, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('90C14A11-1EA3-44BE-9633-EE5AEC0BCBAC', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 1, 0, 175, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('59E2F052-CC6C-4751-856E-D07836ECE6F4', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 1, 45000, 125, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('190A3209-EDD7-4DB8-AE65-03C4921EB39D', '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword', 1, 4000, 100, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('890DA5F7-4E9F-4561-B4E1-7405AA217ED4', '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 1, 30000, 125, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('0AAF946C-1BDE-4483-8065-AE6209AB3985', '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 1, 50000, 225, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('090853B3-B798-4022-AF2F-5A21A1158BFD', '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D21C044B-BCC1-43BA-9D27-CA7085E250F5', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 1, 0, 125, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D8E0A29D-E52A-4C59-85E4-226B439452BC', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('92FBDBFD-F407-46C8-91B8-D193F42A04BE', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 1, 0, 75, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('F75F613D-F13A-4803-998C-67783ACBA999', '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D96BC85F-4A24-4AEA-8138-334412842E8D', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 1, 0, 125, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('F403E745-3EDA-485E-8371-4C1ECFBE459F', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 1, 0, 120, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('C575D5F1-633F-4583-93A2-D89067387936', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('9961D2EA-5077-4529-B24D-474E808237D4', '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('0B5E3CC7-4305-40D3-B5A7-8B3EE1516E39', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('87E07323-FE03-4330-98CA-E22EF07A6744', '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 1, 35000, 190, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5423145B-7763-4560-B716-B7BC6707276D', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 1, 0, 100, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5AE8C7C4-2B43-4F1D-9C99-96880F7A0FB5', '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 1, 35000, 190, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('5C9484F6-C995-4292-B013-B104194FB934', '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 1, 50000, 225, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('E18E97DE-E4D5-48A1-8713-8F5EFD8ADE41', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('29B1832B-343D-4281-9D5D-810793D473EE', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('43903D72-F6F9-4B53-A0E4-A51E0EEAA6B0', '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai', 1, 4000, 250, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('059950C3-DF7D-47E4-8753-943CCC96183B', '/Lotus/Weapons/Tenno/Pistol/LatoPrime', 1, 0, 10000000, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('C37CEDBC-46CD-4CBF-9247-F5D9FE3FD7A0', '/Lotus/Weapons/Tenno/Pistol/LatoVandal', 1, 1, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('86DED27F-3DC5-488E-BA82-9E653454A6AB', '/Lotus/Weapons/Tenno/Rifle/LatronPrime', 1, 0, 10000000, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('56701213-FC5E-4B25-8A9C-0D9B9E368A05', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('187A1131-9CBA-46C3-B790-DA429956A1E0', '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 1, 15000, 150, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('358D54B1-1C58-4F50-A53C-BF6163ED622E', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 1, 0, 150, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('6CAB3BB0-A13C-4942-A035-5436B34A13E8', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('F7DEEAE3-7621-4941-B2E5-24AAFB4387EF', '/Lotus/Weapons/Tenno/Pistol/Pistol', 1, 4000, 50, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('96CD561D-0E6B-4CB0-A79B-2A4A49EA7907', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 1, 20000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('8B858641-985C-4532-B800-B67C072D6077', '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 1, 25000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('92E04C18-A3A1-496C-ADFF-ACF41813356B', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('62DDBC57-2812-4550-AC8A-9141EBB44B61', '/Lotus/Weapons/Tenno/Rifle/Rifle', 1, 10000, 75, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('D3A04E44-9B1A-4067-8CE1-49C84B86085C', '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 1, 50000, 225, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('51C24B62-0D6F-4C8B-8E6E-C29635BB0E3E', '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 1, 17500, 175, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('6B70DDA1-20B4-43AF-B089-794ED73F2C5B', '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime', 1, 0, 10000000, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('255D5D07-AAD4-4F71-9D1C-FE251107930D', '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 1, 50000, 225, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('4C4E111C-8D6D-4B31-B31D-ACFA255A163F', '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 1, 15000, 65, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('62D5A7AB-C5F9-46B8-BFAA-57BA1CE1BCA0', '/Lotus/Weapons/Tenno/Bows/StalkerBow', 1, 0, 225, 1, 0, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('8CD190DB-F84A-4DAF-B9FC-0AD00C8F1EDA', '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 1, 8000, 50, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('CB4D49E6-BCD9-4B96-8059-0EEEE34FB0CE', '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 1, 15000, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageDefinitions
(Id, ItemType, CanBePurchasedMultipleTimes, CostInCredits, CostInPlat, CanBePurchasedWithPlat, CanBePurchasedWithCredits, CreationTimestamp, LastModificationTimestamp)
VALUES('54532C59-2229-436A-9C7E-9B0CE4FCA696', '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 1, 1, 0, 0, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');

















INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('EA132648-676A-4781-91AE-01C104C3AA2F', 'EA132648-676A-4781-91AE-01C104C3AA2F', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/AFurisBlueprint', 'AFurisBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2CC820D4-9E32-43B4-BDD4-FEE11766CB15', '2CC820D4-9E32-43B4-BDD4-FEE11766CB15', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/AkBoltoBlueprint', 'AkBoltoBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('30C02561-7FF2-485A-A355-D89F40F702B5', '30C02561-7FF2-485A-A355-D89F40F702B5', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5E774F6F-8441-4C9F-8C12-D554AA33E54B', '5E774F6F-8441-4C9F-8C12-D554AA33E54B', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('1955EE75-4684-4DC2-94BE-12F817229FF7', '1955EE75-4684-4DC2-94BE-12F817229FF7', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Akimbo/AkimboPistol', 'AkimboPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8B4A3A33-C856-464B-8B0E-B63A5E06320B', '8B4A3A33-C856-464B-8B0E-B63A5E06320B', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('85A85154-A389-47DC-9A2A-420235E853B5', '85A85154-A389-47DC-9A2A-420235E853B5', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/AutoPistol', 'AutoPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('92FAF076-7B8D-4995-9405-07F20C6047D2', '92FAF076-7B8D-4995-9405-07F20C6047D2', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/AxeBlueprint', 'AxeBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('795BDA88-85A9-4EF4-A628-1E5CE8606488', '795BDA88-85A9-4EF4-A628-1E5CE8606488', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('AB7E995B-5212-4F4C-80BE-FB24FA3C7E0E', 'AB7E995B-5212-4F4C-80BE-FB24FA3C7E0E', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Beam/BeamWeapon', 'BeamWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('3312D3D6-D92A-4A7E-9330-E3BB272EF43F', '3312D3D6-D92A-4A7E-9330-E3BB272EF43F', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/BoltoBlueprint', 'BoltoBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B5B7DBB3-BDCE-4F68-8224-4E0F6C7AA07D', 'B5B7DBB3-BDCE-4F68-8224-4E0F6C7AA07D', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/BoltorBlueprint', 'BoltorBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('10241CA7-ECE2-42DD-9B15-A618FE0369CD', '10241CA7-ECE2-42DD-9B15-A618FE0369CD', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D2F0BE54-58DD-4AC8-80F6-2C02AE628294', 'D2F0BE54-58DD-4AC8-80F6-2C02AE628294', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Glaives/Boomerang/BoomerangWeapon', 'BoomerangWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('92386E03-F247-4ABA-BD64-9DE4C5588D2C', '92386E03-F247-4ABA-BD64-9DE4C5588D2C', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/BurstPistol', 'BurstPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B6A11584-A191-431D-B0E3-2259782C4157', 'B6A11584-A191-431D-B0E3-2259782C4157', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/BurstRifle', 'BurstRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D7631A87-2BD2-4B0F-91AA-2EECCF0F609F', 'D7631A87-2BD2-4B0F-91AA-2EECCF0F609F', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('463252D9-1074-4A63-9B71-C40F21D26D2D', '463252D9-1074-4A63-9B71-C40F21D26D2D', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('01D590A9-E7BA-40A8-BD82-06DA5213A110', '01D590A9-E7BA-40A8-BD82-06DA5213A110', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8639E743-8F4D-47C3-8505-AFB05E325405', '8639E743-8F4D-47C3-8505-AFB05E325405', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('601040D1-608B-4925-ADD6-657C45D8B442', '601040D1-608B-4925-ADD6-657C45D8B442', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('2AB91411-5486-442B-A69B-329D1BDB4945', '2AB91411-5486-442B-A69B-329D1BDB4945', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('05DD7CD3-2161-4391-AE95-5797BDD0F2DC', '05DD7CD3-2161-4391-AE95-5797BDD0F2DC', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/DualAxeBlueprint', 'DualAxeBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('107D3B96-39ED-4E40-8985-0C341DFD6023', '107D3B96-39ED-4E40-8985-0C341DFD6023', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9FB32DE1-CD2C-4FA9-A4DC-BDD6A2C3C6CC', '9FB32DE1-CD2C-4FA9-A4DC-BDD6A2C3C6CC', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/DualDaggerBlueprint', 'DualDaggerBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('43F48F27-186A-4F72-BD82-90C7846115F0', '43F48F27-186A-4F72-BD82-90C7846115F0', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('E2D99BF5-62EA-425F-8339-7E1C5963B003', 'E2D99BF5-62EA-425F-8339-7E1C5963B003', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/DualEtherDaggerBlueprint', 'DualEtherDaggerBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9E224C7A-8C63-428F-AA4B-41D695007A7F', '9E224C7A-8C63-428F-AA4B-41D695007A7F', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B7C4BF43-986C-4CA0-A826-1831B23DA34A', 'B7C4BF43-986C-4CA0-A826-1831B23DA34A', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/DualEtherSwordBlueprint', 'DualEtherSwordBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('B88EFE58-F1C3-4D51-9E86-C0982F086241', 'B88EFE58-F1C3-4D51-9E86-C0982F086241', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('90C14A11-1EA3-44BE-9633-EE5AEC0BCBAC', '90C14A11-1EA3-44BE-9633-EE5AEC0BCBAC', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('59E2F052-CC6C-4751-856E-D07836ECE6F4', '59E2F052-CC6C-4751-856E-D07836ECE6F4', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualShortSword', 'DualShortSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('190A3209-EDD7-4DB8-AE65-03C4921EB39D', '190A3209-EDD7-4DB8-AE65-03C4921EB39D', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/FinSword/FinLongSword', 'FinLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('890DA5F7-4E9F-4561-B4E1-7405AA217ED4', '890DA5F7-4E9F-4561-B4E1-7405AA217ED4', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Fist/Fist', 'Fist', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0AAF946C-1BDE-4483-8065-AE6209AB3985', '0AAF946C-1BDE-4483-8065-AE6209AB3985', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Shotgun/FullAutoShotgun', 'FullAutoShotgun', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('090853B3-B798-4022-AF2F-5A21A1158BFD', '090853B3-B798-4022-AF2F-5A21A1158BFD', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/GauntletBlueprint', 'GauntletBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D21C044B-BCC1-43BA-9D27-CA7085E250F5', 'D21C044B-BCC1-43BA-9D27-CA7085E250F5', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D8E0A29D-E52A-4C59-85E4-226B439452BC', 'D8E0A29D-E52A-4C59-85E4-226B439452BC', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('92FBDBFD-F407-46C8-91B8-D193F42A04BE', '92FBDBFD-F407-46C8-91B8-D193F42A04BE', 0, 0, 1, 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F75F613D-F13A-4803-998C-67783ACBA999', 'F75F613D-F13A-4803-998C-67783ACBA999', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/GrnAssaultRifleBlueprint', 'GrnAssaultRifleBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D96BC85F-4A24-4AEA-8138-334412842E8D', 'D96BC85F-4A24-4AEA-8138-334412842E8D', 1, 0, 1, 1, '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F403E745-3EDA-485E-8371-4C1ECFBE459F', 'F403E745-3EDA-485E-8371-4C1ECFBE459F', 0, 0, 1, 1, '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C575D5F1-633F-4583-93A2-D89067387936', 'C575D5F1-633F-4583-93A2-D89067387936', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('9961D2EA-5077-4529-B24D-474E808237D4', '9961D2EA-5077-4529-B24D-474E808237D4', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/HammerBlueprint', 'HammerBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('0B5E3CC7-4305-40D3-B5A7-8B3EE1516E39', '0B5E3CC7-4305-40D3-B5A7-8B3EE1516E39', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('87E07323-FE03-4330-98CA-E22EF07A6744', '87E07323-FE03-4330-98CA-E22EF07A6744', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/HandShotGun', 'HandShotGun', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5423145B-7763-4560-B716-B7BC6707276D', '5423145B-7763-4560-B716-B7BC6707276D', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5AE8C7C4-2B43-4F1D-9C99-96880F7A0FB5', '5AE8C7C4-2B43-4F1D-9C99-96880F7A0FB5', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/HeavyPistol', 'HeavyPistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('5C9484F6-C995-4292-B013-B104194FB934', '5C9484F6-C995-4292-B013-B104194FB934', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/HeavyRifle', 'HeavyRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('E18E97DE-E4D5-48A1-8713-8F5EFD8ADE41', 'E18E97DE-E4D5-48A1-8713-8F5EFD8ADE41', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('29B1832B-343D-4281-9D5D-810793D473EE', '29B1832B-343D-4281-9D5D-810793D473EE', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('43903D72-F6F9-4B53-A0E4-A51E0EEAA6B0', '43903D72-F6F9-4B53-A0E4-A51E0EEAA6B0', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/ThrowingWeapons/Kunai', 'Kunai', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('059950C3-DF7D-47E4-8753-943CCC96183B', '059950C3-DF7D-47E4-8753-943CCC96183B', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/LatoPrime', 'LatoPrime', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('C37CEDBC-46CD-4CBF-9247-F5D9FE3FD7A0', 'C37CEDBC-46CD-4CBF-9247-F5D9FE3FD7A0', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/LatoVandal', 'LatoVandal', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('86DED27F-3DC5-488E-BA82-9E653454A6AB', '86DED27F-3DC5-488E-BA82-9E653454A6AB', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/LatronPrime', 'LatronPrime', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('56701213-FC5E-4B25-8A9C-0D9B9E368A05', '56701213-FC5E-4B25-8A9C-0D9B9E368A05', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('187A1131-9CBA-46C3-B790-DA429956A1E0', '187A1131-9CBA-46C3-B790-DA429956A1E0', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/LongSword/LongSword', 'LongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('358D54B1-1C58-4F50-A53C-BF6163ED622E', '358D54B1-1C58-4F50-A53C-BF6163ED622E', 5, 0, 1, 1, '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6CAB3BB0-A13C-4942-A035-5436B34A13E8', '6CAB3BB0-A13C-4942-A035-5436B34A13E8', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('F7DEEAE3-7621-4941-B2E5-24AAFB4387EF', 'F7DEEAE3-7621-4941-B2E5-24AAFB4387EF', 0, 0, 1, 1, '/Lotus/Weapons/Tenno/Pistol/Pistol', 'Pistol', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('96CD561D-0E6B-4CB0-A79B-2A4A49EA7907', '96CD561D-0E6B-4CB0-A79B-2A4A49EA7907', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8B858641-985C-4532-B800-B67C072D6077', '8B858641-985C-4532-B800-B67C072D6077', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/QuadShotgunBlueprint', 'QuadShotgunBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('92E04C18-A3A1-496C-ADFF-ACF41813356B', '92E04C18-A3A1-496C-ADFF-ACF41813356B', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('62DDBC57-2812-4550-AC8A-9141EBB44B61', '62DDBC57-2812-4550-AC8A-9141EBB44B61', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/Rifle', 'Rifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('D3A04E44-9B1A-4067-8CE1-49C84B86085C', 'D3A04E44-9B1A-4067-8CE1-49C84B86085C', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/SemiAutoRifle', 'SemiAutoRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('51C24B62-0D6F-4C8B-8E6E-C29635BB0E3E', '51C24B62-0D6F-4C8B-8E6E-C29635BB0E3E', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Shotgun/Shotgun', 'Shotgun', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('6B70DDA1-20B4-43AF-B089-794ED73F2C5B', '6B70DDA1-20B4-43AF-B089-794ED73F2C5B', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/LongSword/SkanaPrime', 'SkanaPrime', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('255D5D07-AAD4-4F71-9D1C-FE251107930D', '255D5D07-AAD4-4F71-9D1C-FE251107930D', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/SniperRifle', 'SniperRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('4C4E111C-8D6D-4B31-B31D-ACFA255A163F', '4C4E111C-8D6D-4B31-B31D-ACFA255A163F', 5, 0, 1, 1, '/Lotus/Weapons/Tenno/Melee/Staff/Staff', 'Staff', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('62D5A7AB-C5F9-46B8-BFAA-57BA1CE1BCA0', '62D5A7AB-C5F9-46B8-BFAA-57BA1CE1BCA0', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Bows/StalkerBow', 'StalkerBow', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('8CD190DB-F84A-4DAF-B9FC-0AD00C8F1EDA', '8CD190DB-F84A-4DAF-B9FC-0AD00C8F1EDA', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/StartingRifle', 'StartingRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('CB4D49E6-BCD9-4B96-8059-0EEEE34FB0CE', 'CB4D49E6-BCD9-4B96-8059-0EEEE34FB0CE', 13, 0, 1, 1, '/Lotus/Types/Recipes/Weapons/TwinViperBlueprint', 'TwinViperBlueprint', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');
INSERT INTO MarketPackageItemDefintions
(Id, MarketPackageDefinitionId, InternalInventoryItemType, IsUniqueItem, CanBeAddedRepeatedly, ItemCountToBeAdded, ItemType, ItemName, UpgradeVer, UnlockLevel, ExtraCapacity, UpgradeFingerprint, AddInventoryBin, InventoryBinTypeToAdd, NumberOfBinsToAdd, CreationTimestamp, LastModificationTimestamp)
VALUES('54532C59-2229-436A-9C7E-9B0CE4FCA696', '54532C59-2229-436A-9C7E-9B0CE4FCA696', 1, 0, 1, 1, '/Lotus/Weapons/Tenno/Rifle/VIPRifle', 'VIPRifle', 101, 1, 0, '', 1, 1, 1, '2025-06-26 22:01:19.6008208-05:00', '2025-06-26 22:01:19.6008208-05:00');



");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
