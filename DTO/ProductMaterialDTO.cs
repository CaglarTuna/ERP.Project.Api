using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductMaterialDTO:BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? UnitMeasureId { get; set; }
        public UnitsOfMeasureDTO UnitsOfMeasure { get; set; }
        public int? ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int? Count { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasureDTO HeightMeasures { get; set; }
    }
}
