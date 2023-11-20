namespace DTO
{
    public class ConsumptionMaterialSupplierDTO : BaseDTO
    {
        public int? ConsumptionMaterialId { get; set; }
        public ConsumptionMaterialDTO ConsumptionMaterials { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
    }
}
