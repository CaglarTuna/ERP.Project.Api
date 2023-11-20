using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialStockDTO : BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? UniqueNo { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? MaterialAdress { get; set; }
        public int? StoreId { get; set; }
        public StoreDTO Stores { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int Quantity { get; set; }
        public List<OrderMaterialDTO> OrderMaterials { get; set; }
    }
}
