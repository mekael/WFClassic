using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBinsToWarframeItemComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AddInventoryBin",
                table: "WarframeItemComponents",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "InventoryBinTypeToAdd",
                table: "WarframeItemComponents",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBinsToAdd",
                table: "WarframeItemComponents",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddInventoryBin",
                table: "WarframeItemComponents");

            migrationBuilder.DropColumn(
                name: "InventoryBinTypeToAdd",
                table: "WarframeItemComponents");

            migrationBuilder.DropColumn(
                name: "NumberOfBinsToAdd",
                table: "WarframeItemComponents");
        }
    }
}