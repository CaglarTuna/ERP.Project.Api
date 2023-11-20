using System;
using System.Collections.Generic;

namespace DTO
{
    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; }
        public string ProductDescription { get; set; }
        public string TechnicalImage { get; set; }
        public int CategoryId { get; set; }
        public bool IsPrescriptions { get; set; }
        public string ProductCost { get; set; }
        public string ProductCertificate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string BarcodeNo { get; set; }
        public string ProductionSerialNumber { get; set; }
        public int ProductType { get; set; }
        //public int ProductId { get; set; }
        public string UniqueNo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public string ProductAddress { get; set; }
        //public int OperationId { get; set; }
        public int OperationDuration { get; set; }
        public int OperationOrderNo { get; set; }
        public int MaterialId { get; set; }//
        public int UnitMeasureId { get; set; }//
        public int Count { get; set; }
        public string SpecialProductDescription { get; set; }
        public bool SignatureStatus { get; set; }
        public int StoreId { get; set; }//
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public CategoryDTO Categories { get; set; }
        public List<ProductMaterialDTO> productMaterialDTOs { get; set; }
        public List<ProductProcessDTO> productProcessDTOs { get; set; }
        public List<ProductStockDTO> productStockDTOs { get; set; }
        public List<OfferDTO> offerDTOs { get; set; }
        public List<OrderProductDTO> orderProductDTOs { get; set; }
        public List<StaffProcessPermisionsDTO> staffProcessPermisionsDTOs { get; set; }
        public List<StaffProcessDTO> staffProcessDTOs { get; set; }
        public List<ProductDocumentDTO> productDocumentDTOs { get; set; }
        public List<DocumentDTO> documentDTOs { get; set; }
        public List<OrderNeedsDto> OrderNeeds { get; set; }
    }
}