using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class CompanyAddressDTO : BaseDTO
    {
        public int CompanyId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        //public List<SelectListItem> CountryNames { get; set; }
        //public List<SelectListItem> CityNames { get; set; }
        public string PostCode { get; set; }
        public string AddressTitle { get; set; }
        public string Address { get; set; }
        public CompanyDTO CompanyDTO { get; set; }  //-
    }
}
