using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialSupplierDTO : BaseDTO
    {
        public int MaterialId { get; set; }
        public int CompanyId { get; set; }
        public MaterialDTO material { get; set; }
        public CompanyDTO company { get; set; }
    }
}
