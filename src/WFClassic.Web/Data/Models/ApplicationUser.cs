using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Elfie.Extensions;

namespace WFClassic.Web.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
        public string SteamId { get; set; }
    }
}
