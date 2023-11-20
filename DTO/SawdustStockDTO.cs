using System;

namespace DTO
{
    public class SawdustStockDTO : BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
        public int? StoreId { get; set; }
        public StoreDTO Stores { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? Quantity { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? OrderNo { get; set; }
        public OrderDTO Orders { get; set; }
        public int? Price { get; set; }
        public int? CurrencyId { get; set; }
        public CurrenciesDTO Currencies { get; set; }
        public string? SawdustStockAddress { get; set; }
        public int? ReturnReasonId { get; set; }

    }
}
