using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CountryLanguageDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
