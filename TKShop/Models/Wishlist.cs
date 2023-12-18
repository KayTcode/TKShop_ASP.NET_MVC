using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Wishlist
    {
        public string WishlistId { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? ProductId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Product? Product { get; set; }
    }
}
