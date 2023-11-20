using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class StoreController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public StoreController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Store(string filtre)
        {
            string url = _configuration["UrlVariable"] + "Store/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StoreDTO>>(url, Token);
                List<StoreDTO> dto = new List<StoreDTO>();
                dto = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    dto = dto.Where(x =>
                    x.Name != null && x.Name.ToLower().Contains(filtre.ToLower())
                    || (x.Address != null && x.Address.ToLower().Contains(filtre.ToLower()))).ToList();
                }
                return View(dto);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        [HttpPost]
        public JsonResult AddStore(StoreDTO storeDTO)
        {
            string url = _configuration["UrlVariable"] + "Store/save";
            storeDTO.CreateDate = DateTime.Now;
            storeDTO.UpdateDate = DateTime.Now;
            storeDTO.Status = 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<StoreDTO>(storeDTO, url,Token);
                return Json(result);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        public JsonResult GetStore(int id)
        {
            string url = _configuration["UrlVariable"] + "Store/get/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StoreDTO>>(url,Token);

                return Json(result.data);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        public JsonResult EditStore(StoreDTO dto)
        {
            StoreDTO store = new StoreDTO()
            {
                Name = dto.Name,
                Address = dto.Address,
                Id = dto.Id,
                UpdateDate = DateTime.Now,
                Status = 1
            };
            string url = _configuration["UrlVariable"] + "Store/update";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<StoreDTO>(store, url,Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
    }
}
