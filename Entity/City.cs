using System.Collections.Generic;

namespace Entity
{
    public class City : Base
    {
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public List<CityLanguage> CityLanguage { get; set; }
    }
}