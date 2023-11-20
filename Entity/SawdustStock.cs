using System;

namespace Entity
{
    public class SawdustStock : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public int? StoreId { get; set; }
        public Stores Stores { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? Quantity { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? OrderNo { get; set; }
        public Orders Orders { get; set; }
        public int? Price { get; set; }
        public int? CurrencyId { get; set; }
        public Currencies Currencies { get; set; }
        public string? SawdustStockAddress { get; set; }
        public int? ReturnReasonId { get; set; }
    }
}