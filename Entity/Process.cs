using System.Collections.Generic;

namespace Entity
{
    public class Process : Base
    {
        public string? Cost { get; set; }
        public string? ProcessNo { get; set; }
        public int? CurrencyId { get; set; }
        public Currencies Currencies { get; set; }
        public List<ProcessLanguage> ProcessLanguage { get; set; }
        public List<StandProcess> StandProcess { get; set; }
        public List<StaffProcess> StaffProcess { get; set; }
        public List<ProductProcess> ProductProcess { get; set; }
        public List<StaffProcessPermisions> StaffProcessPermisions { get; set; }
    }
}