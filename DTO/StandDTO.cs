using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DTO
{
    public class StandDTO : BaseDTO
    {
       
        public string StandNo { get; set; }
        public string Name { get; set; }
        public List<StandProccessDTO> StandProcess { get; set; }
    }
}
