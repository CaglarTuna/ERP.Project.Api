using System.Collections.Generic;

namespace Entity
{
    public class UnitsOfMeasure : Base
    {
        public string? Name { get; set; }
        public List<MaterialUnitsOfMeasures> MaterialUnitsOfMeasures { get; set; }
        public List<ConsumptionMaterials> ConsumptionMaterials { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }
        public List<UnitsOfMeasure> PurchasingUnits { get; set; }
    }
}