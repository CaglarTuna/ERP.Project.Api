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
    public class StockController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public StockController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public IActionResult StockMaterialList(string filtre)
        {
            string url = _configuration["UrlVariable"] + "Stock/listStockMaterial";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialStockDTO>>(url,Token);
                List<MaterialStockDTO> materialStocks = new List<MaterialStockDTO>();
                materialStocks = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    materialStocks = materialStocks.Where(x => x.Materials.StockNo != null && x.Materials.StockNo.ToLower().Contains(filtre.ToLower())
                      || (x.Materials.BarcodeNo != null && x.Materials.BarcodeNo.ToLower().Contains(filtre.ToLower()))
                      || (x.Materials.Name != null && x.Materials.Name.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(materialStocks);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
