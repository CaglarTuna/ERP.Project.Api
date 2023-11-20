using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CountryDTO:BaseDTO
    {
        public string UniversalCode { get; set; }
        
        public List<CountryLanguageDTO> CountryLanguage { get; set; }
        public List<CityDTO> Cities { get; set; }
        
    }
}
