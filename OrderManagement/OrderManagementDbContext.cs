using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Design;

namespace OrderManagement
{
    public class OrderManagementDbContext : DbContext
    {

        protected override void OnConfiguring
           (DbContextOptionsBuilder optionsBuilder)
        {
            {
                optionsBuilder
                    .UseSqlServer(@"Server=localhost;Database=OrderManagementB;
                    Trusted_Connection = True; ConnectRetryCount = 0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Basket>().HasOne(b => b.Customer);
            modelBuilder.Entity<Basket>().HasMany(b => b.Cart);
            modelBuilder.Entity<Product>().HasMany(p => p.Carts);
            modelBuilder.Entity<Customer>().HasMany(c => c.Baskets);

        }
    }
}
