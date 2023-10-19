using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Basic_Web_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _environment;

        public IndexModel(ILogger<IndexModel> logger,
            IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostDownloadFile()
        {
            const string testFile = "test.txt";
            string rootPath = _environment.WebRootPath + "\\tempfiles\\";

            string filePath = System.IO.Path.Combine(rootPath, testFile);

            return PhysicalFile(filePath, "text/plain", testFile);
        }
    }
}