using Microsoft.EntityFrameworkCore;
using Furever.Entities.Models;

namespace Furever.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        // Create Database Tables Here
        public DbSet<Animal> Animals { get; set; }




        // Ignore this part
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
