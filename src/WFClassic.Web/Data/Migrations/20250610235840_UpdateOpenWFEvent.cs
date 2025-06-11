using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOpenWFEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    update WorldStateEventMessages 
                                    set Message = 'Check out Space Ninja Server!',
                                    Property = 'https://openwf.io/'
                                    where Id = '31DACE59-46AA-4491-B1CD-9E98147B0D08';
                                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
