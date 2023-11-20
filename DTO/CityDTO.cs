using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CityDTO:BaseDTO
    {
        public string cityName { get; set; }
        public int CityId { get; set; }
        public CityLanguageDTO CityLanguageDTO { get; set; }
        public List<CityLanguageDTO> CityLanguage { get; set; }
    }
}