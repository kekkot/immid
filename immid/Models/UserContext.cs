using Microsoft.EntityFrameworkCore;
namespace immid.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
           : base(options)
        {
            //При отсутствии бд создает ее
            Database.EnsureCreated();
        }
    }
}
