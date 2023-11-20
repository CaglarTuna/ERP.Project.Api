namespace Entity
{
    public class ConsumptionMaterialSuppliers : Base
    {
        public int? ConsumptionMaterialId { get; set; }
        public ConsumptionMaterials ConsumptionMaterials { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
    }
}