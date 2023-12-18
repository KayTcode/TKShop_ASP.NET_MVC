using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            Orders = new HashSet<Order>();
            Returns = new HashSet<Return>();
            Wishlists = new HashSet<Wishlist>();
        }

        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CountryId { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Commune { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? AccountType { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
