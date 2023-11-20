namespace Entity
{
    public class MaterialUnitsOfMeasures : Base
    {
        public int? UnitsOfMeasureId { get; set; }
        public UnitsOfMeasure UnitsOfMeasure { get; set; }
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? PurchasingUnitId { get; set; }
        public UnitsOfMeasure PurchasingUnits { get; set; }
    }
}