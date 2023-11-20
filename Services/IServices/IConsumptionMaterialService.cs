using Core.IServices;
using DTO;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IConsumptionMaterialService : IService<ConsumptionMaterialDTO>
    {
        ConsumptionMaterialDTO getConsumptionMaterialDetail(int id);
        List<ConsumptionMaterialStockDTO> GetAllStock();
        ConsumptionMaterialStockDTO GetByIdStock(int id);
    }
}
