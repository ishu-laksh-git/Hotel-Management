using Microsoft.EntityFrameworkCore;

namespace BigBangAssesment.Models.DTO
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
