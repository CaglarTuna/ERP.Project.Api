using Core;
using DTO;
using Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Repository
{
    public class StaffsRepository : Repository<Staffs>, IStaffsRepository
    {
        Erp_Context _erp_Context;
        public StaffsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Staffs> GetAllStaff(int languageId)
        {
            var query = _erp_Context.Staffs.Include(x => x.StaffRoles).ThenInclude(x => x.Roles).Include(x => x.StaffProcessPermisions).ThenInclude(x => x.Process).ThenInclude(x => x.ProcessLanguage).Where(x => x.Status != 3 && x.StaffProcessPermisions.Where(y => y.Process.ProcessLanguage.Where(z => z.LanguageId == languageId).Any()).Any()).AsNoTracking().AsSplitQuery();
           
            return query;
        }
        public Staffs GetStaff(string email, string password)
        {
            var result = _erp_Context.Staffs.Include(x => x.StaffRoles).ThenInclude(x => x.Roles).Include(x => x.StaffProcessPermisions).ThenInclude(x => x.Process).ThenInclude(x => x.ProcessLanguage).Where(x => x.Email == email && x.Password == password && x.Status != 3).AsSplitQuery().AsTracking().FirstOrDefault();
            return result;
        }

        public Staffs GetStaffById(int id)
        {
            var result = _erp_Context.Staffs.Include(x => x.StaffRoles).ThenInclude(x => x.Roles).Include(x => x.StaffProcessPermisions).ThenInclude(x => x.Process).ThenInclude(x => x.ProcessLanguage).Where(x => x.Id == id && x.Status != 3).AsNoTracking().AsSplitQuery().FirstOrDefault();
            return result;
        }

        public IQueryable<Staffs> GetStaffByRoles()
        {
            var SubQuery = _erp_Context.Staffs.Include(x => x.StaffRoles).ThenInclude(x => x.Roles).AsNoTracking().AsSplitQuery();
            return SubQuery;
        }
    }
}