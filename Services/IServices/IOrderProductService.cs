using Core.IServices;
using DTO;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IOrderProductService : IService<OrderProductDTO>
    {
        bool PropertyUpdate(OrderProductDTO orderProduct);
        List<OrderProductDTO> getProductWithOrderId(int id, int orderId);
        List<OrderProductDTO> GetSelectOrderProduct();
    }
}
