using System.Collections.Generic;

namespace Entity
{
    public class HeightMeasure : Base
    {
        public string? Name { get; set; }
        public List<MaterialHeightMeasure> MaterialHeightMeasures { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }
        public List<Materials> Materials { get; set; }
    }
}
