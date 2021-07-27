using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using WebApi_BCFreeman.Models;

namespace ManyToManyMVC.Context
{
    public class Db : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                           .HasKey(pt => new { pt.ProductId, pt.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.ProductCategorys)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pt => pt.Category)
                .WithMany(t => t.ProductCategorys)
                .HasForeignKey(pt => pt.CategoryId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-HRI2K4I;Database=SportBC;Integrated Security=True");
        }
        public DbSet<Product>  Products   { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
/*
 Microsoft.EntityFrameworkCore

 Windows Authorisation
 add-migration ManyToManyRepoMVC
 update-database –verbose
 */

