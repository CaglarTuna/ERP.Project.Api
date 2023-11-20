using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductStockDTO : BaseDTO
    {
        public int ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int StoreId { get; set; }
        public StoreDTO Stores { get; set; }
        public string UniqueNo { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public string ProductAddress { get; set; }
        public int StockProductQuantity { get; set; }
        public int ProductionProductQuantity { get; set; }
        public string ProductStockSerialNo { get; set; }
    }
}
