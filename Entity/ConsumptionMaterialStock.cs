using System;

namespace Entity
{
    public class ConsumptionMaterialStock : Base
    {
        public int? ConsumptionMaterialId { get; set; }
        public ConsumptionMaterials ConsumptionMaterials { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? StoreId { get; set; }
        public Stores Stores { get; set; }
        public int? UniqueNo { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? ConsumptionMaterialAddress { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public float? Quantity { get; set; }
        public string DeliveryNote { get; set; }
        public Stands Stands { get; set; }
        public int? StandId { get; set; }
        public Orders Orders { get; set; }
        public int? OrderId { get; set; }

    }
}