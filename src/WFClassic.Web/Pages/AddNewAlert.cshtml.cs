using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using WFClassic.Web.Logic.AlertConfig.Add;
using WFClassic.Web.Logic.Shared;

namespace WFClassic.Web.Pages
{
    public class AddNewAlertModel : PageModel
    {


        [BindProperty]
        public AddAlertConfiguration AddAlertConfiguration { get; set; } = new AddAlertConfiguration();


        public SelectList RandomizedItemsSelectList { get; set; }
        public SelectList EnemySpecSelectList { get; set; }
        public SelectList LocationSelectList { get; set; }
        public SelectList LevelOverrideSelectList { get; set; }
        public SelectList VipSelectList { get; set; }
        public SelectList FactionSelectList { get; set; }
        public SelectList MissionTypeSelectList { get; set; }
        public SelectList ItemRewards { get; set; }
        public SelectList IconSelectList { get; set; }


        public AddNewAlertModel(WFClassicAdditionalData wfClassicAdditionalData)
        {
            this.FactionSelectList = new SelectList(wfClassicAdditionalData.Factions, "Value", "Key");
            this.MissionTypeSelectList = new SelectList(wfClassicAdditionalData.MissionTypes, "Value", "Key");
            this.IconSelectList = new SelectList(wfClassicAdditionalData.AlertIcons, "Value", "Key");
         
            this.RandomizedItemsSelectList = new SelectList(wfClassicAdditionalData.RandomizedRewards, "Value", "Key");;
            this.LocationSelectList = new SelectList(wfClassicAdditionalData.NodeDefinitions, "Node", "Description");
            this.VipSelectList = new SelectList(wfClassicAdditionalData.Vips, "Value", "Key");
            this.EnemySpecSelectList = new SelectList(wfClassicAdditionalData.EnemySpecs, "Value", "Key");
            this.ItemRewards = new SelectList(Utils.GetFlattenedListDictionary(wfClassicAdditionalData.ItemRewards), "Value", "Text");
        }


        public void OnGet()
        {

        }
    }
}
