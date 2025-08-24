using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeathMarkTrackingColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeathMarks",
                table: "Players",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeathMarks",
                table: "Players");
        }
    }
}
