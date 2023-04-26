using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class PartenaireDiffusion
    {
        public int Identifiant { get; set; }
        public string? Login { get; set; } = null!;
        public string? Password { get; set; } = null!;
    }
}
