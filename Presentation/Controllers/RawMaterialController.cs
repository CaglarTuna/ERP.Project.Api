
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
    public class RawMaterialController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler apiHandler = new ApiHandler();
        public RawMaterialController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult RawMaterial(string filtre)
        {
            string url = _configuration["UrlVariable"] + "RawMaterial/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<RawMaterialDTO>>(url,Token);
                List<RawMaterialDTO> material = new List<RawMaterialDTO>();
                material = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    material = material.Where(x => x.Name != null && x.Name.ToLower().Contains(filtre.ToLower())
                      || (x.Code != null && x.Code.ToLower().Contains(filtre.ToLower()))).ToList();
                }
                return View(material);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult AddRawMaterial(RawMaterialDTO rawMaterial)
        {
            string url = _configuration["UrlVariable"] + "RawMaterial/save";
            RawMaterialDTO materialDTO = new RawMaterialDTO()
            {
                Code = rawMaterial.Code,
                CreateDate = DateTime.Now,
                Name = rawMaterial.Name,
                UpdateDate = DateTime.Now,
                Density=rawMaterial.Density,
                Status=1
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<RawMaterialDTO>(materialDTO, url,Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        public JsonResult GetRawMaterialDetail(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            string url = _configuration["UrlVariable"] + "RawMaterial/get/" + id;
            try
            {
                var result = apiHandler.GetAPI<DataDto<RawMaterialDTO>>(url,Token);
                RawMaterialDTO material = new RawMaterialDTO();
                material = result.data;
                return Json(material);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult EditRawMaterial(RawMaterialDTO rawMaterial)
        {
            string url = _configuration["UrlVariable"] + "RawMaterial/update";
            rawMaterial.UpdateDate = DateTime.Now;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<ResultDTO<RawMaterialDTO>>(rawMaterial, url,Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
                throw;
            }
        }

    }
}
