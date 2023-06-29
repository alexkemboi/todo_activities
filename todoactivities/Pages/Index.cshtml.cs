using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.Extensions.Logging;

namespace todoactivities.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(string activityInput, string descriptionInput)
        {
            _logger.LogInformation("Activity: " + activityInput);
            _logger.LogInformation("Description: " + descriptionInput);

            // Additional processing logic

            return Partial("_SuccessMessage"); // Return a partial view indicating successful form submission

        }
    }
}