using DTO;
using Entity;
using System.Collections.Generic;

namespace Core
{
    public interface IStandsRepository : IRepository<Stands>
    {
        List<Stands> GetAllStand(int languageId);
        Stands getStand(int languageId, int id);
    }
}
