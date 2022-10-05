using DemoTallerCF.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoTallerCF.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<ProductEntity> ProductEntity { get; set; }
    }
}
