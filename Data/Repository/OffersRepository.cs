using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class OffersRepository : Repository<Offers>, IOffersRepository
    {
        Erp_Context _erp_Context;
        public OffersRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public List<Offers> GetAllOffer()
        {
            var result = _erp_Context.Offers.AsSplitQuery()
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .Include(x => x.Currencies).AsNoTracking().ToList();
            return result;

        }

        //public Offers getByIdOffer(int id)
        //{
        //    var result = _erp_Context.Offers.Where(x => x.Id == id).OrderByDescending(x => x.Id)
        //        .Include(x => x.Orders)
        //        .Include(x => x.Products)
        //        .Include(x => x.Currencies).AsSplitQuery().AsNoTracking().FirstOrDefault();
        //    return result
        //}

        public List<Offers> getLastAllOffers(int id)
        {
            var result = _erp_Context.Offers.AsSplitQuery()
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .Include(x => x.Currencies).Where(x => x.OrderId == id).OrderByDescending(x => x.Id).GroupBy(x => x.UnitCost).Select(x => x.Last());
            return result.ToList();
        }

        public Offers getLastOffers(int id)
        {
            var result = _erp_Context.Offers.Where(x => x.OrderId == id).OrderByDescending(x => x.Id)
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .Include(x => x.Currencies).AsSplitQuery().AsNoTracking().FirstOrDefault();
            return result;
        }
    }
}