using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixInvalidUpgradeVersions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                            update InventoryItems 
                            set UpgradeVer = 100
                            where  ( UpgradeVer = 0 or UpgradeVer <100)
                            and InternalInventoryItemType in (0,1,5,3);

                            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
