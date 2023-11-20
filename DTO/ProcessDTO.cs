using System.Collections.Generic;

namespace DTO
{
    public class ProcessDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public string ProcessNo { get; set; }
        public int CurrencyId { get; set; }
        public CurrenciesDTO Currencies { get; set; }
        public List<ProcessLanguageDTO> ProcessLanguage { get; set; }
        public List<StandProccessDTO> StandProcess { get; set; }
        public List<StaffProcessDTO> StaffProcess { get; set; }
        public List<ProductProcessDTO> ProductProcess { get; set; }
        public List<StaffProcessPermisionsDTO> StaffProcessPermisions { get; set; }

    }
}
