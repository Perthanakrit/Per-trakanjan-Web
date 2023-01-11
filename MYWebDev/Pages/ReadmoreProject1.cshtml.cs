using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MYWebDev.Data;
using MYWebDev.Model;
using System.ComponentModel;
using System.Xml.Serialization;

namespace MYWebDev.Pages
{
    //[BindProperties(SupportsGet = true)] 
    public class ReadmoreProject1Model : PageModel
    {
        /*public string? UserName { get; set; }
        public string? OpinionText { get; set; }*/
        /*
        private readonly CommentDbContext _context;
        public ReadmoreProject1Model(CommentDbContext context)
        {
            _context = context;
        }

        public List<CommentModel> Comments { get; set; }
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
        }*/

    }
}
