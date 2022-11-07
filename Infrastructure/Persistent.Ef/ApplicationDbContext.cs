using Domain.UserAgg;
using System.Data.Entity;

namespace Infrastructure.Persistent.Ef
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<User> Users { set; get; }
    }

}