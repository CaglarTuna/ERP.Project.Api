using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CurrenciesDTO:BaseDTO
    {
        public string Name { get; set; }
        public List<ConsumptionMaterialDTO> ConsumptionMaterialss { get; set; }
        public List<MaterialDTO> Materials { get; set; }
        public List<OfferDTO> Offers { get; set; }
        public List<ProcessDTO> Processes { get; set; }
        public List<UnitsOfMeasureDTO> UnitsOfMeasuress { get; set; }

    }
}
