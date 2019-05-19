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
                    .UseSqlServer(@"Server=localhost;Database=OrderManagement;
                    Trusted_Connection = True; ConnectRetryCount = 0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Basket>()
               .HasOne(e => e.Customer)
               .WithMany(c => c.Baskets);
        }
    }
}
