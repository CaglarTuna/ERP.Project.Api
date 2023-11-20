using Core.IRepository;
using DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CommonRepository : Repository<CommonDTO>, ICommonRepository
    {
        Erp_Context _erp_Context;

        public CommonRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public List<CommonDTO> getAllCommon()
        {
            throw new NotImplementedException();
        }

        public List<SelectListItem> GetHeightMeasures()
        {
            var heightMeasure = (from a in _erp_Context.HeightMeasures.ToList()
                                 select new SelectListItem
                                 {
                                     Text = a.Name,
                                     Value = a.Id.ToString()
                                 }
                               ).ToList();
            return heightMeasure;
        }

        public List<SelectListItem> getProccess()
        {
            var proccessName = (from procces in _erp_Context.Process
                                join lang in _erp_Context.ProcessLanguages on procces.Id equals lang.ProcessId
                                where lang.LanguageId == 1
                                select new SelectListItem
                                {
                                    Text = lang.Name,
                                    Value = procces.Id.ToString()
                                }).ToList();
            return proccessName;
        }

        public List<SelectListItem> getRoles()
        {
            var roleNames = (from a in _erp_Context.Roles.ToList()
                             select new SelectListItem
                             {
                                 Text = a.Name,
                                 Value = a.Id.ToString()
                             }).ToList();
            return roleNames;
        }

        public List<SelectListItem> GetShape()
        {
            var shape = (from a in _erp_Context.MaterialShapes.ToList()
                         select new SelectListItem
                         {
                             Text = a.Name,
                             Value = a.Id.ToString()
                         }).ToList();
            return shape;
        }

        public List<SelectListItem> Status()
        {
            var status = (from a in _erp_Context.Statuses.ToList()
                          select new SelectListItem
                          {
                              Text = a.Name,
                              Value = a.Id.ToString()
                          }
                        ).ToList();
            return status;
        }
    }
}
