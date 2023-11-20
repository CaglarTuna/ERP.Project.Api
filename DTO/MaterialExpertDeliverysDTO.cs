using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialExpertDeliverysDTO : BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? Quantity { get; set; }
        public int? DeliveryStaffId { get; set; }
        public string DeliveryNote { get; set; }
        public StaffDTO Staffs { get; set; }
        public int? StaffId { get; set; }
    }
}
