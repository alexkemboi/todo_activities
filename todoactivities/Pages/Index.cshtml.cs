using Microsoft.AspNetCore.Mvc.RazorPages;

namespace todoactivities.Pages
{
    public class IndexModel : PageModel
    {   public string activityName { get; set; }
        public string activityDescription { get; set; }
        public string activityDate { get; set; }
        public string activityTime { get; set; }
        public int counter { get; set; }
        

        public void AddActivity(object sender, EventArgs e)
        {
            activityName = Request.Form["acivityNameInput"];
            activityDescription = Request.Form["activityDescriptionInput"];
            activityDate = Request.Form["activityDateInput"];
            activityTime = Request.Form["acitvityTimeInput"];
            Console.WriteLine(activityName);
            Console.WriteLine(activityDescription);
            Console.WriteLine(activityDate);
            Console.WriteLine(activityTime);
        }
  
    }
}