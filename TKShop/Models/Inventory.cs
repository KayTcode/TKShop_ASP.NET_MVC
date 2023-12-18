using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Inventory
    {
        public string InventoryId { get; set; } = null!;
        public string? ProductId { get; set; }
        public string? SupplierId { get; set; }
        public int? QuantityInStock { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
