using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Civilite
    {
        public Civilite()
        {
            IdentifiantCivilites = new HashSet<OffreCasting>();
        }

        public int Identifiant { get; set; }
        public string LibelShort { get; set; } = null!;
        public string LibelLong { get; set; } = null!;

        public virtual ICollection<OffreCasting> IdentifiantCivilites { get; set; }
    }
}
