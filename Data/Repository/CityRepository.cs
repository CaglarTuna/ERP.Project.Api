using Core.IRepository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        Erp_Context _erp_Context;

        public CityRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public List<City> getCity(int id)
        {
            var result = _erp_Context.City.Include(x => x.CityLanguage).Where(x => x.CountryId == id).ToList();
            return result;
        }
    }
}
