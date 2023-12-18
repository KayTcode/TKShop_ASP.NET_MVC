using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Brand
    {
        public string BrandId { get; set; } = null!;
        public string? BrandName { get; set; }
        public string? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
