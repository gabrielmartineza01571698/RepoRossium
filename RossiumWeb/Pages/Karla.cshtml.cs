using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RossiumWeb.Pages;

public class KarlaModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public KarlaModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
