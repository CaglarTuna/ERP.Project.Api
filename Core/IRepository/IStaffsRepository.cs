using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core
{
    public interface IStaffsRepository : IRepository<Staffs>
    {
        Staffs GetStaff(string email,string password);
        Staffs GetStaffById(int id);
        IQueryable<Staffs> GetAllStaff(int languageId);
        IQueryable<Staffs> GetStaffByRoles();
        
    }
}
