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
    public class ProccessController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler apiHandler = new ApiHandler();
        public ProccessController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region İşlem yönetimi sayfası liseleme fonksiyonu
        public IActionResult Proccess(string filtre, int languageId)
        {
            languageId = 1;
            string url = _configuration["UrlVariable"] + "Process/list/" + languageId;
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ProcessDTO>>(url,Token);
                var CommonResult = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl,Token);
                List<ProcessDTO> proccess = new List<ProcessDTO>();
                List<CommonDTO> commonDTOs = new List<CommonDTO>();
                proccess = result.dataList;
                commonDTOs = CommonResult.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    proccess = proccess.Where(x => x.ProcessNo != null && x.ProcessNo.ToLower().Contains(filtre.ToLower())
                     || (x.Cost != null && x.Cost.ToLower().Contains(filtre.ToLower()))
                     || (x.ProcessLanguage.Any(y => y.Name != null && y.Name.ToLower().Contains(filtre.ToLower())))
                    ).ToList();
                }
                var model = (proccess, commonDTOs);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region İşlem yönetimi sayfası yeni işlem ekleme fonksiyonu
        public JsonResult AddProccess(ProcessDTO processDTO)
        {
            Random random = new Random();
            int proccessno = random.Next(0, 10000);
            string url = _configuration["UrlVariable"] + "Process/save";
            ProcessDTO process = new ProcessDTO()
            {
                Cost = processDTO.Cost,
                CreateDate = DateTime.Now,
                ProcessNo = proccessno.ToString(),
                UpdateDate = DateTime.Now,
                Name = processDTO.Name,
                CurrencyId = processDTO.CurrencyId,

            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<DataDto<ProcessDTO>>(process, url,Token);
                if (result.statu == true)
                {
                    return Json(1);
                }
                else
                {

                    return Json(2);
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region İşlem yönetimi sayfası Güncelleme fonksiyonu
        public IActionResult getProccess(int id)
        {
            string url = _configuration["UrlVariable"] + "Process/list/" + 1;
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                ProcessDTO processDTO = new ProcessDTO();
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ProcessDTO>>(url,Token);
                var common = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                processDTO = result.dataList.Where(x => x.Id == id).FirstOrDefault();
                List<CommonDTO> commonDTOs = new List<CommonDTO>();
                commonDTOs = common.dataList;
                var model = (processDTO, commonDTOs);
                return PartialView("_editProcces", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region İşlem yönetimi sayfası güncellem işlemi post fonksiyonu
        public JsonResult EditProccess(ProcessDTO processDTO)
        {
            ProcessDTO process = new ProcessDTO()
            {
                Cost = processDTO.Cost,
                UpdateDate = DateTime.Now,
                CurrencyId = processDTO.CurrencyId,
                Name = processDTO.Name,
                Id = processDTO.Id,
                ProcessNo = processDTO.ProcessNo,
                Status = 1
            };
            string url = _configuration["UrlVariable"] + "Process/update";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<ProcessDTO>(process, url,Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
