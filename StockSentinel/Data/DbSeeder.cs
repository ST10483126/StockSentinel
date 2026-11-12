using System;
using System.Collections.Generic;
using StockSentinel.Models;

namespace StockSentinel.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync()
        {
            using var context = new DatabaseContext();

            // Only seed if the database is completely empty
            if (!context.StockItems.Any())
            {
                // 1. Create Categories
                var catDairy = new Category { Name = "Dairy & Eggs" };
                var catBakery = new Category { Name = "Bakery" };
                var catBeverages = new Category { Name = "Beverages" };

                context.Categories.AddRange(catDairy, catBakery, catBeverages);
                await context.SaveChangesAsync(); // Save to generate their IDs

                // 2. Create Stock Items
                var items = new List<StockItem>
                {
                    new StockItem
                    {
                        Name = "Clover Fresh Milk 2L",
                        Quantity = 15,
                        CostPrice = 32.50m,
                        ExpiryDate = DateTime.Now.AddDays(5), // Expiring soon!
                        CategoryId = catDairy.Id
                    },
                    new StockItem
                    {
                        Name = "Albany Superior White Bread",
                        Quantity = 20,
                        CostPrice = 18.99m,
                        ExpiryDate = DateTime.Now.AddDays(3), // Expiring soon!
                        CategoryId = catBakery.Id
                    },
                    new StockItem
                    {
                        Name = "Coca-Cola 2L",
                        Quantity = 50,
                        CostPrice = 22.00m,
                        ExpiryDate = DateTime.Now.AddMonths(6), // Safe
                        CategoryId = catBeverages.Id
                    },
                    new StockItem
                    {
                        Name = "Simba Chips (Assorted)",
                        Quantity = 100,
                        CostPrice = 12.50m,
                        ExpiryDate = DateTime.Now.AddMonths(3), // Safe
                        CategoryId = catBakery.Id
                    },
                    new StockItem
                    {
                        Name = "Amasi 1L",
                        Quantity = 5,
                        CostPrice = 25.00m,
                        ExpiryDate = DateTime.Now.AddDays(15), // Safe for now
                        CategoryId = catDairy.Id
                    }
                };

                context.StockItems.AddRange(items);
                await context.SaveChangesAsync();
            }
        }
    }
}