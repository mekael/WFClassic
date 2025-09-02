using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSlotTrackingForItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
update WarframeItemComponents 
set AddInventoryBin=1,
InventoryBinTypeToAdd = 
case when ItemType  like '/Lotus/Powersuits%' then 0
when ItemType  like '/Lotus/Weapons%' then 1
when ItemType  like '/Lotus/Types/Sentinels/SentinelPowersuits%' then 3
else 0 
end,
NumberOfBinsToAdd = case when ItemType  like '/Lotus/Powersuits%' then -1
when ItemType  like '/Lotus/Weapons%' then -1
when ItemType  like '/Lotus/Types/Sentinels/SentinelPowersuits%' then -2
else 0 
end
where id in 
(
select wic.id
from WarframeItems wi 
inner join warframeitemcomponents wic on wi.id=wic.WarframeItemId
where wi.WarframeItemLocation =0
and 
(wic.ItemType  like '/Lotus/Powersuits%'
or wic.ItemType  like '/Lotus/Weapons%'
or wic.ItemType  like '/Lotus/Types/Sentinels/SentinelPowersuits%'
)
and wic.ItemType not like '%Card'
)



");






        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
