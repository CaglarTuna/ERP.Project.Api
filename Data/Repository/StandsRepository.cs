using Core;
using DTO;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class StandsRepository : Repository<Stands>, IStandsRepository
    {
        Erp_Context _erp_Context;
        public StandsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
        public Stands getStand(int languageId,int id)
        {
            return _erp_Context.Stands.Include(x => x.StandProcess).ThenInclude(x => x.Process).ThenInclude(x => x.ProcessLanguage).Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Stands> GetAllStand(int languageId)
        {
            var result= _erp_Context.Stands.Include(x => x.StandProcess).ThenInclude(x => x.Process).ThenInclude(x => x.ProcessLanguage).AsNoTracking().ToList();
            return result;
        }
    }
}