using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class ProductResponseModel
    {
        public List<CategoryDTO> categoryDTOs { get; set; }
        public List<MaterialDTO> materialDTOs { get; set; }
        public List<ProcessDTO> processDTOs { get; set; }
        public ProductDTO product { get; set; }
        public List<ProductDTO> productDTOs { get; set; }
        public List<CommonDTO> commonDTOs { get; set; }
        public ProductStockDTO ProductStockDTO { get; set; }
        public OrderProductDTO orderProduct { get; set; }
        public List<StoreDTO> StoreDTO { get; set; }
    }
}
