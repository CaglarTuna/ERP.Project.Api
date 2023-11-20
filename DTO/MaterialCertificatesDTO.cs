using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialCertificatesDTO : BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public string Certificate { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
    }
}
