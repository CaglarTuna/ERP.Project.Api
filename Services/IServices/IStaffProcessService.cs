using Core.IServices;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IStaffProcessService:IService<StaffProcessDTO>
    {
        void AddStaffProccess(List<StaffProcessDTO> entity);
        bool UpdateStaffProccess(List<StaffProcessDTO> entity);
        List<StaffProcessDTO> GetBy(int ProductId, int OrderProductId);
        List<StaffProcessDTO> GetByStaffId(int id);
    }
}
