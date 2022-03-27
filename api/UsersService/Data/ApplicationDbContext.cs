using Microsoft.EntityFrameworkCore;
using UsersService.Models;

namespace UsersService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<RefreshToken>? Tokens { get; set; }
    }
}