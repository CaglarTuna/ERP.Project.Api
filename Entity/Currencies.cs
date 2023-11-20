using System.Collections.Generic;

namespace Entity
{
    public class Currencies : Base
    {
        public string? Name { get; set; }
        public List<ConsumptionMaterials> ConsumptionMaterials { get; set; }
        public List<Materials> Materials { get; set; }
        public List<Offers> Offers { get; set; }
        public List<Process> Processes { get; set; }
        public List<SawdustStock> SawdustStock { get; set; }
    }
}