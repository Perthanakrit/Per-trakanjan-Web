using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYWebDev.Model;
using static System.Net.Mime.MediaTypeNames;

namespace MYWebDev.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Projects> fakeProjectDB = new List<Projects>()
        {
            
            new Projects(){Title ="HamsterGame", ImageUrl ="/HamsG/image.png", ReadmoreUrl="ReadmorInfoProject2", Dev="Unity C#"},
            new Projects(){Title ="I AM HAMSTER", ImageUrl ="image_phy.png", ReadmoreUrl="ReadmoreProject3", Dev="Unity C#"},
            new Projects(){Title ="Gadget for a Parkison’s Disease Screening Household", ImageUrl ="codekathon.jpg", ReadmoreUrl="ReadmoreProject1", Dev="Python ML"}
        };
        


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}