using System.Collections.Generic;

namespace Entity
{
    public class Stores : Base
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<ConsumptionMaterialStock> ConsumptionMaterialStock { get; set; }
        public List<Orders> Orders { get; set; }
        public List<ProductStock> ProductStock { get; set; }
        public List<SawdustStock> SawdustStocks { get; set; }
        public List<MaterialStock> MaterialStocks { get; set; }
    }
}