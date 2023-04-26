using System;
using System.Collections.Generic;

namespace MegaCasting2022.DBLib.Class
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        public string Roles { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsVerified { get; set; }
        public string? Nom { get; set; }
        public string? Numtel { get; set; }
        public string? Ville { get; set; }
    }
}
