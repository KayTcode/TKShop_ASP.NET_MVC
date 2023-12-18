using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Coupon
    {
        public string CouponId { get; set; } = null!;
        public string? CouponCode { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
