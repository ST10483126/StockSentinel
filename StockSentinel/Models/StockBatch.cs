using System;
using System.Collections.Generic;
using System.Text;

namespace StockSentinel.Models
{
    public class StockBatch
    {
        public int Id { get; set; }
        public int StockItemId { get; set; }
        public StockItem? StockItem { get; set; } //Navigation property for EF Core 
        public string BatchNumber { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;
        public int QuantityReceived { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}
  