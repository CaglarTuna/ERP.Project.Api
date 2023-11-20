using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
namespace Presentation.Controllers
{
    [ActionFilters]
    public class MaterialController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public MaterialController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Malzeme yönetimi sayfası
        public IActionResult MaterialManagement(string filtre)
        {
            string url = _configuration["UrlVariable"] + "Material/list";
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialDTO>>(url, Token);
                var CommonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                List<MaterialDTO> materialDTOs = new List<MaterialDTO>();
                List<CommonDTO> commonDTOs = new List<CommonDTO>();
                materialDTOs = result.dataList;
                commonDTOs = CommonResult.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    materialDTOs = materialDTOs.Where(x => x.Code != null && x.Code.ToLower().Contains(filtre.ToLower())
                     || (x.Name != null && x.Name.ToLower().Contains(filtre.ToLower()))
                     || (x.MaterialShape.Name != null && x.MaterialShape.Name.ToLower().Contains(filtre.ToLower()))
                     || (x.CostPrice != null && x.CostPrice.ToLower().Contains(filtre.ToLower()))
                     || (x.BarcodeNo != null && x.BarcodeNo.ToLower().Contains(filtre.ToLower()))
                     || (x.StockNo != null && x.StockNo.ToLower().Contains(filtre.ToLower()))
                     || (x.MinStockQuantity.ToString() != null && x.MinStockQuantity.ToString().ToLower().Contains(filtre.ToLower()))

                    ).ToList();
                }
                var model = (materialDTOs, commonDTOs);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion

        public JsonResult materialDetailManagement(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/detail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialDTO>>(url, Token);
                MaterialDTO materialDTO = new MaterialDTO();
                materialDTO = result.data;
                return Json(materialDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #region Malzeme sertifika silme fonkiyonu
        public JsonResult deleteCertificate(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/certificateMissingMaterial/delete";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                MaterialCertificatesDTO materialCertificates = new MaterialCertificatesDTO();
                materialCertificates.Id = id;
                var result = ApiHandler.PostAPIWithModel<MaterialCertificatesDTO>(materialCertificates, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Malzeme sertifika sayfası
        public IActionResult MaterialCertificate(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/certificateMissingMaterial/list/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialCertificatesDTO>>(url, Token);
                List<MaterialCertificatesDTO> materialCertificatesDTO = new List<MaterialCertificatesDTO>();
                materialCertificatesDTO = result.dataList;
                ViewBag.MaterialId = id;
                return View(materialCertificatesDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Malzeme ekleme fonksiyonu
        public JsonResult AddMaterial(MaterialDTO material, string[] compony, string[] rawMaterial)
        {
            string url = _configuration["UrlVariable"] + "Material/save";
            Random barcode = new Random();
            Random stockNo = new Random();
            int BarcodeNo = barcode.Next(0, 10000);
            int stock = stockNo.Next(0, 10000);
            List<MaterialSupplierDTO> materialSuppliers = new List<MaterialSupplierDTO>();
            List<MaterialRawMaterialDTO> rawMaterialDTOs = new List<MaterialRawMaterialDTO>();
            foreach (var item in compony)
            {
                materialSuppliers.Add(new MaterialSupplierDTO()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CompanyId = Convert.ToInt32(item)
                });
            }
            foreach (var item in rawMaterial)
            {
                rawMaterialDTOs.Add(new MaterialRawMaterialDTO()
                {
                    CreateDate = DateTime.Now,
                    RawMaterialId = Convert.ToInt32(item),
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            MaterialDTO materialDTO = new MaterialDTO()
            {
                Code = material.Code,
                Name = material.Name,
                PurchasingUnitId = material.PurchasingUnitId,
                UnitsOfMeasureId = material.UnitsOfMeasureId,
                BarcodeNo = BarcodeNo.ToString(),
                StockNo = stock.ToString(),
                Diameter = material.Diameter,
                Length = material.Length,
                Meter = material.Meter,
                CostPrice = material.CostPrice,
                MinStockQuantity = material.MinStockQuantity,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                materialSupplierDTOs = materialSuppliers,
                materialRawMaterial = rawMaterialDTOs,
                CurrencyId = material.CurrencyId,
                ShapeId = material.ShapeId,
                HeightMeasureId = material.HeightMeasureId,
                Status = 1
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<MaterialDTO>(materialDTO, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Malzeme stok Çıkışları
        public IActionResult MaterialStockExit(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Material/listExpert";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialExpertDeliverysDTO>>(url, Token);
                List<MaterialExpertDeliverysDTO> materialExpertDeliverysDTOs = new List<MaterialExpertDeliverysDTO>();
                materialExpertDeliverysDTOs = result.dataList;
                if (filtre != null)
                {
                    materialExpertDeliverysDTOs = materialExpertDeliverysDTOs.Where(x => x.Materials.Name != null && x.Materials.Name.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(materialExpertDeliverysDTOs);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult OrderMaterialExit(int id, int orderId)
        {
            var url = _configuration["UrlVariable"] + "Order/OrderWithProduct/" + id + "/" + orderId;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                return View(result.dataList);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderMaterialExpertDeliverysAdd(int id,int orderId,int productId)
        {
            var url = _configuration["UrlVariable"] + "Material/detail/" + id;
            var languageId = 1;
            string StaffUrl = _configuration["UrlVariable"] + "Staff/list/" + languageId;
            var urls = _configuration["UrlVariable"] + "Staff/GetStaffProccess/" + productId + "/" + orderId;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                MaterialResponseModel model = new MaterialResponseModel();
                var result = ApiHandler.GetAPI<DataDto<MaterialDTO>>(url, Token);
                var results = ApiHandler.GetAPI<DataDto<StaffProcessDTO>>(urls, Token);
                model.MaterialDTO = result.data;
                model.Staffs=results.dataList.Select(x=>x.StaffDTO).Distinct().ToList();
                return PartialView("_MaterialExpertDeliverys", model);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult EditMaterial(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/detail/" + id;
            var CommanUrl = _configuration["UrlVariable"] + "Common/list";
            string firma = _configuration["UrlVariable"] + "Company/list";
            string hammadde = _configuration["UrlVariable"] + "RawMaterial/list";
            MaterialResponseModel model = new MaterialResponseModel();
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialDTO>>(url, Token);
                var CommonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(CommanUrl, Token);
                var CompanyResult = ApiHandler.GetAPI<DataDto<CompanyDTO>>(firma, Token);
                var RawMaterialResult = ApiHandler.GetAPI<DataDto<RawMaterialDTO>>(hammadde, Token);
                model.Commons = CommonResult.dataList;
                model.companyDTOs = CompanyResult.dataList;
                model.MaterialDTO = result.data;
                model.rawMaterials = RawMaterialResult.dataList;
                return PartialView("_editMaterial", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult EditMaterials(MaterialDTO material, string[] compony, string[] rawMaterial)
        {
            var url = _configuration["UrlVariable"] + "Material/Update";
            var EditUrl = _configuration["UrlVariable"] + "Material/detail/" + material.Id;
            List<MaterialSupplierDTO> materialSuppliers = new List<MaterialSupplierDTO>();
            List<MaterialRawMaterialDTO> rawMaterialDTOs = new List<MaterialRawMaterialDTO>();


            foreach (var item in compony)
            {
                materialSuppliers.Add(new MaterialSupplierDTO()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CompanyId = Convert.ToInt32(item)
                });
            }
            foreach (var item in rawMaterial)
            {
                rawMaterialDTOs.Add(new MaterialRawMaterialDTO()
                {
                    CreateDate = DateTime.Now,
                    RawMaterialId = Convert.ToInt32(item),
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            MaterialDTO materialDTO = new MaterialDTO()
            {
                Code = material.Code,
                UpdateDate = DateTime.Now,
                Name = material.Name,
                Id = material.Id,
                Diameter = material.Diameter,
                Length = material.Length,
                Meter = material.Meter,
                UnitsOfMeasureId = material.UnitsOfMeasureId,
                PurchasingUnitId = material.PurchasingUnitId,
                CostPrice = material.CostPrice,
                CurrencyId = material.CurrencyId,
                MinStockQuantity = material.MinStockQuantity,
                materialSupplierDTOs = materialSuppliers,
                materialRawMaterial = rawMaterialDTOs,
                ShapeId = material.ShapeId,
                HeightMeasureId = material.HeightMeasureId,
                Status = 1,
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var GetMaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(EditUrl, Token);
                materialDTO.BarcodeNo = GetMaterialResult.data.BarcodeNo;
                materialDTO.StockNo = GetMaterialResult.data.StockNo;
                materialDTO.CreateDate = GetMaterialResult.data.CreateDate;
                var result = ApiHandler.PostAPIWithModel<DataDto<MaterialDTO>>(materialDTO, url, Token);
                if (result.statu)
                {

                    return Json(HttpStatusCode.Accepted);
                }
                else
                {
                    return Json(HttpStatusCode.NotFound);
                }

            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult MaterialDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/detail/" + id;
            string firma = _configuration["UrlVariable"] + "Company/list";
            string hammadde = _configuration["UrlVariable"] + "RawMaterial/list";
            var CommanUrl = _configuration["UrlVariable"] + "Common/list";
            MaterialResponseModel model = new MaterialResponseModel();
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CommonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(CommanUrl, Token);
                var resutl = ApiHandler.GetAPI<DataDto<MaterialDTO>>(url, Token);
                var copanyResult = ApiHandler.GetAPI<DataDto<CompanyDTO>>(firma, Token);
                var RawMaterialResult = ApiHandler.GetAPI<DataDto<RawMaterialDTO>>(hammadde, Token);
                model.MaterialDTO = resutl.data;
                model.companyDTOs = copanyResult.dataList;
                model.rawMaterials = RawMaterialResult.dataList;
                model.Commons = CommonResult.dataList;
                return PartialView("_materialDetail", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult MaterialStockEntrys(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Material/ListMaterialStock";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialStockDTO>>(url, Token);
                List<MaterialStockDTO> materialStockDTOs = new List<MaterialStockDTO>();
                materialStockDTOs = result.dataList;
                if (filtre != null)
                {
                    materialStockDTOs = materialStockDTOs.Where(x => x.InvoiceNo != null && x.InvoiceNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(materialStockDTOs);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult AddMateialStockEntys()
        {
            MaterialStockEntyrModel model = new MaterialStockEntyrModel();
            var StoreUrl = _configuration["UrlVariable"] + "Store/list";
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            var OrderUrl = _configuration["UrlVariable"] + "Order/listproduction";
            var OrderProductionurl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var Storeresult = ApiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var CompanyResult = ApiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                var OrderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderUrl, Token);
                var OrderProductionResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderProductionurl, Token);
                List<OrderDTO> orders = new List<OrderDTO>();
                foreach (var item in OrderProductionResult.dataList)
                {
                    orders.Add(item);
                }
                foreach (var item in OrderResult.dataList)
                {
                    orders.Add(item);
                }
                model.Companies = CompanyResult.dataList;
                model.Materials = MaterialResult.dataList;
                model.Stores = Storeresult.dataList;
                model.Orders = orders;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        [HttpPost]
        public IActionResult AddMateialStockEntys(MaterialStockDTO materialStockDTO, string[] Quantitiy, string[] OrderId, MaterialCertificatesDTO materialCertificatesDTO, IFormFile file)
        {
            var SaveUrl = _configuration["UrlVariable"] + "Material/SaveMaterialStock";
            List<OrderMaterialDTO> OrderMaterialDTO = new List<OrderMaterialDTO>();
            try
            {
                var Count = 0;
                foreach (var item in Quantitiy)
                {
                    OrderMaterialDTO orders = new OrderMaterialDTO();
                    foreach (var Quantity in Quantitiy.Skip(Count).Take(1))
                    {
                        orders.Quantitiy = Convert.ToInt32(Quantity);
                    }
                    foreach (var Order in OrderId.Skip(Count).Take(1))
                    {
                        orders.OrderId = Convert.ToInt32(Order);
                    }
                    orders.Status = 1;
                    orders.UpdateDate = DateTime.Now;
                    orders.CreateDate = DateTime.Now;
                    OrderMaterialDTO.Add(orders);
                    Count++;
                }
                materialStockDTO.OrderMaterials = OrderMaterialDTO;
                materialStockDTO.CreateDate = DateTime.Now;
                materialStockDTO.UpdateDate = DateTime.Now;
                materialStockDTO.Status = 1;
                materialStockDTO.EntryDate = DateTime.Now;
                var Token = HttpContext.Session.GetString("token");
                string[] fileExtensions = new string[] { "image/jpg", "image/png", "image/jpeg" };
                if (file != null)
                {
                    if (fileExtensions.Contains(file.ContentType))
                    {
                        var fileEx = file.ContentType.Split("/")[1];
                        var fileName = materialCertificatesDTO.Certificate + "." + fileEx;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/MaterialCertificate/{fileName}");
                        using var stream = new FileStream(path, FileMode.Create);
                        file.CopyTo(stream);
                        MaterialCertificatesDTO materials = new MaterialCertificatesDTO()
                        {
                            Certificate = fileName,
                            CompanyId = materialStockDTO.CompanyId,
                            CreateDate = DateTime.Now,
                            MaterialId = materialStockDTO.MaterialId,
                            UpdateDate = DateTime.Now,
                            Status = 1
                        };
                        var CertificateUrl = _configuration["UrlVariable"] + "Material/certificateMissingMaterial/save";
                        var CertifacateResult = ApiHandler.PostAPIWithModel<MaterialCertificatesDTO>(materials, CertificateUrl, Token);
                    }
                }

                var result = ApiHandler.PostAPIWithModel<MaterialStockDTO>(materialStockDTO, SaveUrl, Token);
                return RedirectToAction("MaterialStockEntrys", "Material");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult MaterialPrepared(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.Orders.OrderNo != null && x.Orders.OrderNo.ToLower().Contains(filtre.ToLower())
                    || (x.Orders.OrderCustomerNo != null && x.Orders.OrderCustomerNo.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult ReadyMaterial(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            var urls = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                result.dataList = result.dataList.Where(x => x.OrderId == id).ToList();
                foreach (var item in result.dataList)
                {
                    OrderProductDTO orderProduct = new OrderProductDTO()
                    {
                        CreateDate=item.CreateDate,
                        Id=item.Id,
                        OrderId=item.OrderId,
                        ProductId=item.ProductId,
                        Quantitiy=item.Quantitiy,
                        RealizedProduction=item.RealizedProduction,
                        Status=1,
                        StatusId=5,
                        UpdateDate=DateTime.Now,
                    };
                    var post = ApiHandler.PostAPIWithModel<DataDto<OrderProductDTO>>(orderProduct, urls, Token);
                }
                return Json(1);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IActionResult getProductMaterial(int id, int OrderId)
        {
            var url = _configuration["UrlVariable"] + "Order/OrderWithProduct/" + id + "/" + OrderId;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                return PartialView("_OrderMaterialList", result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #region Malzemenin Ustaya tesilimi
        public JsonResult AddMaterialExpertDelivery(MaterialExpertDeliverysDTO materialExpertDeliverysDTO)
        {
            var url = _configuration["UrlVariable"] + "Material/AddMaterialExpertDelivery";
            //var urls = _configuration["UrlVariable"] + "Material/ListMaterialStock";
            materialExpertDeliverysDTO.Status = 1;
            materialExpertDeliverysDTO.CreateDate = DateTime.Now;
            materialExpertDeliverysDTO.UpdateDate = DateTime.Now;
            materialExpertDeliverysDTO.DeliveryStaffId = HttpContext.Session.GetInt32("StaffId");
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<MaterialExpertDeliverysDTO>>(materialExpertDeliverysDTO, url, Token);
                if (result.statu == true)
                {

                }
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Malzeme tedarik talep listeleme fonksiyonu
        public IActionResult MaterialSupplyRequest(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            var SupplyUrl = _configuration["UrlVariable"] + "Material/MaterialSupplyRequestList";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                var supplyRequestResult = ApiHandler.GetAPI<DataDto<MaterialSupplyRequestsDTO>>(SupplyUrl, Token);
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.Orders.OrderNo != null && x.Orders.OrderNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                var model = (result.dataList, supplyRequestResult.dataList);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Malzeme tedarik talep ekleme fonksiyonu
        [HttpPost]
        public JsonResult AddMaterialSupplyRequest(MaterialSupplyRequestsDTO[] liste)
        {
            var url = _configuration["UrlVariable"] + "Material/AddMaterialSupplys";
            List<MaterialSupplyRequestsDTO> Supperlier = new List<MaterialSupplyRequestsDTO>();
            foreach (var item in liste.Where(x => x.IsChecked == true))
            {
                item.CreateDate = DateTime.Now;
                item.UpdateDate = DateTime.Now;
                item.Status = 1;
                item.SuplyStatuId = 1;
                Supperlier.Add(item);
            }
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<MaterialSupplyRequestsDTO>(Supperlier, url, Token);
                return Json(HttpStatusCode.OK);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        [HttpPost]
        public JsonResult MaterialSupplyRequestReply(MaterialSupplyRequestsDTO[] liste)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Material/MaterialSupplyRepl";
            List<MaterialSupplyRequestsDTO> Supperlier = new List<MaterialSupplyRequestsDTO>();
            foreach (var item in liste.Where(x => x.IsChecked == true))
            {
                Supperlier.Add(new MaterialSupplyRequestsDTO()
                {
                    CompanyId = item.CompanyId,
                    MaterialId = item.MaterialId,
                    Id = item.Id,
                    CreateDate = item.CreateDate,
                    OrderId = item.OrderId,
                    Quantity = item.Quantity,
                    UpdateDate = DateTime.Now,
                    SuplyStatuId = item.SuplyStatuId,
                    Status = 1,
                    RequestMadeQuantity = item.RequestMadeQuantity,
                    ApprovingStaffId = item.ApprovingStaffId,
                    RequestingStaffId = item.RequestingStaffId

                });
            }
            try
            {
                var result = ApiHandler.PostAPIWithModel<DataDto<MaterialSupplyRequestsDTO>>(Supperlier, url, Token);
                if (result.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {
                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #region satın alma birimi için malzeme tedarik talepleri listesi
        public IActionResult MaterialSupplyList(DateTime FirstDate, DateTime LastDate, string Filter)
        {
            var url = _configuration["UrlVariable"] + "Material/MaterialSupplyRequestList";
            var CompanyUrl = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialSupplyRequestsDTO>>(url, Token);
                var ComponyResult = ApiHandler.GetAPI<DataDto<CompanyDTO>>(CompanyUrl, Token);
                if (Filter != null || FirstDate != DateTime.MinValue || LastDate != DateTime.MinValue)
                {
                    result.dataList = result.dataList.Where(x => x.Materials.Name != null && x.Materials.Name.ToLower().Contains(Filter.ToLower())
                    || (x.Orders.OrderNo != null && x.Orders.OrderNo.ToLower().Contains(Filter.ToLower()))
                    || (x.CreateDate >= FirstDate || x.CreateDate <= LastDate)
                    ).ToList();

                }
                var model = (result.dataList, ComponyResult.dataList);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
