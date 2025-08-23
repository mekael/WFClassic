using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using WFClassic.Web.Data.Models;
using WFClassic.Web.Logic.Sys.PlayerData;

namespace WFClassic.Web.Areas.Identity.Pages.Account.Manage
{
    public class GetPlayerDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<GetPlayerDataModel> _logger;
        private readonly DownloadPlayerDataHandler _downloadPlayerDataHandler;

        public GetPlayerDataModel(
            UserManager<ApplicationUser> userManager,
            ILogger<GetPlayerDataModel> logger,
            DownloadPlayerDataHandler downloadPlayerDataHandler)
        {
            _userManager = userManager;
            _logger = logger;
            _downloadPlayerDataHandler = downloadPlayerDataHandler;
        }
        /*
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("User with ID '{UserId}' asked for their personal data.", _userManager.GetUserId(User));

            // Only include personal data for download
            var personalData = new Dictionary<string, string>();
            var personalDataProps = typeof(ApplicationUser).GetProperties().Where(
                            prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));
            foreach (var p in personalDataProps)
            {
                personalData.Add(p.Name, p.GetValue(user)?.ToString() ?? "null");
            }

            var logins = await _userManager.GetLoginsAsync(user);
            foreach (var l in logins)
            {
                personalData.Add($"{l.LoginProvider} external login provider key", l.ProviderKey);
            }

            Response.Headers.Add("Content-Disposition", "attachment; filename=PersonalData.json");
            return new FileContentResult(JsonSerializer.SerializeToUtf8Bytes(personalData), "application/json");
        }
        */

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("User with ID '{UserId}' asked for their personal data.", _userManager.GetUserId(User));

            var result = _downloadPlayerDataHandler.Handle(new DownloadPlayerData() { ApplicationUserId = user.Id });
            if (result.DownloadPlayerDataResultStatus == DownloadPlayerDataResultStatus.ValidationErrors)
            {
                return BadRequest();
            }
            else if (result.DownloadPlayerDataResultStatus == DownloadPlayerDataResultStatus.ServerError)
            {
                return StatusCode(500);
            }


            Response.Headers.Add($"Content-Disposition", $"attachment; filename={result.FileName}");
            return new FileContentResult(result.JsonFile, "application/json");
        }

    }
}