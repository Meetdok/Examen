using System;
using System.Collections.Generic;

namespace Examen.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Method { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
