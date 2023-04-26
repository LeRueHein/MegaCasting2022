using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class DoctrineMigrationVersion
    {
        public string Version { get; set; } = null!;
        public DateTime? ExecutedAt { get; set; }
        public int? ExecutionTime { get; set; }
    }
}
