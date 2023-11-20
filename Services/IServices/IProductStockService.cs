using Core.IServices;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IProductStockService : IService<ProductStockDTO>
    {
        bool ProductStockUpdate(ProductStockDTO productStock);
        List<ProductDTO> GetByIdProductStock(int id);
    }
}
