using Microsoft.EntityFrameworkCore;
using MYWebDev.Model;

namespace MYWebDev.Data
{
    public class CommentDbContext : DbContext
    {
        public DbSet<CommentModel> comments { get; set; }
        public CommentDbContext(DbContextOptions<CommentDbContext> options):base(options)
        {
            
        }
    }

}
