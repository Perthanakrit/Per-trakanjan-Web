using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYWebDev.Data;
using MYWebDev.Model;
using static System.Net.Mime.MediaTypeNames;

namespace MYWebDev.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly CommentDbContext _context;

        public List<Projects> fakeProjectDB = new List<Projects>()
        {
            
            new Projects(){Title ="HamsterGame", ImageUrl ="/HamsG/image.png", ReadmoreUrl="ReadmorInfoProject2", Dev="Unity C#"},
            new Projects(){Title ="I AM HAMSTER", ImageUrl ="image_phy_resize.png", ReadmoreUrl="ReadmoreProject3", Dev="Unity C#"},
            new Projects(){Title ="Gadget for a Parkison’s Disease Screening Household", ImageUrl ="codekathon_resize.png", ReadmoreUrl="ReadmoreProject1", Dev="Python ML"}
        };

        public IndexModel(ILogger<IndexModel> logger, CommentDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<CommentModel> Comments { get; set; }

        public void OnGet()
        {

        }
  
        public void OnPost()
        {
            CommentModel newComment = new()
            {
                Name = Request.Form["Name"],
                Comment = Request.Form["Comment"]
            };

            //DataBase
            _context.comments.Add(newComment);
            _context.SaveChanges();

            Comments = _context.comments.ToList();
        }
    }
}