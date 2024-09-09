using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string OperatingSystemNameAndVersion { get; set; }
    public OperatingSystem OperatingSystem { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        OperatingSystemNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

        OperatingSystem = new OperatingSystem(System.Environment.OSVersion.Platform, new Version());

    }
}
