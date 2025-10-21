using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBoosterCosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                            update MarketPackageDefinitions  
                            set 
                                CanBePurchasedWithPlat=1,
                                CostInPlat = 40,
                                CostInCredits = 0
                            where 
                                ItemType  in(
                                            '/Lotus/Types/Boosters/AffinityBooster',
                                            '/Lotus/Types/Boosters/CreditBooster',
                                            '/Lotus/Types/Boosters/ReviveBooster'
                                            );

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
