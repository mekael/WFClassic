using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLoginStreakFixTrackingIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginTrackingItem_AspNetUsers_ApplicationUserId",
                table: "LoginTrackingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginTrackingItem",
                table: "LoginTrackingItem");

            migrationBuilder.RenameTable(
                name: "LoginTrackingItem",
                newName: "LoginTrackingItems");

            migrationBuilder.RenameIndex(
                name: "IX_LoginTrackingItem_ApplicationUserId",
                table: "LoginTrackingItems",
                newName: "IX_LoginTrackingItems_ApplicationUserId");

            migrationBuilder.AddColumn<int>(
                name: "LoginStreak",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumberOfDaysLoginCount",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginTrackingItems",
                table: "LoginTrackingItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginTrackingItems_AspNetUsers_ApplicationUserId",
                table: "LoginTrackingItems",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginTrackingItems_AspNetUsers_ApplicationUserId",
                table: "LoginTrackingItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoginTrackingItems",
                table: "LoginTrackingItems");

            migrationBuilder.DropColumn(
                name: "LoginStreak",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalNumberOfDaysLoginCount",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "LoginTrackingItems",
                newName: "LoginTrackingItem");

            migrationBuilder.RenameIndex(
                name: "IX_LoginTrackingItems_ApplicationUserId",
                table: "LoginTrackingItem",
                newName: "IX_LoginTrackingItem_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoginTrackingItem",
                table: "LoginTrackingItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginTrackingItem_AspNetUsers_ApplicationUserId",
                table: "LoginTrackingItem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}