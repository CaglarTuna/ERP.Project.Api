using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialUnitsOfMeasuresDTO:BaseDTO
    {
        public int UnitsOfMeasureId { get; set; }
        public UnitsOfMeasureDTO UnitsOfMeasure { get; set; }
        public int MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int PurchasingUnitId { get; set; }
        public UnitsOfMeasureDTO PurchasingUnits { get; set; }
    }
}
