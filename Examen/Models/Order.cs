using System;
using System.Collections.Generic;

namespace Examen.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GameId { get; set; }
        public int? PaymentMethodId { get; set; }

        public virtual Game? Game { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual User? User { get; set; }
    }
}
