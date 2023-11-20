using System.Collections.Generic;

namespace Entity
{
    public class Country : Base
    {
        public string? UniversalCode { get; set; }
        public List<City> Cities { get; set; }
        public List<CountryLanguage> CountryLanguage { get; set; }
    }
}