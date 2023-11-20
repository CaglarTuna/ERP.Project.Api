using DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface ICommonRepository : IRepository<CommonDTO>
    {
        List<CommonDTO> getAllCommon();
        List<SelectListItem> getRoles();
        List<SelectListItem> getProccess();
        List<SelectListItem> GetHeightMeasures();
        List<SelectListItem> GetShape();
        List<SelectListItem> Status();

    }
}
