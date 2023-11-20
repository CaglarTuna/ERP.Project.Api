using System.Collections.Generic;

namespace Entity
{
    public class CountryLanguage : Base
    {
        public int? CountryId { get; set; }
        public Country Countries { get; set; }
        public string? Name { get; set; }
        public int? LangaugeId { get; set; }
        public Languages Languages { get; set; }
        public string? Code { get; set; }
        public List<CityLanguage> CityLanguages { get; set; }
    }
}