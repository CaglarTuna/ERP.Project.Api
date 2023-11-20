using Core.IServices;
using DTO;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IOrderService : IService<OrderDTO>
    {
        void AddProduction(OrderDTO orderDTO);
        OrderDTO getOrder(int id);
        bool OrderRejectNote(OrderDTO order);
        bool OrderConfirmUpdate(OrderDTO order);
        bool OrderWaybillUpdate(OrderDTO orderDTO);
        List<OrderDTO> GetOrderProductionList();
    }
}
