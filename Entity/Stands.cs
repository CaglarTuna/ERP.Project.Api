using System.Collections.Generic;

namespace Entity
{
    public class Stands : Base
    {
        public string? StandNo { get; set; }
        public string? Name { get; set; }
        public List<StandProcess> StandProcess { get; set; }
        public List<ConsumptionMaterialStock> consumptionMaterials { get; set; }

    }
}