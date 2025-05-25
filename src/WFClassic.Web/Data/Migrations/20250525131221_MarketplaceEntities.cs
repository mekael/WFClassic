using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class MarketplaceEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketPackageDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", nullable: true),
                    CanBePurchasedMultipleTimes = table.Column<bool>(type: "INTEGER", nullable: false),
                    CostInCredits = table.Column<int>(type: "INTEGER", nullable: false),
                    CostInPlat = table.Column<int>(type: "INTEGER", nullable: false),
                    CanBePurchasedWithPlat = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanBePurchasedWithCredits = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPackageDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketPackageItemDefintions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarketPackageDefinitionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InternalInventoryItemType = table.Column<int>(type: "INTEGER", nullable: false),
                    IsUniqueItem = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanBeAddedRepeatedly = table.Column<bool>(type: "INTEGER", nullable: false),
                    ItemCountToBeAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemType = table.Column<string>(type: "TEXT", nullable: true),
                    ItemName = table.Column<string>(type: "TEXT", nullable: true),
                    UpgradeVer = table.Column<int>(type: "INTEGER", nullable: false),
                    UnlockLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    ExtraCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    UpgradeFingerprint = table.Column<string>(type: "TEXT", nullable: true),
                    AddInventoryBin = table.Column<bool>(type: "INTEGER", nullable: false),
                    InventoryBinTypeToAdd = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberOfBinsToAdd = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "PlayerPurchaseRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlayerID = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarketPackageDefinitionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PurchaseDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    PurchaseAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrencyType = table.Column<int>(type: "INTEGER", nullable: true),
                    CreationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    LastModificationTimestamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPurchaseRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerPurchaseRecord_MarketPackageDefinitions_MarketPackageDefinitionId",
                        column: x => x.MarketPackageDefinitionId,
                        principalTable: "MarketPackageDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPurchaseRecord_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketPackageItemDefintions_MarketPackageDefinitionId",
                table: "MarketPackageItemDefintions",
                column: "MarketPackageDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPurchaseRecord_MarketPackageDefinitionId",
                table: "PlayerPurchaseRecord",
                column: "MarketPackageDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPurchaseRecord_PlayerID",
                table: "PlayerPurchaseRecord",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketPackageItemDefintions");

            migrationBuilder.DropTable(
                name: "PlayerPurchaseRecord");

            migrationBuilder.DropTable(
                name: "MarketPackageDefinitions");
        }
    }
}
