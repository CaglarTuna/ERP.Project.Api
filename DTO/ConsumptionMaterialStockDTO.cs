using System;

namespace DTO
{
    public class ConsumptionMaterialStockDTO : BaseDTO
    {
        public int? ConsumptionMaterialId { get; set; }
        public ConsumptionMaterialDTO ConsumptionMaterials { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
        public int? StoreId { get; set; }
        public StoreDTO Stores { get; set; }
        public int? UniqueNo { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? ConsumptionMaterialAddress { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public float? Quantity { get; set; }
        public int? StaffId { get; set; }
        public StaffDTO Staffs { get; set; }
        public string DeliveryNote { get; set; }
        public StandDTO Stands { get; set; }
        public int? StandId { get; set; }
        public OrderDTO Orders { get; set; }
        public int? OrderId { get; set; }
    }
}