using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string NationalId { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Account { get; set; } = null!;
        public string LineOfBusiness { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string LanguageLevel { get; set; } = null!;
    }
}
