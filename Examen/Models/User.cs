using System;
using System.Collections.Generic;

namespace Examen.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string? FirtsName { get; set; }
        public string? LastName { get; set; }
        public string? PatronomycName { get; set; }
        public string? Nick { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }

        public string? Password { get; set; }
        public string? Login { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
