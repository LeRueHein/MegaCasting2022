using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class TypeContrat
    {
        public TypeContrat()
        {
            OffreCastings = new HashSet<OffreCasting>();
        }

        public int Identifiant { get; set; }
        public string Libel { get; set; } = null!;

        public virtual ICollection<OffreCasting> OffreCastings { get; set; }
    }
}
