using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMarketPackageItemDefinitionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketPackageItemDefintions");

            migrationBuilder.AddColumn<string>(
                name: "WarframeItemType",
                table: "MarketPackageDefinitions",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarframeItemType",
                table: "MarketPackageDefinitions");

            migrationBuilder.CreateTable(
                name: "MarketPackageItemDefintions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarketPackageDefinitionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AddInventoryBin = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanBeAddedRepeatedly = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ExtraCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    InternalInventoryItemType = table.Column<int>(type: "INTEGER", nullable: false),
                    InventoryBinTypeToAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    IsUniqueItem = table.Column<bool>(type: "INTEGER", nullable: false),
                    ItemCountToBeAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    ItemType = table.Column<string>(type: "TEXT", nullable: true),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    NumberOfBinsToAdd = table.Column<int>(type: "INTEGER", nullable: false),
                    UnlockLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    UpgradeFingerprint = table.Column<string>(type: "TEXT", nullable: true),
                    UpgradeVer = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPackageItemDefintions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketPackageItemDefintions_MarketPackageDefinitions_MarketPackageDefinitionId",
                        column: x => x.MarketPackageDefinitionId,
                        principalTable: "MarketPackageDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketPackageItemDefintions_MarketPackageDefinitionId",
                table: "MarketPackageItemDefintions",
                column: "MarketPackageDefinitionId");
        }
    }
}