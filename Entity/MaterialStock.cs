using System;

namespace Entity
{
    public class MaterialStock : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? UniqueNo { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? MaterialAdress { get; set; }
        public int? StoreId { get; set; }
        public Stores Stores { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public float? Quantity { get; set; }
    }
}