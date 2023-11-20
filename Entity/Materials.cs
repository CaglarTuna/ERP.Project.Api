using System.Collections.Generic;

namespace Entity
{
    public class Materials : Base
    {
        public int? CurrencyId { get; set; }
        public Currencies Currencies { get; set; }
        public string? Code { get; set; }
        public string? CostPrice { get; set; }
        public int? MinStockQuantity { get; set; }
        public string? StockNo { get; set; }
        public string? Name { get; set; }
        public string? BarcodeNo { get; set; }
        public string? MaterialCertificate { get; set; }
        public float? Diameter { get; set; }
        public float? Length { get; set; }
        public float? Meter { get; set; }
        public int? ShapeId { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasure HeightMeasure { get; set; }
        public List<MaterialCertificates> MaterialCertificates { get; set; }
        public List<MaterialExpertDeliverys> MaterialExpertDeliverys { get; set; }
        public List<MaterialRawMaterials> MaterialRawMaterials { get; set; }
        public List<MaterialStock> MaterialStock { get; set; }
        public List<MaterialSuppliers> MaterialSuppliers { get; set; }
        public List<MaterialSupplyRequests> MaterialSupplyRequests { get; set; }
        public List<MaterialUnitsOfMeasures> MaterialUnitsOfMeasures { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }
        public List<SawdustStock> SawdustStocks { get; set; }
        public List<UnitsOfMeasure> UnitsOfMeasure { get; set; }
        public List<MaterialHeightMeasure> MaterialHeightMeasures { get; set; }
        public MaterialShape MaterialShapes { get; set; }
        public List<OrderMaterial> OrderMaterials { get; set; }
        public List<OrderNeeds> OrderNeeds { get; set; }
    }
}