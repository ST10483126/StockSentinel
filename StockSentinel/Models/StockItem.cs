using System;
using System.Collections.Generic;
using System.Text;

namespace StockSentinel.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Category? Category { get; set; }
        public ICollection<StockBatch> Batches { get; set; } = new List<StockBatch>();

        public decimal TotalValue => Quantity * CostPrice;

        public bool IsExpiringSoon(int days = 30)
        {
            return ExpiryDate <= DateTime.Now.AddDays(days);
        }
    }
}
