using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
            Wishlists = new HashSet<Wishlist>();
        }

        public string ProductId { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityAvailable { get; set; }
        public string? CategoryId { get; set; }
        public byte[]? Image { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
