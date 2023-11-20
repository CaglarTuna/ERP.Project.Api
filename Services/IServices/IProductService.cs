using Core.IServices;
using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IProductService : IService<ProductDTO>
    {
        List<ProductProcessDTO> productProcesses();
        Task<List<ProductDTO>> getAllAsync();
        List<SpeacialProductDescriptionDTO> GetSpecialProduct();
        List<ProductDTO> GetByCategoryIdProducts(int id);
    }
}
