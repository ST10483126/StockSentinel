using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StockSentinel.Models;

namespace StockSentinel.Data
{
    public class StockRepository
    {
        // CREATE / UPDATE
        public async Task SaveStockItemAsync(StockItem item)
        {
            using var context = new DatabaseContext();

            if (item.Id == 0)
            {
                // It's a new item
                await context.StockItems.AddAsync(item);
            }
            else
            {
                // It's an existing item being updated
                context.StockItems.Update(item);
            }

            await context.SaveChangesAsync();
        }

        // READ ALL
        public async Task<List<StockItem>> GetAllStockItemsAsync()
        {
            using var context = new DatabaseContext();

            // We use Include to load the related Category and Batches
            return await context.StockItems
                .Include(s => s.Category)
                .Include(s => s.Batches)
                .ToListAsync();
        }

        // READ EXPIRING SOON (LINQ Showcase)
        public async Task<List<StockItem>> GetExpiringSoonAsync(int days = 30)
        {
            using var context = new DatabaseContext();
            var targetDate = DateTime.Now.AddDays(days);

            return await context.StockItems
                .Include(s => s.Category)
                .Where(s => s.ExpiryDate <= targetDate)
                .OrderBy(s => s.ExpiryDate) // Most urgent first
                .ToListAsync();
        }

        // DELETE
        public async Task DeleteStockItemAsync(int id)
        {
            using var context = new DatabaseContext();

            var item = await context.StockItems.FindAsync(id);
            if (item != null)
            {
                context.StockItems.Remove(item);
                await context.SaveChangesAsync();
            }
        }

        // GET CATEGORIES (Useful for populating dropdowns in the UI later)
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            using var context = new DatabaseContext();
            return await context.Categories.ToListAsync();
        }
    }
}