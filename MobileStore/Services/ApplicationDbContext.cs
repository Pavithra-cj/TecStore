using Microsoft.EntityFrameworkCore;
using MobileStore.Models;

namespace MobileStore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
