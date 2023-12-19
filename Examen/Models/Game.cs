using System;
using System.Collections.Generic;

namespace Examen.Models
{
    public partial class Game
    {
        public Game()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? Pegiid { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Cost { get; set; }
        public byte[]? Image { get; set; }

        public virtual Pegi? Pegi { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
