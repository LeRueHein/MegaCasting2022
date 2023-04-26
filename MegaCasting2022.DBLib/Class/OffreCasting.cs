using System;
using System.Collections.Generic;
using System.Linq;

namespace MegaCasting2022.DBLib.Class
{
    public partial class OffreCasting
    {
        public OffreCasting()
        {
            IdentifiantOffreCastings = new HashSet<Civilite>();
            IdentifiantOffreCastingsNavigation = new HashSet<Metier>();
        }

        public int? Identifiant { get; set; }
        public string Libel { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public DateTime ParutionDateTime { get; set; }
        public DateTime OffreDateStart { get; set; }
        public DateTime OffreDateEnd { get; set; }
        public string Localisation { get; set; } = null!;
        public int? IdentifiantClient { get; set; }
        public int? IdentifiantTypeContrat { get; set; }
        public bool? Sponso { get; set; }
        public string? Nivurgence { get; set; }

        public virtual Client IdentifiantClientNavigation { get; set; } = null!;
        public virtual TypeContrat IdentifiantTypeContratNavigation { get; set; } = null!;

        public virtual ICollection<Civilite> IdentifiantOffreCastings { get; set; }
        public virtual ICollection<Metier> IdentifiantOffreCastingsNavigation { get; set; }

        public String Metiers { get { return String.Join(",", this.IdentifiantOffreCastingsNavigation.Select<Metier, String>(x => x.Libel)); } }
    }
}
