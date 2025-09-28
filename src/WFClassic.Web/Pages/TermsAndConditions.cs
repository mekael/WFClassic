using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WFClassic.Web.Pages;

public class TermsAndConditionsModel : PageModel
{
    private readonly ILogger<TermsAndConditionsModel> _logger;

    public TermsAndConditionsModel(ILogger<TermsAndConditionsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

