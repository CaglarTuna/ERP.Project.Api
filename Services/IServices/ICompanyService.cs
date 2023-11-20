using Core.IServices;
using DTO;

namespace Services.IServices
{
    public interface ICompanyService : IService<CompanyDTO>
    {
        CompanyDTO getComponyDetail(int id);
    }
}
