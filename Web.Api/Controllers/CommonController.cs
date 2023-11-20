using Data.Repository;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [Authorize]
    [ExceptionFilter("")]
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : Controller
    {
        ICommonService _commonService;

        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }
        [HttpGet("list")]
        public JsonResult list()
        {
            var result = _commonService.GetAll(1);
            var model = new ResultDTO<CommonDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("getCity/{id}")]
        public JsonResult getCityList(int id)
        {
            var result = _commonService.getCity(id);
            var model = new ResultDTO<CityDTO>()
            {
                DataList = result,
            };
            return Json(model);
        }
    }

}
