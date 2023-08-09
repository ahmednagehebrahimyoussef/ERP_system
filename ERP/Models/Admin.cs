using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
    }
}
