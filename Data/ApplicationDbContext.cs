using Microsoft.EntityFrameworkCore;
using MyMvcRepositoryProject.Models;

namespace MyMvcRepositoryProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
