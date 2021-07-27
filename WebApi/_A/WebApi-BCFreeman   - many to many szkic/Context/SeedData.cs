using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;
using System;
using WebApi_BCFreeman.Models;
using System.Linq;

namespace ManyToManyMVC.Context
{
    static class Database
    {
        //Database.Delete();
        static public void Delete()
        {
            Console.WriteLine(nameof(Delete) + " database!");
            using (var context = new Db())
            {
                context.Database.EnsureDeleted();
            }
        }
        //Database.Create();
        static public void Create()
        {
            Console.WriteLine(nameof(Create) + " database!");
            using (var context = new Db())
            {
                if (context.Database.EnsureCreated())
                {
                    Console.WriteLine($"They have created  database. ");
                }
                else
                {
                    Console.WriteLine($"They have NOT created database. ");
                };
            }
        }
    }

    public static class SeedData
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        { 
            var context = serviceProvider.GetRequiredService<Db>();
            Database.Delete();
            Database.Create();
                        
            if (!context.Products.Any())
            {
                Product p1 = new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    PurchasePrice = 200,
                    RetailPrice = 275
                };
                Category c1 = new Category
                {
                    Name = "Watersports",
                    Description = "Make a splash"
                };

                Product p2 = new Product
                {
                    Name = "Corner Flags",
                    Description
                                = "Give your playing field a professional touch",
                    PurchasePrice = 32.50m,
                    RetailPrice = 34.95m
                };
                Category c2 = new Category
                {
                    Name = "Soccer",
                    Description = "The World's Favorite Game"
                };

                ProductCategory pt;
                pt = new ProductCategory();
                p1.ProductCategorys.Add(pt);
                c1.ProductCategorys.Add(pt);

                pt = new ProductCategory();
                p1.ProductCategorys.Add(pt);
                c2.ProductCategorys.Add(pt);

                pt = new ProductCategory();
                p2.ProductCategorys.Add(pt);
                c2.ProductCategorys.Add(pt);

                context.Products.Add(p1);
                context.Categories.Add(c1);
                context.Products.Add(p2);
                context.Categories.Add(c2);

                context.SaveChanges();
            }
        }
    }
}
