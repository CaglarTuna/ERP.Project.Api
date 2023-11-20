using Core.IServices;
using DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ICommonService: IService<CommonDTO>
    {
        List<CityDTO> getCity(int id);
    }
}
