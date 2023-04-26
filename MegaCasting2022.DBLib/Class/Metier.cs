using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Metier
    {
        public Metier()
        {
            IdentifiantMetiers = new HashSet<OffreCasting>();
        }

        public int? Identifiant { get; set; }
        public string Libel { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int IdentifiantDomaineMetier { get; set; }

        public virtual DomaineMetier IdentifiantDomaineMetierNavigation { get; set; } = null!;

        public virtual ICollection<OffreCasting> IdentifiantMetiers { get; set; }
    }
}
