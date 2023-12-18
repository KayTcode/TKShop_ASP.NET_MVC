using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Address
    {
        public string AddressId { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? RecipientName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? PostalCode { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
