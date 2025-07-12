using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class WarframeItemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('10736359-2563-4FA1-A525-F0BA454EF1DC', '/Lotus/Types/StoreItems/Recipes/OrokinCatalystStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('436A22F9-DFF0-484F-BD9B-7130AAE6081E', '/Lotus/Types/StoreItems/Recipes/OrokinReactorStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('84DF8638-734F-4E12-8A99-653A142492FF', '/Lotus/Types/StoreItems/Skins/NinjaAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3BDD2A70-755B-4589-9AC4-272CCFFE1E66', '/Lotus/Types/StoreItems/Skins/BansheeAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('C52C5B73-A3D2-4420-9E0A-53FD7E990C96', '/Lotus/Types/StoreItems/Skins/EmberAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('472E31AF-D4AD-4BE7-BC86-D33C9576EAB3', '/Lotus/Types/StoreItems/Skins/ExcaliburAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('58142762-AE92-4956-BC0B-A1133738260D', '/Lotus/Types/StoreItems/Skins/FrostAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('108326D4-0212-466A-94FA-3CF287D4D6ED', '/Lotus/Types/StoreItems/Skins/LokiAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('31A62EB1-8F97-4980-9174-41FF9C607727', '/Lotus/Types/StoreItems/Skins/MagAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4F4F5BFA-7C83-4B5D-BAAC-00EA36F49182', '/Lotus/Types/StoreItems/Skins/JadeAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B14AABF1-DD95-4DB9-B771-72D88E71A572', '/Lotus/Types/StoreItems/Skins/RhinoAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B9F2A163-267A-44A4-8782-7590A5042176', '/Lotus/Types/StoreItems/Skins/SarynAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('BA305264-3D3E-4BFD-8667-9B6C7C48DA58', '/Lotus/Types/StoreItems/Skins/TrinityAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9A8B22EB-796F-4E93-842F-700A64F554B4', '/Lotus/Types/StoreItems/Skins/VoltAltHelmetItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/StoreItems/Sentinels/ShadePowerSuitStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/StoreItems/Sentinels/WyrmPowerSuitStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Types/StoreItems/PowerSuits/AshStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5169AE6D-1418-4CD2-A128-82D9963E9515', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1D172C4A-2BA5-4C98-9B3F-87014587B129', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F7396968-C679-4A1F-9134-295384D68567', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Types/StoreItems/PowerSuits/BansheeStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6B5EA26A-F695-4F1C-AA07-76454B5F3EC2', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4D33C615-F6D4-4A62-BD7F-9CEB0B2C0A25', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D84F4C6E-F60A-47AD-A74C-89AC9A777735', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Types/StoreItems/PowerSuits/EmberStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1C833EB3-07D7-47D5-B69F-F0870584FAF6', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('065E5572-89E9-4C4D-B57D-B7019B34E716', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5D85229A-79D4-4499-AFD5-29F7A378CFB2', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Types/StoreItems/PowerSuits/ExcaliburStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4B9FF0E9-8089-4215-B9AE-60B1937D48C3', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D1CD31D9-A1EE-43EF-8243-C6021ECC1D7E', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6D21D50D-854E-4202-9882-579912D0720D', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('1949B783-304D-4704-8682-549F331E4717', '/Lotus/Types/StoreItems/PowerSuits/FrostStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E5709AF9-40DA-4DF8-AA97-8176C9DB2483', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('397DC37B-5C41-44C0-9234-92F544032B87', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Types/StoreItems/PowerSuits/FrostPrimeStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5F50ADE1-E1FF-4816-87EB-ABD795E3160C', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('43FA197D-91FB-488B-A5AC-2F162F754BBF', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('041F42D9-E344-493F-A74F-752D33FBAEBD', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0A9A6719-159B-4C20-AEB0-2BD2CABE2211', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Types/StoreItems/PowerSuits/LokiStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('678D5780-F10D-4CCC-B1A6-3665D9F2A2C9', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B02C7ABB-8474-4384-B3E5-9F760C77BF1D', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AB36B899-C297-4FD7-B372-B07EC3124E70', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Types/StoreItems/PowerSuits/MagStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('09215D5C-6836-4F02-B070-5582C783ECB4', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('309E924A-F696-4F60-825F-9555ACF133C2', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('443C4B5A-6D6F-46FB-802C-674A7BA845C0', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Types/StoreItems/PowerSuits/JadeStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6660290C-BCCE-478B-AFF5-494224CD655C', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('127FE047-F824-4B81-B66F-2B90E180CCAC', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FDDE3FC2-B706-4EEE-B96D-E4CF364C742F', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Types/StoreItems/PowerSuits/RhinoStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0D0C9609-41FF-4234-9FAA-61E6E3DD5634', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D6A821AE-7D16-4743-AA2F-BB363A973488', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('AE0D5D8B-AD9D-452C-88A2-26103F62AD60', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Types/StoreItems/PowerSuits/SarynStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('21D97FDB-9C0C-4D4E-B392-C2404134EE89', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D686BF47-8D2B-4383-84E8-FFD90C45A7B4', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('35693BC7-20DD-4FC4-A90C-903633A7A912', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Types/StoreItems/PowerSuits/TrinityStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('718A42A0-73B5-4193-BAC4-E043AF3A7638', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('08DD305E-0FD1-4868-86CB-AAF3972C7BB7', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('EF63036D-09B5-45A2-805F-DB3510CF0AD7', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Types/StoreItems/PowerSuits/VoltStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('24DEA1F6-980C-4BF2-897B-F9D7D70D897E', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('916EAC52-6C86-4E83-9333-E0691435278C', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3E2DCF37-B89A-4ED4-8C28-3172E5EA6FE7', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E893D687-72EA-4112-A056-EC6A118D7EC4', '/Lotus/Types/StoreItems/Weapons/AkimboAutoPistolStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FDB40FA5-EA03-4D73-9CA0-EF4A1CFAE746', '/Lotus/Types/StoreItems/Weapons/AkimboBoltoStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('53A61315-A390-4F64-B616-EA35597EF245', '/Lotus/Types/StoreItems/Weapons/AxeStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('3B2CEBAB-6910-4595-8457-2862BFBDE60C', '/Lotus/Types/StoreItems/Weapons/CrossBowStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('5DB68574-6039-4CA6-8459-5DB17B29414D', '/Lotus/Types/StoreItems/Weapons/BoltoRifleStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('464B3060-6444-445E-AF6B-F682D04C4333', '/Lotus/Types/StoreItems/Weapons/CeramicDaggerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('250ED2DF-ED03-4EE1-A640-49198195A199', '/Lotus/Types/StoreItems/Weapons/DarkDaggerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('70568EBA-C7CA-482C-B4A7-2392DF606B88', '/Lotus/Types/StoreItems/Weapons/DualAxeStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('96F3472F-C6F7-4674-800B-0F6EBB8C34B1', '/Lotus/Types/StoreItems/Weapons/DualDaggerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A47EBF70-2861-4003-889C-62332FD8D929', '/Lotus/Types/StoreItems/Weapons/DualEtherDaggerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('4E121F5F-B29C-43DB-8FC1-69CCD724574B', '/Lotus/Types/StoreItems/Weapons/DualEtherSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('87EE4503-5D29-400F-BA36-1011E85E29AC', '/Lotus/Types/StoreItems/Weapons/DualHeatSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('7E8A0FF4-6852-4889-B38D-7235F0C0C910', '/Lotus/Types/StoreItems/Weapons/GauntletStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('990F7DCD-363C-4FED-A682-A4A083288E30', '/Lotus/Types/StoreItems/Weapons/LightGlaiveStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B2126F16-A977-48C1-A26A-38B2BEA1DBD9', '/Lotus/Types/StoreItems/Weapons/GreatSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('8297E185-ECF1-4A16-B306-163DD67B8D8F', '/Lotus/Types/StoreItems/Weapons/GrineerLightPistolStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('64723CB0-740D-4F2C-9064-88072EDE5447', '/Lotus/Types/StoreItems/Weapons/GrnAssaultRifleStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('CBABABFB-97CB-48DB-B59E-811AC433694C', '/Lotus/Types/StoreItems/Weapons/GrnHeavyPistolStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('53005AE7-4062-4278-A930-BD21BFDA91B3', '/Lotus/Types/StoreItems/Weapons/GrnStaffStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A76E800D-0855-47B8-9A00-FFE733A98D3C', '/Lotus/Types/StoreItems/Weapons/HammerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('9BDD5D06-30C3-4825-8CAD-DD5B87256444', '/Lotus/Types/StoreItems/Weapons/DaggerStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('D71EA677-7F69-4123-BA56-229AF3381AD3', '/Lotus/Types/StoreItems/Weapons/HeatSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('01A86450-0713-4CC9-B3D7-1015E8F33210', '/Lotus/Types/StoreItems/Weapons/HuntingBowStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('F954D25F-97FF-4354-A8B6-8D4621B9F5C3', '/Lotus/Types/StoreItems/Weapons/JawLongSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FE658793-D2C4-4D0D-95FA-F079E99D677F', '/Lotus/Types/StoreItems/Weapons/MireSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('6662BAC1-0144-4D94-89D4-823C44A550A9', '/Lotus/Types/StoreItems/Weapons/PangolinLongSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('0C490485-4444-44BE-BEE9-A821F8BB769A', '/Lotus/Types/StoreItems/Weapons/PlasmaSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A0E5F2D9-4C56-4260-AF56-529F46BC32AD', '/Lotus/Types/StoreItems/Weapons/QuadShotgunStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('FB86D76A-5490-49CD-8F97-CEF030F74D22', '/Lotus/Types/StoreItems/Weapons/AkimboViperStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('B83279F4-21B7-449B-9710-3540FB659B0A', '/Lotus/Types/StoreItems/Skins/AxeDaggerAxeItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('A59D44C7-F394-4D80-8C40-02905640FD3D', '/Lotus/Types/StoreItems/Skins/DualAxeDaggerAxeItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('70F30D72-4787-435C-87A4-0D44177EE191', '/Lotus/Types/StoreItems/Skins/GrnAxeSkinItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('28721969-C80A-415C-9F52-419536022FF0', '/Lotus/Types/StoreItems/Skins/HammerSkintem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('E75A0AE8-9AB6-43E7-B2B4-00930C1A9147', '/Lotus/Types/StoreItems/Weapons/CronusLongSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('875BAF15-BB59-49C5-9782-3795274A64E0', '/Lotus/Types/StoreItems/Weapons/DarkSwordStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItems
(Id, ItemType, WarframeItemLocation, CreationTimestamp, LastModificationTimestamp)
VALUES('872EF610-CAD8-41D5-ADC9-5B734E7426BE', '/Lotus/Types/StoreItems/WeaponUpgrades/IncendiaryRifleModStoreItem', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');






INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('89B45090-25A1-44EC-BE5A-CEDCB7E4E290', '10736359-2563-4FA1-A525-F0BA454EF1DC', '/Lotus/Types/Items/MiscItems/OrokinCatalyst', 'OrokinCatalyst', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A1556975-B643-49F6-A1F9-D49A09646DAE', '436A22F9-DFF0-484F-BD9B-7130AAE6081E', '/Lotus/Types/Items/MiscItems/OrokinReactor', 'OrokinReactor', 11, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0034C4A5-F8E4-41C3-B948-EF7BAB1014C9', '84DF8638-734F-4E12-8A99-653A142492FF', '/Lotus/Upgrades/Skins/Ninja/NinjaHelmetAlt', 'NinjaHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0DCE676C-CDC6-41AF-9C0C-3D9787201C2F', '3BDD2A70-755B-4589-9AC4-272CCFFE1E66', '/Lotus/Upgrades/Skins/Decree/DecreeAltHelmet', 'DecreeAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C2AD9883-F972-41E7-93D9-2FABC0577C23', 'C52C5B73-A3D2-4420-9E0A-53FD7E990C96', '/Lotus/Upgrades/Skins/Ember/EmberHelmetAlt', 'EmberHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('97F28075-12B7-443B-B306-3C31A56283AC', '472E31AF-D4AD-4BE7-BC86-D33C9576EAB3', '/Lotus/Upgrades/Skins/Excalibur/ExcaliburHelmetAlt', 'ExcaliburHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D6CFD990-1754-4A24-BD20-87B6619F73AA', '58142762-AE92-4956-BC0B-A1133738260D', '/Lotus/Upgrades/Skins/Frost/FrostHelmetAlt', 'FrostHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('90EEC485-60F7-4D63-94A5-CB4C4BEF242D', '108326D4-0212-466A-94FA-3CF287D4D6ED', '/Lotus/Upgrades/Skins/Loki/LokiHelmetAlt', 'LokiHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('9E36E042-A3D1-4A4A-954A-B88996375211', '31A62EB1-8F97-4980-9174-41FF9C607727', '/Lotus/Upgrades/Skins/Mag/MagHelmetAlt', 'MagHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('89966DA8-67B9-4074-B0B9-7E37F153E2E6', '4F4F5BFA-7C83-4B5D-BAAC-00EA36F49182', '/Lotus/Upgrades/Skins/Jade/JadeHelmetAlt', 'JadeHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C1E840F3-8964-4A7A-9839-8B21F50747F6', 'B14AABF1-DD95-4DB9-B771-72D88E71A572', '/Lotus/Upgrades/Skins/Rhino/RhinoHelmetAlt', 'RhinoHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('8AEA4E36-537C-4106-9154-B16FB3A312D0', 'B9F2A163-267A-44A4-8782-7590A5042176', '/Lotus/Upgrades/Skins/Asp/AspAltHelmet', 'AspAltHelmet', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A4D3E710-E280-4A8F-A25A-B0A7D47907D3', 'BA305264-3D3E-4BFD-8667-9B6C7C48DA58', '/Lotus/Upgrades/Skins/Trinity/TrinityHelmetAlt', 'TrinityHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B1DFF47D-6871-41D3-B14A-D1C803435FED', '9A8B22EB-796F-4E93-842F-700A64F554B4', '/Lotus/Upgrades/Skins/Volt/VoltHelmetAlt', 'VoltHelmetAlt', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B046E7F5-B66C-463C-B758-2206CEB87C31', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit', 'ShadePowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('DB1BF5EB-B3F0-4C4A-A2EA-45EC4ACD811D', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPrecepts/Revenge', 'Revenge', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CCBF3317-D12A-4BF6-A4FF-D85FF0B4384F', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelPrecepts/Ghost', 'Ghost', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A8C002FC-5357-4AD4-B0EF-9E4405C6D47E', '2440A5F3-F06D-45E4-A9D4-95CFBF0266D9', '/Lotus/Types/Sentinels/SentinelWeapons/BurstLaserPistol', 'BurstLaserPistol', 16, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B6FEF217-C5BB-407B-BEAE-1AE90C3F9261', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit', 'WyrmPowerSuit', 15, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('61F0C273-B61C-4805-A23A-8D2B2C15A1F2', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPrecepts/Warrior', 'Warrior', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('8BCB3A59-A1C7-4AF0-B44B-E512C2BADB73', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelPrecepts/CrowdDispersion', 'CrowdDispersion', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0D660BE2-B8D5-473C-B1D0-F11F722F52E0', '1CA408AE-1D50-4931-9123-685FFD8FF66F', '/Lotus/Types/Sentinels/SentinelWeapons/LaserRifle', 'LaserRifle', 16, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B1920C6D-7680-4019-88B6-C853A932FEF0', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/Ninja', 'Ninja', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('1F94E54D-084D-4304-A72F-381FC862C804', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/GlaiveAbilityCard', 'GlaiveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FF7006C1-E002-4A4D-8976-582313A60163', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/NinjaStormAbilityCard', 'NinjaStormAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('003A108E-51BB-4F61-BA92-53391B08BAE4', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/SmokeScreenAbilityCard', 'SmokeScreenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('39DF3D2E-9010-4CA1-AC36-D983D955387F', '6B6815F7-7261-48BA-822C-9125BA5B5192', '/Lotus/Powersuits/Ninja/TelelportToAbilityCard', 'TelelportToAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A0B976CA-B2B4-4281-BF5E-768BD5DB1CC4', '5169AE6D-1418-4CD2-A128-82D9963E9515', '/Lotus/Types/Recipes/WarframeRecipes/AshChassisComponent', 'AshChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F8B398F7-6253-4CB5-9D5A-ABF204B8DBB6', '1D172C4A-2BA5-4C98-9B3F-87014587B129', '/Lotus/Types/Recipes/WarframeRecipes/AshHelmetComponent', 'AshHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('5EEF954C-0914-458E-87C7-ECC1F140DB0F', 'F7396968-C679-4A1F-9134-295384D68567', '/Lotus/Types/Recipes/WarframeRecipes/AshSystemsComponent', 'AshSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('3BCB0995-ABDB-438B-A456-8A736E252966', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/Banshee', 'Banshee', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('91AC659F-2483-4C36-8C50-44FC0ECCCECF', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/EarthQuakeAbilityCard', 'EarthQuakeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D4B27228-77A3-4B7A-A109-55A01FF6CC14', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/PushAbilityCard', 'PushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('6008C1BC-C155-4682-9351-320CF4C57C5A', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/SilenceAbilityCard', 'SilenceAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('31717CCF-C2F9-4B19-BC26-F0362E541829', 'F2785B11-BD5A-4BE9-B5C5-C5D8218A2EFA', '/Lotus/Powersuits/Banshee/SonarAbilityCard', 'SonarAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F84E247F-1EAB-41C7-B2F3-2F5055E06B1C', '6B5EA26A-F695-4F1C-AA07-76454B5F3EC2', '/Lotus/Types/Recipes/WarframeRecipes/BansheeChassisComponent', 'BansheeChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('BC53AF25-5894-4C5D-9462-B6115E8D40B0', '4D33C615-F6D4-4A62-BD7F-9CEB0B2C0A25', '/Lotus/Types/Recipes/WarframeRecipes/BansheeHelmetComponent', 'BansheeHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B0E6325B-7849-4908-8115-26E9498E5CA6', 'D84F4C6E-F60A-47AD-A74C-89AC9A777735', '/Lotus/Types/Recipes/WarframeRecipes/BansheeSystemsComponent', 'BansheeSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CB98B83E-F5C4-48E9-AD3C-19220688A3F8', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/Ember', 'Ember', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CC656A95-E61E-423C-BCB2-3ADDFF50EA54', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireBallAbilityCard', 'FireBallAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('92F20466-CD3F-4D10-9417-669C46128814', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireBlastAbilityCard', 'FireBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('17D8DEAE-516B-47E8-AB54-B0A63CBDD5C4', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/FireSkinAbilityCard', 'FireSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F9B1BE05-BF34-4332-ADA7-B2B3365777CF', '216D09F6-CA13-4588-965F-425A25916599', '/Lotus/Powersuits/Ember/WorldOnFireAbilityCard', 'WorldOnFireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('32DFF678-05BD-41F7-A177-C5E500EC7A40', '1C833EB3-07D7-47D5-B69F-F0870584FAF6', '/Lotus/Types/Recipes/WarframeRecipes/EmberChassisComponent', 'EmberChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C4E87387-E8DA-4CF9-B4B8-C35C0CDB6A6B', '065E5572-89E9-4C4D-B57D-B7019B34E716', '/Lotus/Types/Recipes/WarframeRecipes/EmberHelmetComponent', 'EmberHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A67DBD0A-E48B-407B-A425-53218D8B47EF', '5D85229A-79D4-4499-AFD5-29F7A378CFB2', '/Lotus/Types/Recipes/WarframeRecipes/EmberSystemsComponent', 'EmberSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D464D367-9661-4F04-A921-11FB99900131', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/Excalibur', 'Excalibur', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('377D2101-277E-4488-93D0-9A17E543B3E9', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/RadialBlindAbilityCard', 'RadialBlindAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E770A19E-9E9C-454D-9EF0-1F54AC16D43D', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/RadialJavelinAbilityCard', 'RadialJavelinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A7AEA77D-8718-42A6-9CF9-D8B578053CA5', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/SlashDashAbilityCard', 'SlashDashAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0DF53862-3D89-49F1-ADC0-065E93C36E37', '1878AB66-04CF-49FE-ADBF-CCA20FA51893', '/Lotus/Powersuits/Excalibur/SuperJumpAbilityCard', 'SuperJumpAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E2CC12F8-A9BF-4EE3-A47C-A58859CD0513', '4B9FF0E9-8089-4215-B9AE-60B1937D48C3', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburChassisComponent', 'ExcaliburChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('6A51BB67-D757-46D2-95BF-05DB69570C52', 'D1CD31D9-A1EE-43EF-8243-C6021ECC1D7E', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburHelmetComponent', 'ExcaliburHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0B56F451-657C-4D60-93FF-DA5017AA2A85', '6D21D50D-854E-4202-9882-579912D0720D', '/Lotus/Types/Recipes/WarframeRecipes/ExcaliburSystemsComponent', 'ExcaliburSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('1337BE5C-317E-470D-BD72-B854BA011064', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/Frost', 'Frost', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B37C42EA-1956-421C-80DD-47F266025BDD', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C28868A4-FC82-4291-898E-4ABCDB377D4C', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('43CBF227-2453-4560-AEDB-ED89077C2466', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('10B18448-0BE2-4DA0-8D89-11EE02F0DB74', '1949B783-304D-4704-8682-549F331E4717', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FBD793A6-2973-46C0-948C-713F8EFB7107', 'E5709AF9-40DA-4DF8-AA97-8176C9DB2483', '/Lotus/Types/Recipes/WarframeRecipes/FrostChassisComponent', 'FrostChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('EB0A6046-95FC-4D2E-97E5-4CAE80490FD1', '397DC37B-5C41-44C0-9234-92F544032B87', '/Lotus/Types/Recipes/WarframeRecipes/FrostHelmetComponent', 'FrostHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('949A9348-F95E-436D-B04F-1622C2A6FC85', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/FrostPrime', 'FrostPrime', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B3239C93-4138-439A-8B04-FE202F0FDA7D', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/AvalancheAbilityCard', 'AvalancheAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C07CC643-F43E-4DEC-9E80-0BC25C07A8A9', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IceShieldAbilityCard', 'IceShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('5C04903E-DBEC-4B65-B53F-3E2CB35384D4', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IceSpikeAbilityCard', 'IceSpikeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('9687313E-6FE6-4A39-BEF6-AF655E98C1B1', 'E425347A-EB2F-45A3-9FFC-F562113AEF7F', '/Lotus/Powersuits/Frost/IcicleAbilityCard', 'IcicleAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('797B5FEE-D901-45DA-BB5C-ACD79D627978', '5F50ADE1-E1FF-4816-87EB-ABD795E3160C', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeChassisComponent', 'FrostPrimeChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('05F46DC8-14F8-4C41-A16E-85FEDA9FA739', '43FA197D-91FB-488B-A5AC-2F162F754BBF', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeHelmetComponent', 'FrostPrimeHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('12685958-2F53-4D41-BFCF-B4796F984F0F', '041F42D9-E344-493F-A74F-752D33FBAEBD', '/Lotus/Types/Recipes/WarframeRecipes/FrostPrimeSystemsComponent', 'FrostPrimeSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('34DAF3C5-5382-42ED-BB86-4629B7D3F96A', '0A9A6719-159B-4C20-AEB0-2BD2CABE2211', '/Lotus/Types/Recipes/WarframeRecipes/FrostSystemsComponent', 'FrostSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('75DB9D4B-5FC2-4293-9E93-708AB317511B', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/Loki', 'Loki', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('50DEB056-D2FC-4507-A4A8-EB901BD215A9', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/DecoyAbilityCard', 'DecoyAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('EC9E1D0F-8454-40B5-A6F9-9636B0A54767', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/DisarmAbilityCard', 'DisarmAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('84C34E0E-89E4-4A1B-A927-D104FF56FAFF', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/InvisibilityAbilityCard', 'InvisibilityAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B7E3A3CC-4703-4683-A875-F4A8BD0B15EA', '0BBADCB6-3202-41C2-84A2-68E903521019', '/Lotus/Powersuits/Loki/SwitchAbilityCard', 'SwitchAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('45223098-549F-4629-B6C1-15F5C1E77354', '678D5780-F10D-4CCC-B1A6-3665D9F2A2C9', '/Lotus/Types/Recipes/WarframeRecipes/LOKIChassisComponent', 'LOKIChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F2B13927-2B9C-4AB3-BC56-E0CAC6761150', 'B02C7ABB-8474-4384-B3E5-9F760C77BF1D', '/Lotus/Types/Recipes/WarframeRecipes/LOKIHelmetComponent', 'LOKIHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FA09C8D8-76EF-4DE3-BF1B-97A21A4B37D7', 'AB36B899-C297-4FD7-B372-B07EC3124E70', '/Lotus/Types/Recipes/WarframeRecipes/LOKISystemsComponent', 'LOKISystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('AD412E02-CDEF-4058-87FD-DBF7A1707450', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/Mag', 'Mag', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A03F13D5-400D-4066-B977-CF258A3BA3CC', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/BulletAttractorAbilityCard', 'BulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('15DFB9D3-324F-4675-9E20-3DDC1E8524EE', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/CrushAbilityCard', 'CrushAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C47FE92A-B0C3-4617-986E-4F149665AAF5', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/PullAbilityCard', 'PullAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('2C62C052-4256-4BD2-BB43-FC224E294BA6', '7EFC3E95-FCF5-4571-9BF9-470D80336804', '/Lotus/Powersuits/Mag/ShieldRegenAbilityCard', 'ShieldRegenAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A916F1B1-B5C9-4CAB-B90A-14F224763EFD', '09215D5C-6836-4F02-B070-5582C783ECB4', '/Lotus/Types/Recipes/WarframeRecipes/MagChassisComponent', 'MagChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('57B29E93-868C-4798-B712-6C91A54EEA86', '309E924A-F696-4F60-825F-9555ACF133C2', '/Lotus/Types/Recipes/WarframeRecipes/MagHelmetComponent', 'MagHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('76CED69D-02F1-4AEE-8D0F-D1ED50F2C8FB', '443C4B5A-6D6F-46FB-802C-674A7BA845C0', '/Lotus/Types/Recipes/WarframeRecipes/MagSystemsComponent', 'MagSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('64290B9F-B0A2-448D-A058-AB79C3839F46', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/Jade', 'Jade', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('701D1A69-A0DB-4AE3-915D-13D60A8221BB', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/MindControlAbilityCard', 'MindControlAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('94381AF8-1CFF-4736-B097-20C5183BAC2D', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/DaggerAbilityCard', 'DaggerAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CE8624DC-E90B-4A2B-9799-D5C210E0BEDD', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/ChaosAbilityCard', 'ChaosAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('207480EB-F91B-463B-B3BB-833908F5F43D', '18F18D28-1F9A-4DB0-A52C-877FFE77E115', '/Lotus/Powersuits/Jade/SelfBulletAttractorAbilityCard', 'SelfBulletAttractorAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('AEA0A15A-1CF7-4A72-AF11-BAD9D096D2BE', '6660290C-BCCE-478B-AFF5-494224CD655C', '/Lotus/Types/Recipes/WarframeRecipes/NyxChassisComponent', 'NyxChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('DB7D0F62-BDE8-4C95-9C96-23361BD63407', '127FE047-F824-4B81-B66F-2B90E180CCAC', '/Lotus/Types/Recipes/WarframeRecipes/NyxHelmetComponent', 'NyxHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0665DAF9-FD0B-4D66-BBB7-D32263C40D7B', 'FDDE3FC2-B706-4EEE-B96D-E4CF364C742F', '/Lotus/Types/Recipes/WarframeRecipes/NyxSystemsComponent', 'NyxSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('41D341D5-1011-49F3-BA2E-D54766C8580B', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/Rhino', 'Rhino', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('29E2064F-BB93-4DF5-9F4B-8C73DAFF25BA', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/IronSkinAbilityCard', 'IronSkinAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B3CEF200-A6F7-483E-A744-5BD1FE092DE1', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RadialBlastAbilityCard', 'RadialBlastAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('EFFF44A4-F9AD-424A-9E40-95EE3A3FE179', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RhinoChargeAbilityCard', 'RhinoChargeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('79D6FEDB-8A08-4D1D-960A-1BFF85CAA142', 'A75B89FD-ACBA-409E-93AB-3BCDF7A12413', '/Lotus/Powersuits/Rhino/RhinoStompAbilityCard', 'RhinoStompAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('B1ED2BE8-9CAA-4879-85E9-79CFD30BDC6D', '0D0C9609-41FF-4234-9FAA-61E6E3DD5634', '/Lotus/Types/Recipes/WarframeRecipes/RhinoChassisComponent', 'RhinoChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C9A6D420-7FE1-4536-AD8D-AF34ACBE7BB5', 'D6A821AE-7D16-4743-AA2F-BB363A973488', '/Lotus/Types/Recipes/WarframeRecipes/RhinoHelmetComponent', 'RhinoHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('61895FAA-5A06-42E5-987F-9837EE0A4C92', 'AE0D5D8B-AD9D-452C-88A2-26103F62AD60', '/Lotus/Types/Recipes/WarframeRecipes/RhinoSystemsComponent', 'RhinoSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('36420B83-42D0-4F00-88A8-3A46626307C5', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/Saryn', 'Saryn', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('1FBD3010-3FAA-49BF-8A56-E43C9711C9C5', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/ExplosiveDissolveAbilityCard', 'ExplosiveDissolveAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('702E61D2-27FB-4DCD-95A2-AEC60BA712EC', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/PoisonAbilityCard', 'PoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F3BAD3A3-587F-4A9B-BE07-0E69798D1186', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/ShedAbilityCard', 'ShedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C3773E93-BE5A-48FC-B31A-AE3607901788', '43578864-F000-4C81-A4E7-6AF085F68CF8', '/Lotus/Powersuits/Saryn/WeaponPoisonAbilityCard', 'WeaponPoisonAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D09F3AF9-EE66-40CC-BA3F-A23029F873E6', '21D97FDB-9C0C-4D4E-B392-C2404134EE89', '/Lotus/Types/Recipes/WarframeRecipes/SarynChassisComponent', 'SarynChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('8BA8F813-F194-4140-BF33-6D073ACF3E6E', 'D686BF47-8D2B-4383-84E8-FFD90C45A7B4', '/Lotus/Types/Recipes/WarframeRecipes/SarynHelmetComponent', 'SarynHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('05A17F10-89D1-4A1C-8733-BCD1323A52A0', '35693BC7-20DD-4FC4-A90C-903633A7A912', '/Lotus/Types/Recipes/WarframeRecipes/SarynSystemsComponent', 'SarynSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D5085592-5CD1-4B64-9CE3-EF697277845F', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/Trinity', 'Trinity', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('5EB3B3E6-D748-4BEA-AD58-A3510BED3FDA', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/BlessingAbilityCard', 'BlessingAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FA6254A2-A46A-4E62-8A63-47B00FEEA7ED', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/EnergyVampireAbilityCard', 'EnergyVampireAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('9D715276-B3E7-4A5B-9ACD-77B3D76E84EF', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/LinkAbilityCard', 'LinkAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('103E75C4-2B60-43DC-AE94-71C51C53EF67', '5F5B5C36-68F9-48E6-B686-EF55465D611F', '/Lotus/Powersuits/Trinity/WellOfLifeAbilityCard', 'WellOfLifeAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('A921017A-A265-4762-9158-6E9DA7101E8E', '718A42A0-73B5-4193-BAC4-E043AF3A7638', '/Lotus/Types/Recipes/WarframeRecipes/TrinityChassisComponent', 'TrinityChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('2AA72D5A-FFF6-4EC0-9C0A-A438F8A7A3F3', '08DD305E-0FD1-4868-86CB-AAF3972C7BB7', '/Lotus/Types/Recipes/WarframeRecipes/TrinityHelmetComponent', 'TrinityHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('95393FA3-B7ED-4377-ADEE-C78FC516F4AD', 'EF63036D-09B5-45A2-805F-DB3510CF0AD7', '/Lotus/Types/Recipes/WarframeRecipes/TrinitySystemsComponent', 'TrinitySystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('9CDFEBE6-2637-4DE8-857A-FFFB89FDAB60', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/Volt', 'Volt', 3, 1, 1, 101, 0, 0, 4, 4, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('1A0C27B9-2260-4426-B6CA-640F4AC2397B', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/OverloadAbilityCard', 'OverloadAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('4F925488-E0B9-4F4B-BD01-5533FE6158C8', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/ShieldAbilityCard', 'ShieldAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('7335F88B-1D6E-433A-AFBA-FC795545C914', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/ShockAbilityCard', 'ShockAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C0CAFBB9-A3FD-496B-832F-A3FA66267AC1', 'DEE09227-5210-4E81-9A62-D6C022B164C5', '/Lotus/Powersuits/Volt/SpeedAbilityCard', 'SpeedAbilityCard', 4, 1, 1, 0, 0, 0, 0, 0, 'lvl=0|', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('4700039B-E0A2-41E2-8BAE-BC411E5E0C33', '24DEA1F6-980C-4BF2-897B-F9D7D70D897E', '/Lotus/Types/Recipes/WarframeRecipes/VOLTChassisComponent', 'VOLTChassisComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('76B31BDD-546A-446E-9481-1ED244A2A04E', '916EAC52-6C86-4E83-9333-E0691435278C', '/Lotus/Types/Recipes/WarframeRecipes/VOLTHelmetComponent', 'VOLTHelmetComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('631B5EBA-C0BC-41D7-9265-E38CFE09858A', '3E2DCF37-B89A-4ED4-8C28-3172E5EA6FE7', '/Lotus/Types/Recipes/WarframeRecipes/VOLTSystemsComponent', 'VOLTSystemsComponent', 13, 1, 0, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('5239230D-86BD-4309-9145-82792AD43DF8', 'E893D687-72EA-4112-A056-EC6A118D7EC4', '/Lotus/Weapons/Tenno/Akimbo/AkimboAutoPistols', 'AkimboAutoPistols', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('7CF9A854-D11B-420D-958B-FFFA9DD55DA6', 'FDB40FA5-EA03-4D73-9CA0-EF4A1CFAE746', '/Lotus/Weapons/Tenno/Akimbo/AkimboBolto', 'AkimboBolto', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CAB2F767-BB58-4B5D-9109-435FD71F33DB', '53A61315-A390-4F64-B616-EA35597EF245', '/Lotus/Weapons/Tenno/Melee/Axe/AxeWeapon', 'AxeWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('4C8197BE-052F-4A47-A6BD-C60C80CD6B19', '3B2CEBAB-6910-4595-8457-2862BFBDE60C', '/Lotus/Weapons/Tenno/Pistol/CrossBow', 'CrossBow', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('1108D70B-F8F2-4089-BD26-ED9263971B0E', '5DB68574-6039-4CA6-8459-5DB17B29414D', '/Lotus/Weapons/Tenno/Rifle/BoltoRifle', 'BoltoRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('DD27CC23-2C83-4F66-B425-16E5EC260396', '464B3060-6444-445E-AF6B-F682D04C4333', '/Lotus/Weapons/Tenno/Melee/Dagger/CeramicDagger', 'CeramicDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('308D4EB8-5AB1-4B11-ABED-1794E5AE425A', '250ED2DF-ED03-4EE1-A640-49198195A199', '/Lotus/Weapons/Tenno/Melee/Dagger/DarkDagger', 'DarkDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E521D04A-302D-4A30-AF5C-8031DB524588', '70568EBA-C7CA-482C-B4A7-2392DF606B88', '/Lotus/Weapons/Tenno/Melee/Axe/DualAxeWeapon', 'DualAxeWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C6BD6586-336C-4F74-9539-8B1B4D31D2FA', '96F3472F-C6F7-4674-800B-0F6EBB8C34B1', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualDagger', 'DualDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('F8B0D5E3-FD11-4EE1-9293-C6663DE72DC2', 'A47EBF70-2861-4003-889C-62332FD8D929', '/Lotus/Weapons/Tenno/Melee/DualDagger/DualEtherDagger', 'DualEtherDagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('14F9E9BA-93D0-4E06-BC81-E673172F3D3A', '4E121F5F-B29C-43DB-8FC1-69CCD724574B', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualEtherSword', 'DualEtherSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('DA69B44D-27B7-414B-881D-E3CE58816B36', '87EE4503-5D29-400F-BA36-1011E85E29AC', '/Lotus/Weapons/Tenno/Melee/DualShortSword/DualHeatSwords', 'DualHeatSwords', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('D3C62AD7-3AA6-420A-AB8A-370F41B859FE', '7E8A0FF4-6852-4889-B38D-7235F0C0C910', '/Lotus/Weapons/Tenno/Melee/Gauntlet/Gauntlet', 'Gauntlet', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('BB21A723-B7CE-4826-9A2E-484BE4447E4E', '990F7DCD-363C-4FED-A682-A4A083288E30', '/Lotus/Weapons/Tenno/Melee/Glaives/LightGlaive/LightGlaiveWeapon', 'LightGlaiveWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('DE02F693-BE85-4696-994F-4DED529260A6', 'B2126F16-A977-48C1-A26A-38B2BEA1DBD9', '/Lotus/Weapons/Tenno/Melee/GreatSword/GreatSword', 'GreatSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('87043C5D-008F-45CB-B1B4-280B5B90BB8E', '8297E185-ECF1-4A16-B306-163DD67B8D8F', '/Lotus/Weapons/Grineer/GrineerPistol/GrineerLightPistol', 'GrineerLightPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('C9DDF44A-EF7D-4B44-8817-E3441014A909', '64723CB0-740D-4F2C-9064-88072EDE5447', '/Lotus/Weapons/Grineer/LongGuns/GrineerAssaultRifle/GrnAssaultRifle', 'GrnAssaultRifle', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('51D7973D-9DD8-4050-9132-A9DE26879F5E', 'CBABABFB-97CB-48DB-B59E-811AC433694C', '/Lotus/Weapons/Grineer/GrineerPistol/GrnHeavyPistol', 'GrnHeavyPistol', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('31FE397E-D7CD-462F-B0D2-CE533AE9B7F9', '53005AE7-4062-4278-A930-BD21BFDA91B3', '/Lotus/Weapons/Tenno/Melee/Staff/GrnStaff', 'GrnStaff', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('003646F8-A381-4946-9396-2FAB2757F9CA', 'A76E800D-0855-47B8-9A00-FFE733A98D3C', '/Lotus/Weapons/Tenno/Melee/Hammer/HammerWeapon', 'HammerWeapon', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('CD42542D-C70E-4CCA-9D33-2F8568CD59EE', '9BDD5D06-30C3-4825-8CAD-DD5B87256444', '/Lotus/Weapons/Tenno/Melee/Dagger/Dagger', 'Dagger', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('36C21D57-A8CD-4000-91FB-24A9404B771C', 'D71EA677-7F69-4123-BA56-229AF3381AD3', '/Lotus/Weapons/Tenno/Melee/Swords/HeatSword/HeatLongSword', 'HeatLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E67D3BA5-BB2B-400B-916D-FAF413FC23D2', '01A86450-0713-4CC9-B3D7-1015E8F33210', '/Lotus/Weapons/Tenno/Bows/HuntingBow', 'HuntingBow', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E958A2B8-4E8B-438B-BC65-17039D9C24D3', 'F954D25F-97FF-4354-A8B6-8D4621B9F5C3', '/Lotus/Weapons/Tenno/Melee/Swords/JawSword/JawLongSword', 'JawLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('411339CD-FCE0-43C0-A22D-9BC4B5640C61', 'FE658793-D2C4-4D0D-95FA-F079E99D677F', '/Lotus/Weapons/Infested/Melee/Swords/Mire/MireSword', 'MireSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FCDDEB9F-8000-42F8-A4B8-2D8C4B3A9319', '6662BAC1-0144-4D94-89D4-823C44A550A9', '/Lotus/Weapons/Tenno/Melee/Swords/PangolinSword/PangolinLongSword', 'PangolinLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('8071ECCF-23BA-450F-890E-B2F860C76B5D', '0C490485-4444-44BE-BEE9-A821F8BB769A', '/Lotus/Weapons/Tenno/Melee/Swords/PlasmaSword/PlasmaLongSword', 'PlasmaLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('62595B7D-4B51-4C3B-A397-0AE9868C8CFE', 'A0E5F2D9-4C56-4260-AF56-529F46BC32AD', '/Lotus/Weapons/Tenno/Shotgun/QuadShotgun', 'QuadShotgun', 1, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('FC406A85-8C0B-41E6-BC8E-6B6859219DB1', 'FB86D76A-5490-49CD-8F97-CEF030F74D22', '/Lotus/Weapons/Tenno/Akimbo/AkimboViperPistols', 'AkimboViperPistols', 0, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('0C216E6A-ECF9-4FC4-9783-D5C2C79BA7B8', 'B83279F4-21B7-449B-9710-3540FB659B0A', '/Lotus/Upgrades/Skins/Axe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('6AF91AC3-A89C-4676-A596-EC3858DBE283', 'A59D44C7-F394-4D80-8C40-02905640FD3D', '/Lotus/Upgrades/Skins/DualAxe/DaggerAxe', 'DaggerAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('39433279-4F37-4D24-A932-15ED151E1DA7', '70F30D72-4787-435C-87A4-0D44177EE191', '/Lotus/Upgrades/Skins/HeavyAxe/GrnAxe', 'GrnAxe', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('6D22335E-A45F-4C46-A6A9-AE7B36B5B0A6', '28721969-C80A-415C-9F52-419536022FF0', '/Lotus/Upgrades/Skins/Hammer/GrnHammer', 'GrnHammer', 6, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('2E526A4C-C05B-4078-97FC-4D618A3C9371', 'E75A0AE8-9AB6-43E7-B2B4-00930C1A9147', '/Lotus/Weapons/Tenno/Melee/CronusSword/CronusLongSword', 'CronusLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('E1140656-07A6-4618-ADD9-C2D8C91A9F9A', '875BAF15-BB59-49C5-9782-3795274A64E0', '/Lotus/Weapons/Tenno/Melee/Swords/DarkSword/DarkLongSword', 'DarkLongSword', 5, 1, 1, 101, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');
INSERT INTO WarframeItemComponents
(Id, WarframeItemId, ItemType, ItemName, InternalInventoryItemType, Count, IsUniqueItem, UpgradeVer, XP, UnlockLevel, ExtraCapacity, ExtraRemaining, UpgradeFingerprint, Charge, CreationTimestamp, LastModificationTimestamp)
VALUES('7546AE4C-957E-469D-9021-FD757CFFCA8D', '872EF610-CAD8-41D5-ADC9-5B734E7426BE', '/Lotus/Upgrades/Modules/Crafted/IncendiaryRifleMod', 'IncendiaryRifleMod', 4, 1, 1, 0, 0, 0, 0, 0, '', 0, '2025-07-01 00:00:00.000000-05:00', '2025-07-01 00:00:00.000000-05:00');







                                    ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
