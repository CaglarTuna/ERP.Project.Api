using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatusDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<OfferDTO> Offers { get; set; }
        public List<OrderDTO> Orders { get; set; }
        public List<OrderProductDTO> OrderProducts { get; set; }
    }
}
