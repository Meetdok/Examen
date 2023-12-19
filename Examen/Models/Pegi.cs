using System;
using System.Collections.Generic;

namespace Examen.Models
{
    public partial class Pegi
    {
        public Pegi()
        {
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string? Age { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
