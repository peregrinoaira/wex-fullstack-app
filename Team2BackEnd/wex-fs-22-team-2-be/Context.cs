using Microsoft.EntityFrameworkCore;
using wex_fs_22_team_2_be.Models;

namespace wex_fs_22_team_2_be
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Coupon> Coupon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetails");
            modelBuilder.Entity<Report>().ToTable("Report");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Inventory>().ToTable("Inventory");
            modelBuilder.Entity<Sale>().ToTable("Sale");
            modelBuilder.Entity<Coupon>().ToTable("Coupon");
        }
    }
}