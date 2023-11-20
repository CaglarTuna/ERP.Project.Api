using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        Erp_Context _erp_Context;
        public OrdersRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Orders> GetAllOrder()
        {
            var result = _erp_Context.Orders.AsSplitQuery()
                .Include(x => x.MeetingRecords)
                .Include(x => x.Statuss)
                .Include(x => x.Stores)
                .Include(x => x.Staff)
                .Include(x => x.Companies)
                .ThenInclude(x => x.CompanyAddress)
                .Include(x => x.OrderChannel)
                .Include(x => x.MaterialSupplyRequests)
                .ThenInclude(x => x.Materials)
                .Include(x => x.Offers)
                .ThenInclude(x => x.Currencies)
                .Include(x => x.OrderProducts)
                .ThenInclude(x => x.Products).Where(x => x.CompanyId != null).AsNoTracking();
            return result;
        }

        public Orders GetByOrderId(int id)
        {
            var result = _erp_Context.Orders.AsSplitQuery()
                .Include(x => x.MeetingRecords)
                .Include(x => x.Stores)
                .Include(x => x.Statuss)
                .Include(x => x.Staff)
                .Include(x => x.Companies)
                .ThenInclude(x => x.CompanyAddress)
                .Include(x => x.OrderChannel)
                .Include(x => x.MaterialSupplyRequests)
                .ThenInclude(x => x.Materials)
                .Include(x => x.Offers)
                .ThenInclude(x => x.Currencies)
                .Include(x => x.OrderProducts)
                .ThenInclude(x => x.Products).ThenInclude(x=>x.ProductMaterials).Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
            return result;
        }

        public IQueryable<Orders> GetByOrdersDetail(int id)
        {
            var result = _erp_Context.Orders.Include(x => x.Id == id).AsNoTracking();
            return result;
        }

        public IQueryable<Orders> GetOrderProduction()
        {
            var result = _erp_Context.Orders.AsSplitQuery()
                .Include(x => x.MeetingRecords)
                .Include(x => x.Staff)
                .Include(X=>X.Statuss)
                .Include(x => x.Stores)
                .Include(x => x.Companies)
                .ThenInclude(x => x.CompanyAddress)
                .Include(x => x.OrderChannel)
                .Include(x => x.MaterialSupplyRequests)
                .ThenInclude(x => x.Materials)
                .Include(x => x.Offers)
                .ThenInclude(x => x.Currencies)
                .Include(x => x.OrderProducts)
                .ThenInclude(x => x.Products).Where(x => x.CompanyId == null).AsNoTracking();
            return result;
        }
    }
}