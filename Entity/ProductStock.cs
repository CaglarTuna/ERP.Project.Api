using System;

namespace Entity
{
    public class ProductStock : Base
    {
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? StoreId { get; set; }
        public Stores Stores { get; set; }
        public string? UniqueNo { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? ProductAddress { get; set; }
        public int StockProductQuantity { get; set; }
        public int ProductionProductQuantity { get; set; }
        public string ProductStockSerialNo { get; set; }
    }
}