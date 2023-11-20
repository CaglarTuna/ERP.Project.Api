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
using System.Net;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class SawDustController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public SawDustController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult SawDustStock(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Stock/listSawdustStockInput";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<SawdustStockDTO>>(url, Token);
                List<SawdustStockDTO> sawdustStocks = new List<SawdustStockDTO>();
                sawdustStocks = result.dataList;
                if (filtre != null)
                {
                    sawdustStocks = sawdustStocks.Where(x => x.OrderNo != null && x.OrderNo.ToString().ToLower().Contains(filtre.ToLower())
                    ||(x.Materials.Code!=null&&x.Materials.Code.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(sawdustStocks);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult SawDustStockEntry()
        {
            var OrderUrl = _configuration["UrlVariable"] + "Order/listproduction";
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var StoreUrl = _configuration["UrlVariable"] + "Store/list";

            try
            {
                var Token = HttpContext.Session.GetString("token");
                SawDustResponseModel model = new SawDustResponseModel();
                var OrderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderUrl, Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var storeResult = ApiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                model.Orders = OrderResult.dataList;
                model.Materials = MaterialResult.dataList;
                model.Stores = storeResult.dataList;
                return View(model);

            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public IActionResult SawDustStockExit()
        {
            var OrderUrl = _configuration["UrlVariable"] + "Order/listproduction";
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                SawDustResponseModel model = new SawDustResponseModel();
                var Orderresult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderUrl,Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var CompanyResult = ApiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                var commonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                model.Orders = Orderresult.dataList;
                model.Materials = MaterialResult.dataList;
                model.Companies = CompanyResult.dataList;
                model.Commons = commonResult.dataList;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult SawDustStockEntryAdd(SawdustStockDTO sawdustStockDTO)
        {
            var url = _configuration["UrlVariable"] + "Stock/saveInputSawdust";
            sawdustStockDTO.CreateDate = DateTime.Now;
            sawdustStockDTO.UpdateDate = DateTime.Now;
            sawdustStockDTO.EntryDate = DateTime.Now;
            sawdustStockDTO.Status = 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<SawdustStockDTO>>(sawdustStockDTO, url,Token);
                if (result.statu == true)
                {
                    return RedirectToAction("SawDustStock", "SawDust");
                }
                else
                {
                    return RedirectToAction("SawDustStockEntry", "SawDust");
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult SawDustStockExitAdd(SawdustStockDTO sawdustStockDTO)
        {
            var url = _configuration["UrlVariable"] + "Stock/saveInputSawdust";
            sawdustStockDTO.CreateDate = DateTime.Now;
            sawdustStockDTO.UpdateDate = DateTime.Now;
            sawdustStockDTO.ExitDate = DateTime.Now;
            sawdustStockDTO.Status = 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<SawdustStockDTO>>(sawdustStockDTO, url,Token);
                if (result.statu == true)
                {
                    return RedirectToAction("SawDustStock", "SawDust");
                }
                else
                {
                    return RedirectToAction("SawDustStockExit", "SawDust");
                }

            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
    }
}
