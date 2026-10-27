using Microsoft.EntityFrameworkCore;
using StockSentinel.Models;

namespace StockSentinel.Data
{
    public class DatabaseContext : DbContext
    {
        // These represent the tables in the SQL Server database
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StockBatch> StockBatches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {                
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StockSentinelDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StockItem>()
                .HasMany(s => s.Batches)
                .WithOne(b => b.StockItem)
                .HasForeignKey(b => b.StockItemId);
        }
    }
}