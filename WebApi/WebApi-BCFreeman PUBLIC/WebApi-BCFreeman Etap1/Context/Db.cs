using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace ManyToManyMVC.Context
{
    public class Db : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasIndex(p => p.Name);
            modelBuilder.Entity<Product>().HasIndex(p => p.PurchasePrice);
            modelBuilder.Entity<Product>().HasIndex(p => p.RetailPrice);

            modelBuilder.Entity<Category>().HasIndex(p => p.Name);
            modelBuilder.Entity<Category>().HasIndex(p => p.Description);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-HRI2K4I;Database=SportBC;Integrated Security=True");
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
/*
 Microsoft.EntityFrameworkCore

 Windows Authorisation
 add-migration ManyToManyRepoMVC
 update-database –verbose
 */

