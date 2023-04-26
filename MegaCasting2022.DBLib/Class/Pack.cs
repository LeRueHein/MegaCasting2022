using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class Pack
    {
        public int Identifiant { get; set; }
        public string Libel { get; set; } = null!;
        public int NombreOffre { get; set; }
        public int Tarif { get; set; }
    }
}
