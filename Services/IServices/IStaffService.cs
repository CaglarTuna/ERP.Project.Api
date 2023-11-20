using Core.IServices;
using DTO;
using System.Collections.Generic;

namespace Services.IServices
{
    public interface IStaffService : IService<StaffDTO>
    {
        StaffDTO GetBy(string email, string password);
        bool StaffConfirm(StaffDTO entitiy);
    }
}
