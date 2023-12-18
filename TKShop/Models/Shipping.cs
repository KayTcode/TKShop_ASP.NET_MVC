using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Shipping
    {
        public string ShippingId { get; set; } = null!;
        public string? OrderId { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string? AddressId { get; set; }
        public bool? ShippingStatus { get; set; }

        public virtual Order? Order { get; set; }
    }
}
