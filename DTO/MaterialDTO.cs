using System;
using System.Collections.Generic;

namespace DTO
{
    public class MaterialDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ConsumptionUnitId { get; set; }
        public int CompanyId { get; set; }
        public int MaterialId { get; set; }
        public int RawMaterialId { get; set; }
        public int UnitsOfMeasureId { get; set; }
        public int CurrencyId { get; set; }
        public string CostPrice { get; set; }
        public int MinStockQuantity { get; set; }
        public string StockNo { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string BarcodeNo { get; set; }
        public string MaterialCertificate { get; set; }
        public string Certificate { get; set; }
        public float Diameter { get; set; }
        public float Length { get; set; }
        public int PurchasingUnitId { get; set; }
        public float Quantity { get; set; }
        public float? Meter { get; set; }
        public int? ShapeId { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasureDTO HeightMeasureDTO { get; set; }
        public List<MaterialRawMaterialDTO> materialRawMaterial { get; set; }
        public List<RawMaterialDTO> rawMaterialDTOs { get; set; }
        public List<MaterialSupplierDTO> materialSupplierDTOs { get; set; }
        public List<UnitsOfMeasureDTO> UnitsOfMeasureDTO { get; set; }
        public CurrenciesDTO CurrenciesDTO { get; set; }
        public List<MaterialCertificatesDTO> materialCertificatesDTOs { get; set; }
        public List<MaterialExpertDeliverysDTO> materialExpertDeliverysDTOs { get; set; }
        public List<MaterialStockDTO> materialStockDTOs { get; set; }
        public List<MaterialSupplierDTO> materialSuppliers { get; set; }
        public List<MaterialSupplyRequestsDTO> materialSupplyRequestsDTOs { get; set; }
        public List<MaterialUnitsOfMeasuresDTO> materialUnitsOfMeasuresDTOs { get; set; }
        public List<ProductMaterialDTO> productMaterialDTOs { get; set; }
        public List<SawdustStockDTO> sawdustStockDTOs { get; set; }
        public List<MaterialHeightMeasureDTO> MaterialHeightMeasureDTOs { get; set; }
        public MaterialShapeDTO MaterialShape { get; set; }
        public List<OrderMaterialDTO> OrderMaterials { get; set; }
        public List<OrderNeedsDto> OrderNeeds { get; set; }
    }
}