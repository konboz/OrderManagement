using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Design;

namespace OrderManagement
{
    class OrderManagementDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BasketProduct> BasketProduct { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.Baskets)
                .HasForeignKey(b => b.Customer.CustomerId);
            modelBuilder.Entity<BasketProduct>()
                .HasKey(t => new { t.BasketId, t.ProductId });
            modelBuilder.Entity<BasketProduct>()
                .HasOne(pt => pt.Basket)
                .WithMany(p => p.BasketProducts)
                .HasForeignKey(pt => pt.BasketId);
            modelBuilder.Entity<BasketProduct>()
                .HasOne(pt => pt.Product)
                .WithMany(t => t.BasketProducts)
                .HasForeignKey(pt => pt.ProductId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string s = "Server =localhost; Database =OrderManagementNew; Integrated Security=SSPI;" +
                "Persist Security Info=False;";
            base.OnConfiguring(optionsBuilder.UseSqlServer(s));
        }
    }
}
