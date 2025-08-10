using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFClassic.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColorFlavourItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"



update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItem' ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItem'
where Id = '61E2389F-C0CD-4332-A30D-B91D8E99FFC0' ;

update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemB' ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemB'
where Id = 'C078E750-5612-4792-8811-E61EC1B28A85' ;

update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemC'  ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemC'
where Id = '2803120B-14F9-4265-97C3-4047440B5332' ;

update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerFireItemA'  ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerFireItemA'
where Id = 'CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9' ;

update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA'  ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA'
where Id = '16B2D787-17D3-439D-B5C9-9CD774570B94' ;

update MarketPackageDefinitions 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/NinjaColourPickerItem' ,
WarframeItemType='/Lotus/Types/StoreItems/SuitCustomizations/NinjaColourPickerItem'
where Id = 'ADC5F7AA-947E-4DE4-860F-C91BC511BFB3' ;



update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItem' 
where Id = '61E2389F-C0CD-4332-A30D-B91D8E99FFC0' ;

update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemB' 
where Id = 'C078E750-5612-4792-8811-E61EC1B28A85' ;

update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemC'  
where Id = '2803120B-14F9-4265-97C3-4047440B5332' ;

update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerFireItemA' 
where Id = 'CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9' ;
update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA' 
where Id = '16B2D787-17D3-439D-B5C9-9CD774570B94' ;
update WarframeItems 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/NinjaColourPickerItem'
where Id = 'ADC5F7AA-947E-4DE4-860F-C91BC511BFB3' ;



update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItem' 
where WarframeItemId = '61E2389F-C0CD-4332-A30D-B91D8E99FFC0' ;

update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemB' 
where WarframeItemId = 'C078E750-5612-4792-8811-E61EC1B28A85' ;

update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerItemC'  
where WarframeItemId = '2803120B-14F9-4265-97C3-4047440B5332' ;

update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerFireItemA' 
where WarframeItemId = 'CB05F0F0-67D1-4ED2-B9AF-447A27E5B2F9' ;

update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/ColourPickerIceItemA' 
where WarframeItemId = '16B2D787-17D3-439D-B5C9-9CD774570B94' ;

update WarframeItemComponents 
set ItemType='/Lotus/Types/StoreItems/SuitCustomizations/NinjaColourPickerItem'
where WarframeItemId = 'ADC5F7AA-947E-4DE4-860F-C91BC511BFB3' ;


");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
