using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class Language
    {
        public int Id { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }
    }
}
