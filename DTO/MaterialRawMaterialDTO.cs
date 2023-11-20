using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialRawMaterialDTO : BaseDTO
    {
        public int MaterialId { get; set; }
        public int RawMaterialId { get; set; }
        public RawMaterialDTO RawMaterialDTO { get; set; }
    }
}
