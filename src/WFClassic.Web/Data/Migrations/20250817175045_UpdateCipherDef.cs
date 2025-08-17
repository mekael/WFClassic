using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCipherDef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

update WarframeItemComponents 
set charge =4 ,
count = 4,
IsUniqueItem = 0
where Id ='654D7E9D-46A0-43D2-857A-AB79342D01D2'
and ItemType ='/Lotus/Types/Restoratives/Cipher';

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
