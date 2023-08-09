using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string? AccountName { get; set; }
        public string? LineOfBusiness { get; set; }
    }
}
