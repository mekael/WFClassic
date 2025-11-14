using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSentinelUpgrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
update WarframeItemComponents 
set UpgradeVer = 101
 where ItemType  in (
 '/Lotus/Types/Sentinels/SentinelPowersuits/ShadePowerSuit',
 '/Lotus/Types/Sentinels/SentinelWeapons/BurstLaserPistol',
 '/Lotus/Types/Sentinels/SentinelWeapons/LaserRifle',
 '/Lotus/Types/Sentinels/SentinelPowersuits/WyrmPowerSuit'
 );

update WarframeItemComponents 
set UnlockLevel =1 
 where Id  in (
 '9380D682-AD4A-4385-BB79-760F88608B4A',
 '1B1B0D23-ED1C-40CB-A725-48D9045CC673'
 );
");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
