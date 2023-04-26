using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Client
    {
        public Client()
        {
            OffreCastings = new HashSet<OffreCasting>();
        }

        public int Identifiant { get; set; }
        public string Nom { get; set; } = null!;
        public string Ville { get; set; } = null!;
        public int Telephone { get; set; }
        public string Email { get; set; } = null!;
        public string? Login { get; set; } = null!;
        public string? Password { get; set; } = null!;

        public virtual ICollection<OffreCasting> OffreCastings { get; set; }
    }
}
