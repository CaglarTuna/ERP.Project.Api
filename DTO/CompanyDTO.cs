using System.Collections.Generic;

namespace DTO
{
    public class CompanyDTO : BaseDTO
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string Department { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Telephone { get; set; }
        public string Prefix { get; set; }
        public CompanyAddressDTO CompanyAddressDTO { get; set; } //-
        public List<CompanyAddressDTO> CompanyAddressDTOs { get; set; } //-
        public List<MaterialCertificatesDTO> MaterialCertificatesDTOs { get; set; }

    }
}
