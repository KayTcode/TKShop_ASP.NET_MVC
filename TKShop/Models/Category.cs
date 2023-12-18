using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Category
    {
        public Category()
        {
            Brands = new HashSet<Brand>();
            Products = new HashSet<Product>();
        }

        public string CategoryId { get; set; } = null!;
        public string? CategoryName { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
