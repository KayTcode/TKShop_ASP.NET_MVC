using System;
using System.Collections.Generic;

namespace TKShop.Models
{
    public partial class Return
    {
        public string ReturnId { get; set; } = null!;
        public string? OrderId { get; set; }
        public string? CustomerId { get; set; }
        public string? ReturnReason { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? ReturnStatus { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Order? Order { get; set; }
    }
}
