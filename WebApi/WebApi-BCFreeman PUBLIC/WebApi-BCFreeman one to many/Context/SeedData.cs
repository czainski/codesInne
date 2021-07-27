using Microsoft.Extensions.DependencyInjection;
using SportsStore.Models;
using System;

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
                context.Categories.AddRange(new Category[] {
                new Category {
                    Name = "Watersports",
                    Description = "Make a splash",
                    Products = new Product[] {
                        new Product {
                            Name = "Kayak", Description = "A boat for one person",
                            PurchasePrice = 200, RetailPrice = 275
                        },
                        new Product {
                            Name = "Lifejacket",
                            Description = "Protective and fashionable",
                            PurchasePrice = 40, RetailPrice = 48.95m
                        },
                    }
                },
                new Category {
                    Name = "Soccer",
                    Description = "The World's Favorite Game",
                    Products = new Product[] {
                        new Product {
                            Name = "Soccer Ball",
                            Description = "FIFA-approved size and weight",
                            PurchasePrice = 18, RetailPrice = 19.50m
                        },
                        new Product {
                            Name = "Corner Flags", Description
                                = "Give your playing field a professional touch",
                            PurchasePrice = 32.50m, RetailPrice = 34.95m
                        },
                        new Product {
                            Name = "Stadium",
                            Description = "Flat-packed 35,000-seat stadium",
                            PurchasePrice = 75000,  RetailPrice = 79500
                        }
                    }
                },
                new Category {
                    Name = "Chess",
                    Description = "The Thinky Game",
                    Products = new Product[] {
                        new Product {
                            Name = "Thinking Cap",
                            Description = "Improve brain efficiency by 75%",
                            PurchasePrice = 10, RetailPrice = 16
                        },
                        new Product {
                            Name = "Unsteady Chair", Description
                                = "Secretly give your opponent a disadvantage",
                            PurchasePrice = 28, RetailPrice = 29.95m
                        },
                        new Product {
                            Name = "Human Chess Board",
                            Description = "A fun game for the family",
                            PurchasePrice = 68.50m, RetailPrice = 75
                        },
                        new Product {
                            Name = "Bling-Bling King",
                            Description = "Gold-plated, diamond-studded King",
                            PurchasePrice = 800, RetailPrice = 1200
                        }
                    }
                }
            });
            context.SaveChanges();
        }
    }
}
