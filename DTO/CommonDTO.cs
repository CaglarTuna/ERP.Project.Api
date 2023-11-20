using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommonDTO : BaseDTO
    {
       
        public List<SelectListItem> RoleNames { get; set; }
        public List<SelectListItem> proccessNames { get; set; }
        public List<CountryDTO> countries { get; set; }
        public List<CountryLanguageDTO> countryLanguages { get; set; }
        public List<UnitsOfMeasureDTO> unitsOfMeasureDTOs { get; set; }
        public List<CurrenciesDTO> currenciesDTOs { get; set; }
        public List<SelectListItem> HeightMeasures { get; set; }
        public List<SelectListItem> MaterialShape { get; set; }
    }
}
