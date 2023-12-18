using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Order
    {
        public Order()
        {
            Returns = new HashSet<Return>();
            Shippings = new HashSet<Shipping>();
        }

        public string OrderId { get; set; } = null!;
        public string? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? OrderStatus { get; set; }
        public string? Note { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Shipping> Shippings { get; set; }
    }
}
