using Eterna.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Slider> Slider { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

    }
}
