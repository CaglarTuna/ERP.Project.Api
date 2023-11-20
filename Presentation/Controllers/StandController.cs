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

namespace Presentation.Controllers
{
    [ActionFilters]
    public class StandController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public StandController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Tezgah yönetimi sayfası listeleme işlemi
        public IActionResult Index(string Filtre)
        {
            var languageId = 1;
            string url = _configuration["UrlVariable"] + "Stand/list/" + languageId;
            string proccessUrl = _configuration["UrlVariable"] + "Process/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StandDTO>>(url,Token);
                var proccesResult = ApiHandler.GetAPI<DataDto<ProcessDTO>>(proccessUrl, Token);
                List<StandDTO> standDTO = new List<StandDTO>();
                List<ProcessDTO> processes = new List<ProcessDTO>();
                standDTO = result.dataList;
                processes = proccesResult.dataList;
                if (!String.IsNullOrEmpty(Filtre))
                {
                    standDTO = standDTO.Where(x => x.StandNo != null && x.StandNo.ToLower().Contains(Filtre.ToLower())
                      || (x.Name != null && x.Name.ToLower().Contains(Filtre.ToLower()))
                      || (x.StandProcess.Any(y => y.Process.ProcessLanguage.Any(z => z.Name != null && z.Name.ToLower().Contains(Filtre.ToLower()))))
                    ).ToList();
                }
                var model = (standDTO, processes);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Tezgah yönetimi sayfası ekleme işlemi
        [HttpPost]
        public JsonResult AddStandProccess(StandDTO stand, string[] ProccessId)
        {
            List<StandProccessDTO> standProccesses = new List<StandProccessDTO>();
            foreach (var item in ProccessId)
            {
                standProccesses.Add(new StandProccessDTO()
                {
                    CreateDate = DateTime.Now,
                    ProcessId = Convert.ToInt32(item),
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            Random random = new Random();
            int standno = random.Next(0, 10000);
            StandDTO standDTO = new StandDTO()
            {
                StandProcess = standProccesses,
                Name = stand.Name,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                StandNo = standno.ToString(),
                Status = 1
            };
            string url = _configuration["UrlVariable"] + "Stand/save";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<StandDTO>>(standDTO, url,Token);
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
        #region Tezgah yönetimi sayfası Güncelleme popup
        public IActionResult getStand(int id)
        {
            string url = _configuration["UrlVariable"] + "Stand/get/" + id;
            string proccessUrl = _configuration["UrlVariable"] + "Process/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                StandDTO stand = new StandDTO();
                List<ProcessDTO> processDTOs = new List<ProcessDTO>();
                var result = ApiHandler.GetAPI<DataDto<StandDTO>>(url, Token);
                var proccessResult = ApiHandler.GetAPI<DataDto<ProcessDTO>>(proccessUrl, Token);
                stand = result.data;
                processDTOs = proccessResult.dataList;
                var model = (stand, processDTOs);
                return PartialView("_editStand", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Tezgah yönetimi sayfası Güncelleme işlemi post işlemi
        [HttpPost]
        public JsonResult EditStand(StandDTO stand, string[] ProccessId)
        {
            List<StandProccessDTO> standProccessDTOs = new List<StandProccessDTO>();
            foreach (var item in ProccessId)
            {
                standProccessDTOs.Add(new StandProccessDTO()
                {
                    CreateDate = DateTime.Now,
                    ProcessId = Convert.ToInt32(item),
                    StandId=stand.Id,
                    UpdateDate=DateTime.Now,
                    Status=1
                });
            }
            StandDTO standDTO = new StandDTO()
            {
                Name = stand.Name,
                UpdateDate = DateTime.Now,
                StandNo = stand.StandNo,
                Status = 1,
                Id = stand.Id,
                StandProcess= standProccessDTOs
            };
            string url = _configuration["UrlVariable"] + "Stand/update";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<StandDTO>(standDTO, url,Token);
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
