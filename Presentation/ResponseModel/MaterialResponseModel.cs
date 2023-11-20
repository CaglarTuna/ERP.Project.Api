using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class MaterialResponseModel
    {
        public List<RawMaterialDTO> rawMaterials { get; set; }
        public List<CompanyDTO> companyDTOs { get; set; }
        public List<CommonDTO> Commons { get; set; }
        public List<MaterialDTO> materials { get; set; }
        public MaterialDTO MaterialDTO { get; set; }
        public List<StaffDTO> Staffs { get; set; }
    }
}
