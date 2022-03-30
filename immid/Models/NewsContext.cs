using Microsoft.EntityFrameworkCore;
namespace immid.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<NewsModel> News { get; set; }
        public NewsContext(DbContextOptions<NewsContext> options)
           : base(options)
        {
            //При отсутствии бд создает ее
            Database.EnsureCreated();
        }
    }
}
