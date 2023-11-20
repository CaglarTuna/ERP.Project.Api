using System.Collections.Generic;

namespace Entity
{
    public class ProductMaterials : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? UnitMeasureId { get; set; }
        public UnitsOfMeasure UnitsOfMeasure { get; set; }
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? Count { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasure HeightMeasures { get; set; }
        public int? StatusId { get; set; }
        public Status Statuss { get; set; }

    }
}