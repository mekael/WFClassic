using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class BankAccountToPlayerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "BankAccounts",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_ApplicationUserId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Players_PlayerId",
                table: "BankAccounts",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Players_PlayerId",
                table: "BankAccounts");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "BankAccounts",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_PlayerId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_AspNetUsers_ApplicationUserId",
                table: "BankAccounts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}