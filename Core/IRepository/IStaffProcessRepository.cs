using Entity;
using System.Linq;

namespace Core
{
    public interface IStaffProcessRepository : IRepository<StaffProcess>
    {
        IQueryable<StaffProcess> GetByStaffProccess(int ProductId, int OrderProductId);
        IQueryable<StaffProcess> GetByIdStaffProccess(int id);
    }

}
