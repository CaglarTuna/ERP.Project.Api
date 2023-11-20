using System.Collections.Generic;

namespace Entity
{
    public class OrderProducts : Base
    {
        public int? OrderId { get; set; }
        public Orders Orders { get; set; }
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? Quantitiy { get; set; }
        public int? RealizedProduction { get; set; }
        public int? StatusId { get; set; }
        public Status Statuss { get; set; }
        public List<StaffProcess> StaffProcesses { get; set; }
    }
}