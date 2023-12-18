using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Inventories = new HashSet<Inventory>();
        }

        public string SupplierId { get; set; } = null!;
        public string? SupplierName { get; set; }
        public string? ContactInfo { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
