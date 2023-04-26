using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class DomaineMetier
    {
        public DomaineMetier()
        {
            Metiers = new HashSet<Metier>();
        }

        public int Identifiant { get; set; }
        public string Libel { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Metier> Metiers { get; set; }
    }
}
