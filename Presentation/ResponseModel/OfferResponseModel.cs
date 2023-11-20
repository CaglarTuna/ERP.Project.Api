using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class OfferResponseModel
    {
        public List<CommonDTO> commons { get; set; }
        public List<OrderDTO> orders { get; set; }
        public List<OrderProductDTO> productDTOs { get; set; }
        public OrderDTO OrderDTO { get; set; }
        public List<OfferDTO> offerDTOs { get; set; }
        public OfferDTO offer { get; set; }
    }
}
