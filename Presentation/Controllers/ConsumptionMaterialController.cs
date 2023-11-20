using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class ConsumptionMaterialController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler apiHandler = new ApiHandler();

        public ConsumptionMaterialController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Sarf Malzeme yönetimi sayfası listeleme işlemi
        public IActionResult ConsuptionMaterialManagement(string filtre)
        {
            var Token = HttpContext.Session.GetString("token");
            var ConsuptionMaterialUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/list";
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            string CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(ConsuptionMaterialUrl, Token);
                var commonResult = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var companyResult = apiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                ConsuptionMaterialResponseModel model = new ConsuptionMaterialResponseModel();
                model.consumptionMaterialDTOs = result.dataList;
                if (filtre != null)
                {
                    model.consumptionMaterialDTOs = model.consumptionMaterialDTOs.Where(x => x.Code != null && x.Code.ToLower().Contains(filtre.ToLower()) || (x.CostPrice != null && x.CostPrice.ToLower().Contains(filtre.ToLower())) || (x.Name != null && x.Name.ToLower().Contains(filtre.ToLower()))).ToList();
                }
                model.commonDTOs = commonResult.dataList;
                model.companies = companyResult.dataList;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Sarf Malzeme girişleri
        public IActionResult ConsuptionMaterialEntriy(string filtre)
        {
            var Url = _configuration["UrlVariable"] + "ConsumptionMaterial/ListStock";
            var ConsuptionMaterialUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/list";
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            string CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            string StoreUrl = _configuration["UrlVariable"] + "Store/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(ConsuptionMaterialUrl, Token);
                var stock = apiHandler.GetAPI<DataDto<ConsumptionMaterialStockDTO>>(Url, Token);
                var commonResult = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var companyResult = apiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                var storeResult = apiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                ConsuptionMaterialResponseModel model = new ConsuptionMaterialResponseModel();
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.ExitDate == null).ToList();
                    result.dataList = result.dataList.Where(x => x.CompanyId != null).ToList();
                    result.dataList = result.dataList.Where(x => x.Companies.Name.ToLower().Contains(filtre.ToLower())).ToList();
                }
                model.consumptionMaterialDTOs = result.dataList;
                model.commonDTOs = commonResult.dataList;
                model.companies = companyResult.dataList;
                model.consumptionMaterialStocks = stock.dataList;
                model.store = storeResult.dataList;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Sarf Malzeme detay fonksiyonu
        public IActionResult consuptionMateriaManagementlDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "ConsumptionMaterial/detail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(url, Token);
                ConsumptionMaterialDTO consumptionMaterialDTO = new ConsumptionMaterialDTO();
                consumptionMaterialDTO = result.data;
                return PartialView("_detailConsuptionMaterial", consumptionMaterialDTO);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Sarf Malzeme edit popup
        public IActionResult editConsuption(int id)
        {
            var ConsuptionMaterialUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/detail/" + id;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            string CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(ConsuptionMaterialUrl, Token);
                var commonResult = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var companyResult = apiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                ConsuptionMaterialResponseModel model = new ConsuptionMaterialResponseModel();
                model.consumptionMaterial = result.data;
                model.commonDTOs = commonResult.dataList;
                model.companies = companyResult.dataList;
                return PartialView("_editConsuptionManagement", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Sarf Malzeme depo çıkışları
        public IActionResult ComsuptionMaterialStockExit()
        {
            var Url = _configuration["UrlVariable"] + "ConsumptionMaterial/ListStock";

            try
            {
                var Token = HttpContext.Session.GetString("token");
                var stock = apiHandler.GetAPI<DataDto<ConsumptionMaterialStockDTO>>(Url, Token);
                ConsuptionMaterialResponseModel model = new ConsuptionMaterialResponseModel();
                model.consumptionMaterialStocks = stock.dataList;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult ExitPartial()
        {
            var ConsuptionMaterialUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/list";
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            string CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            string StoreUrl = _configuration["UrlVariable"] + "Store/list";
            string Staffurl = _configuration["UrlVariable"] + "Staff/list/" + 1;
            var OrderList = _configuration["UrlVariable"] + "Order/listproduction";
            string StandUrl = _configuration["UrlVariable"] + "Stand/list/" + 1;
            var OrderProductionurl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(ConsuptionMaterialUrl, Token);
                var commonResult = apiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var companyResult = apiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                var storeResult = apiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                var staffResult = apiHandler.GetAPI<DataDto<StaffDTO>>(Staffurl, Token);
                var standResult = apiHandler.GetAPI<DataDto<StandDTO>>(StandUrl, Token);
                var OrderResult = apiHandler.GetAPI<DataDto<OrderDTO>>(OrderList, Token);
                var OrderProductionResult = apiHandler.GetAPI<DataDto<OrderDTO>>(OrderProductionurl, Token);
                ConsuptionMaterialResponseModel model = new ConsuptionMaterialResponseModel();
                List<OrderDTO> orders = new List<OrderDTO>();
                foreach (var item in OrderProductionResult.dataList)
                {
                    orders.Add(item);
                }
                foreach (var item in OrderResult.dataList)
                {
                    orders.Add(item);
                }
                model.consumptionMaterialDTOs = result.dataList;
                model.commonDTOs = commonResult.dataList;
                model.companies = companyResult.dataList;
                model.store = storeResult.dataList;
                model.standDTOs = standResult.dataList;
                model.orderDTOs = orders;
                model.staffDTOs = staffResult.dataList;
                return PartialView("_ExitConsuption", model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #region Sarf Malzeme yönetimi sayfası Ekleme Fonksiyonu
        public JsonResult AddConsuptionMaterial(ConsumptionMaterialDTO consumptionMaterialDTO, string[] CompanyId)
        {
            var url = _configuration["UrlVariable"] + "ConsumptionMaterial/save";
            List<ConsumptionMaterialSupplierDTO> consumptionMaterialSuppliers = new List<ConsumptionMaterialSupplierDTO>();
            int count = 0;
            foreach (var item in CompanyId)
            {
                ConsumptionMaterialSupplierDTO consumption = new ConsumptionMaterialSupplierDTO();
                foreach (var company in CompanyId.Skip(count).Take(1))
                {
                    consumption.CompanyId = Convert.ToInt32(company);
                }
                consumption.CreateDate = DateTime.Now;
                consumption.Status = 1;
                consumption.UpdateDate = DateTime.Now;
                count++;
                consumptionMaterialSuppliers.Add(consumption);
            }
            Random barcodeNo = new Random();
            Random StockNo = new Random();
            int barcodeNos = barcodeNo.Next(0, 10000);
            int StockNos = StockNo.Next(0, 10000);
            ConsumptionMaterialDTO consumptionMaterial = new ConsumptionMaterialDTO()
            {
                Code = consumptionMaterialDTO.Code,
                ConsumptionMaterialSuppliers = consumptionMaterialSuppliers,
                UpdateDate = DateTime.Now,
                CreateDate = DateTime.Now,
                BarcodeNo = barcodeNos.ToString(),
                UnitsOfMeasureId = consumptionMaterialDTO.UnitsOfMeasureId,
                CostPrice = consumptionMaterialDTO.CostPrice,
                MinStockQuantity = consumptionMaterialDTO.MinStockQuantity,
                CurrencyId = consumptionMaterialDTO.CurrencyId,
                Name = consumptionMaterialDTO.Name,
                Status = 1,
                StockNo = StockNos.ToString()
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<DataDto<ConsumptionMaterialDTO>>(consumptionMaterial, url, Token);
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
        #region Sarf Malzeme Depoya giriş Ekleme Fonksiyonu
        public JsonResult AddMaterialStock(ConsumptionMaterialStockDTO consumptionMaterialStock)
        {
            var url = _configuration["UrlVariable"] + "ConsumptionMaterial/saveStock";
            ConsumptionMaterialStockDTO materialStockDTO = new ConsumptionMaterialStockDTO()
            {
                CompanyId = consumptionMaterialStock.CompanyId,
                ConsumptionMaterialAddress = consumptionMaterialStock.ConsumptionMaterialAddress,
                ConsumptionMaterialId = consumptionMaterialStock.ConsumptionMaterialId,
                CreateDate = DateTime.Now,
                EntryDate = DateTime.Now,
                Quantity = consumptionMaterialStock.Quantity,
                Status = 1,
                StoreId = consumptionMaterialStock.StoreId,
                UpdateDate = DateTime.Now,
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.PostAPIWithModel<ConsumptionMaterialStockDTO>(materialStockDTO, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Sarf Malzem depo çıkış Fonksiyonu
        public JsonResult ExitMaterialStock(ConsumptionMaterialStockDTO consumptionMaterialStockDTO)
        {

            var stockUpdateUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/saveStock";
            try
            {

                ConsumptionMaterialStockDTO stockDTO = new ConsumptionMaterialStockDTO()
                {
                    ConsumptionMaterialId = consumptionMaterialStockDTO.ConsumptionMaterialId,
                    CreateDate = DateTime.Now,
                    DeliveryNote = consumptionMaterialStockDTO.DeliveryNote,
                    ExitDate = DateTime.Now,
                    Quantity = consumptionMaterialStockDTO.Quantity,
                    StaffId = consumptionMaterialStockDTO.StaffId,
                    Status = 1,
                    UpdateDate = DateTime.Now,
                    StandId = consumptionMaterialStockDTO.StandId,
                    OrderId = consumptionMaterialStockDTO.OrderId
                };
                var Token = HttpContext.Session.GetString("token");
                var PostResult = apiHandler.PostAPIWithModel<ConsumptionMaterialStockDTO>(stockDTO, stockUpdateUrl, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Sarf Malzeme güncelleme Fonksiyonu
        public JsonResult editConsuptionMaterial(ConsumptionMaterialDTO consumptionMaterial, string[] CompanyId)
        {
            var url = _configuration["UrlVariable"] + "ConsumptionMaterial/update";
            var ConsuptionMaterialUrl = _configuration["UrlVariable"] + "ConsumptionMaterial/detail/" + consumptionMaterial.Id;
            List<ConsumptionMaterialSupplierDTO> consumptionMaterialSupplierDTOs = new List<ConsumptionMaterialSupplierDTO>();
            int count = 0;
            foreach (var item in CompanyId)
            {
                ConsumptionMaterialSupplierDTO supplierDTO = new ConsumptionMaterialSupplierDTO();
                foreach (var company in CompanyId.Skip(count).Take(1))
                {
                    supplierDTO.CompanyId = Convert.ToInt32(company);
                }
                supplierDTO.CreateDate = DateTime.Now;
                supplierDTO.Status = 1;
                supplierDTO.UpdateDate = DateTime.Now;
                count++;
                consumptionMaterialSupplierDTOs.Add(supplierDTO);
            }
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = apiHandler.GetAPI<DataDto<ConsumptionMaterialDTO>>(ConsuptionMaterialUrl, Token);
                consumptionMaterial.BarcodeNo = result.data.BarcodeNo;
                consumptionMaterial.StockNo = result.data.StockNo;
                consumptionMaterial.CreateDate = result.data.CreateDate;
                consumptionMaterial.UpdateDate = DateTime.Now;
                consumptionMaterial.Status = 1;
                consumptionMaterial.ConsumptionMaterialSuppliers = consumptionMaterialSupplierDTOs;

                var postModel = apiHandler.PostAPIWithModel<ConsumptionMaterialDTO>(consumptionMaterial, url, Token);
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