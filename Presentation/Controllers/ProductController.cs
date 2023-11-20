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
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Ürünler listeleme sayfası
        public IActionResult Product(string filtre)
        {
            var Url = _configuration["UrlVariable"] + "Category/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CategoryResult = ApiHandler.GetAPI<DataDto<CategoryDTO>>(Url, Token);
                return View(CategoryResult.dataList);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult ProductMainList(string text, int category)
        {
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var url = _configuration["UrlVariable"] + "Product/ListCategory/" + category;
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                if (text != null)
                {
                    result.dataList = result.dataList.Where(x => x.BarcodeNo != null && x.BarcodeNo.ToLower().Contains(text.ToLower())
                      || (x.Name != null && x.Name.ToLower().Contains(text.ToLower()))).ToList();
                }
                return PartialView("_ProductMainList", result.dataList);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        public IActionResult ProductInfo(int id)
        {
            var url = _configuration["UrlVariable"] + "Product/get/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                ProductDTO productDTO = new ProductDTO();
                productDTO = result.data;
                return View(productDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #region Yönetim ürün reçetesi sayfası
        public IActionResult ProductManagement(string filtre, bool special = false)
        {
            var Url = _configuration["UrlVariable"] + "Category/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CategoryResult = ApiHandler.GetAPI<DataDto<CategoryDTO>>(Url, Token);
                return View(CategoryResult.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult ProductList(bool special, string text, int category)
        {
            var url = _configuration["UrlVariable"] + "Product/ListCategory/" + category;
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                var type = 1;
                if (special != true)
                {
                    result.dataList = result.dataList.Where(x => x.ProductType == type).ToList();
                }
                if (text != null)
                {
                    result.dataList = result.dataList.Where(x => x.BarcodeNo != null && x.BarcodeNo.ToLower().Contains(text.ToLower())
                      || (x.Name != null && x.Name.ToLower().Contains(text.ToLower()))).ToList();
                }
                return PartialView("_ProductList", result.dataList);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region Ürün reçetesi ekleme sayfası
        [HttpGet]
        public IActionResult AddProductRecipe()
        {
            var CategoryUrl = _configuration["UrlVariable"] + "Category/list/" + 1;
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var ProcessUrl = _configuration["UrlVariable"] + "Process/list/" + 1;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CategoryResult = ApiHandler.GetAPI<DataDto<CategoryDTO>>(CategoryUrl, Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var ProccessResult = ApiHandler.GetAPI<DataDto<ProcessDTO>>(ProcessUrl, Token);
                var commonList = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                ProductResponseModel responseModel = new ProductResponseModel();
                responseModel.categoryDTOs = CategoryResult.dataList;
                responseModel.materialDTOs = MaterialResult.dataList;
                responseModel.processDTOs = ProccessResult.dataList;
                responseModel.commonDTOs = commonList.dataList;
                return View(responseModel);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Ürün reçetesi güncelleme sayfası
        [HttpGet]
        public IActionResult EditProductRecipe(int id)
        {
            var CategoryUrl = _configuration["UrlVariable"] + "Category/list/" + 1;
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var ProcessUrl = _configuration["UrlVariable"] + "Process/list/" + 1;
            var url = _configuration["UrlVariable"] + "Product/get/" + id;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CategoryResult = ApiHandler.GetAPI<DataDto<CategoryDTO>>(CategoryUrl, Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var ProccessResult = ApiHandler.GetAPI<DataDto<ProcessDTO>>(ProcessUrl, Token);
                var productResult = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                var commonList = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                ProductResponseModel responseModel = new ProductResponseModel();
                responseModel.product = productResult.data;
                responseModel.categoryDTOs = CategoryResult.dataList;
                responseModel.materialDTOs = MaterialResult.dataList;
                responseModel.processDTOs = ProccessResult.dataList;
                responseModel.commonDTOs = commonList.dataList;
                return View(responseModel);
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
        #endregion
        #region Ürün Reçetesi ekleme sayfası post işlemi
        [HttpPost]
        public IActionResult AddProductRecipe(ProductDTO productDTO, IFormFile technicalDocument, IFormFile technicalDrawing, string[] ProcessOrderNo, string[] ProcessDuration, string[] ProcessId, string[] Count, string[] MaterialId)
        {
            var url = _configuration["UrlVariable"] + "Product/save";
            List<ProductProcessDTO> productProcesses = new List<ProductProcessDTO>();
            List<ProductMaterialDTO> materialDTO = new List<ProductMaterialDTO>();
            List<ProductDocumentDTO> productDocuments = new List<ProductDocumentDTO>();
            List<DocumentDTO> documentDTOs = new List<DocumentDTO>();
            try
            {
                //ProductProccess
                var ProccesCount = 0;
                foreach (var items in ProcessId)
                {
                    foreach (var item in ProcessId.Skip(ProccesCount).Take(1))
                    {
                        ProductProcessDTO proccess = new ProductProcessDTO();
                        foreach (var ProcessOrder in ProcessOrderNo.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessOrderNo = Convert.ToInt32(ProcessOrder);
                        }
                        foreach (var ProcessDurations in ProcessDuration.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessDuration = Convert.ToInt32(ProcessDurations);
                        }
                        proccess.ProcessId = Convert.ToInt32(item);
                        proccess.CreateDate = DateTime.Now;
                        proccess.Status = 1;
                        proccess.UpdateDate = DateTime.Now;
                        productProcesses.Add(proccess);
                    }
                    ProccesCount++;
                }
                //ProductMaterial
                var MaterialCount = 0;
                foreach (var item in MaterialId)
                {
                    foreach (var Material in MaterialId.Skip(MaterialCount).Take(1))
                    {
                        ProductMaterialDTO productMaterial = new ProductMaterialDTO();
                        foreach (var Counts in Count.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.Count = Convert.ToInt32(Counts);
                        }
                        foreach (var materialId in MaterialId.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.MaterialId = Convert.ToInt32(materialId);
                        }
                        productMaterial.CreateDate = DateTime.Now;
                        productMaterial.Status = 1;
                        productMaterial.UpdateDate = DateTime.Now;
                        materialDTO.Add(productMaterial);
                    }
                    MaterialCount++;
                }
                //ProductImage
                if (technicalDrawing != null)
                {
                    string[] fileExtensions = new string[] { "image/jpg", "image/png", "image/jpeg" };
                    string imageExtension = Path.GetExtension(technicalDrawing.FileName);
                    string fileName = technicalDrawing.FileName;
                    if (fileExtensions.Contains(technicalDrawing.ContentType))
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Images/{fileName}");
                        var urlPath = $"wwwroot/Images/{fileName}";
                        using var stream = new FileStream(path, FileMode.Create);
                        technicalDrawing.CopyTo(stream);
                        documentDTOs.Add(new DocumentDTO()
                        {
                            Name = fileName,
                            Type = imageExtension,
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            Path = path,
                            UrlPath = urlPath,
                            Status = 1
                        });

                    }

                }
                //ProductDocument
                if (technicalDocument != null)
                {
                    var fileName = technicalDocument.FileName;
                    var fileExtension = Path.GetExtension(technicalDocument.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Documents/{fileName}");
                    var urlPath = $"wwwroot/Documents/{fileName}";
                    using var stream = new FileStream(path, FileMode.Create);
                    technicalDocument.CopyTo(stream);
                    documentDTOs.Add(new DocumentDTO()
                    {
                        Name = fileName,
                        Type = fileExtension,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        UrlPath = urlPath,
                        Path = path,
                        Status = 1
                    });
                }
                Random random = new Random();
                int barcode = random.Next(0, 100000);
                int seerialNumber = random.Next(0, 100000);
                int InvoiceNo = random.Next(0, 100000);
                ProductDTO product = new ProductDTO()
                {
                    Count = 1,
                    EntryDate = DateTime.Now,
                    ExitDate = DateTime.Now,
                    Hour = 1,
                    InvoiceDate = DateTime.Now,
                    InvoiceNo = InvoiceNo.ToString(),
                    IsPrescriptions = true,
                    Minute = 1,
                    ProductCost = "123",
                    Second = 1,
                    ProductAddress = "depo 1",
                    ProductCertificate = "sertifika",
                    TechnicalImage = "teknik resim",
                    ProductionSerialNumber = seerialNumber.ToString(),
                    ProductType = productDTO.ProductType,
                    BarcodeNo = barcode.ToString(),
                    CategoryId = productDTO.CategoryId,
                    CreateDate = DateTime.Now,
                    Name = productDTO.Name,
                    ProductDescription = productDTO.ProductDescription,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    productProcessDTOs = productProcesses,
                    productMaterialDTOs = materialDTO,
                    documentDTOs = documentDTOs

                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<ProductDTO>(product, url, Token);
                return RedirectToAction("ProductManagement");
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
        #endregion
        #region Ürün Reçetesi Detay Sayfası 
        public IActionResult productPrescriptionManagement(int id)
        {
            var url = _configuration["UrlVariable"] + "Product/get/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                ProductDTO product = new ProductDTO();
                product = result.data;
                return View(product);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        public IActionResult productPrescription(int id)
        {
            var url = _configuration["UrlVariable"] + "Product/get/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                ProductDTO product = new ProductDTO();
                product = result.data;
                return View(product);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #region Ürün Reçetesi Günceleme post işlemi
        [HttpPost]
        public IActionResult editProductRecipe(ProductDTO productDTO,
            IFormFile technicalDocument,
            IFormFile technicalDrawing,
            string[] ProcessOrderNo, string[] ProcessDuration, string[] ProcessId, string[] Count, string[] MaterialId)
        {
            var url = _configuration["UrlVariable"] + "Product/update";
            List<ProductProcessDTO> productProcesses = new List<ProductProcessDTO>();
            List<ProductMaterialDTO> materialDTO = new List<ProductMaterialDTO>();
            List<ProductDocumentDTO> productDocuments = new List<ProductDocumentDTO>();
            List<DocumentDTO> documentDTOs = new List<DocumentDTO>();
            try
            {
                var ProccesCount = 0;
                foreach (var items in ProcessId)
                {
                    foreach (var item in ProcessId.Skip(ProccesCount).Take(1))
                    {
                        ProductProcessDTO proccess = new ProductProcessDTO();
                        foreach (var ProcessOrder in ProcessOrderNo.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessOrderNo = Convert.ToInt32(ProcessOrder);
                        }
                        foreach (var ProcessDurations in ProcessDuration.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessDuration = Convert.ToInt32(ProcessDurations);
                        }
                        proccess.ProcessId = Convert.ToInt32(item);
                        proccess.CreateDate = DateTime.Now;
                        proccess.Status = 1;
                        proccess.UpdateDate = DateTime.Now;
                        productProcesses.Add(proccess);
                    }
                    ProccesCount++;
                }
                var MaterialCount = 0;
                foreach (var item in MaterialId)
                {
                    foreach (var Material in MaterialId.Skip(MaterialCount).Take(1))
                    {
                        ProductMaterialDTO productMaterial = new ProductMaterialDTO();
                        foreach (var Counts in Count.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.Count = Convert.ToInt32(Counts);
                        }
                        foreach (var materialId in MaterialId.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.MaterialId = Convert.ToInt32(materialId);
                        }
                        productMaterial.CreateDate = DateTime.Now;
                        productMaterial.Status = 1;
                        productMaterial.UpdateDate = DateTime.Now;
                        materialDTO.Add(productMaterial);
                    }
                    MaterialCount++;
                }
                if (technicalDrawing != null)
                {
                    string[] fileExtensions = new string[] { "image/jpg", "image/png", "image/jpeg" };
                    string imageExtension = Path.GetExtension(technicalDrawing.FileName);
                    string fileName = technicalDrawing.FileName;
                    if (fileExtensions.Contains(technicalDrawing.ContentType))
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Images/{fileName}");
                        var urlPath = $"wwwroot/Images/{fileName}";
                        using var stream = new FileStream(path, FileMode.Create);
                        technicalDrawing.CopyTo(stream);
                        documentDTOs.Add(new DocumentDTO()
                        {
                            Name = fileName,
                            Type = imageExtension,
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            Path = path,
                            UrlPath = urlPath,
                            Status = 1
                        });

                    }

                }
                if (technicalDocument != null)
                {
                    var fileName = technicalDocument.FileName;
                    var fileExtension = Path.GetExtension(technicalDocument.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Documents/{fileName}");
                    var urlPath = $"wwwroot/Documents/{fileName}";
                    using var stream = new FileStream(path, FileMode.Create);
                    technicalDocument.CopyTo(stream);
                    documentDTOs.Add(new DocumentDTO()
                    {
                        Name = fileName,
                        Type = fileExtension,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        UrlPath = urlPath,
                        Path = path,
                        Status = 1
                    });
                }
                ProductDTO product = new ProductDTO()
                {
                    CategoryId = productDTO.CategoryId,
                    Name = productDTO.Name,
                    ProductDescription = productDTO.ProductDescription,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    productProcessDTOs = productProcesses,
                    productMaterialDTOs = materialDTO,
                    documentDTOs = documentDTOs,
                    Id = productDTO.Id
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<ProductDTO>(product, url, Token);
                return RedirectToAction("ProductManagement");
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Ürün Girişleri Sayfası
        public IActionResult productEntries(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var urls = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                var Results = ApiHandler.GetAPI<DataDto<OrderDTO>>(urls, Token);
                List<OrderDTO> order = new List<OrderDTO>();
                order = result.dataList;
                foreach (var item in Results.dataList)
                {
                    order.Add(item);
                }
                if (filtre != null)
                {
                    order = order.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(filtre.ToLower())
                    || (x.OrderCustomerNo != null && x.OrderCustomerNo.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(order);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Ürün giriş sayfası ürünlere git butonu
        public IActionResult ProductStockEntry(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO orderDTO = new OrderDTO();
                orderDTO = result.data;
                return View(orderDTO);
            }
            catch (System.Exception)
            {
                return null;
            }

        }
        #endregion
        #region Ürün girişi yap popup
        public IActionResult ProductEntryModal(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/getOrderProducts/" + id;
            var StoreUrl = _configuration["UrlVariable"] + "Store/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                ProductResponseModel model = new ProductResponseModel();
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                var StoreResult = ApiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                model.StoreDTO = StoreResult.dataList;
                model.orderProduct = result.data;
                return PartialView("_ProductEntryModal", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Ürün Girişi sayfası PopUp post fonksiyonu
        public JsonResult UpdateProductStock(ProductStockDTO productStock)
        {
            var url = _configuration["UrlVariable"] + "Product/AddProductStock";
            try
            {
                Random random = new Random();
                var Rnd = random.Next(0, 10000);
                ProductStockDTO stockDTO = new ProductStockDTO()
                {
                    CreateDate = DateTime.Now,
                    EntryDate = DateTime.Now,
                    ProductAddress = productStock.ProductAddress,
                    StockProductQuantity = productStock.StockProductQuantity,
                    StoreId = productStock.StoreId,
                    Status = 1,
                    UpdateDate = DateTime.Now,
                    ProductId = productStock.ProductId,
                    UniqueNo = Rnd.ToString()
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<ProductStockDTO>>(stockDTO, url, Token);
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
        #endregion
        #region Reçetesi sonradan oluşturulacak özel ürün listesi
        public IActionResult SpecialProductPrescriptionsList(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Product/ListSpecialProduct";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<SpeacialProductDescriptionDTO>>(url, Token);
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.Name != null && x.Name.ToLower().Contains(filtre.ToLower())
              || (x.Quantitiy != null && x.Quantitiy.ToString().ToLower().Contains(filtre.ToLower()))
              || (x.SpecialProductDescription != null && x.SpecialProductDescription.ToLower().Contains(filtre.ToLower()))).ToList();
                }
                return View(result.dataList);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Özel ürün reçetesi tanımlama sayfası
        public IActionResult SpecialProductPrescriptionsAdd(int id)
        {
            var CategoryUrl = _configuration["UrlVariable"] + "Category/list/" + 1;
            var MaterialUrl = _configuration["UrlVariable"] + "Material/list";
            var ProcessUrl = _configuration["UrlVariable"] + "Process/list/" + 1;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            ViewBag.SpecialId = id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var CategoryResult = ApiHandler.GetAPI<DataDto<CategoryDTO>>(CategoryUrl, Token);
                var MaterialResult = ApiHandler.GetAPI<DataDto<MaterialDTO>>(MaterialUrl, Token);
                var ProccessResult = ApiHandler.GetAPI<DataDto<ProcessDTO>>(ProcessUrl, Token);
                var commonList = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                ProductResponseModel responseModel = new ProductResponseModel();
                responseModel.categoryDTOs = CategoryResult.dataList;
                responseModel.materialDTOs = MaterialResult.dataList;
                responseModel.processDTOs = ProccessResult.dataList;
                responseModel.commonDTOs = commonList.dataList;
                return View(responseModel);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Özel Ürün reçetesi tanımlama sayfası post işlemi
        [HttpPost]
        public IActionResult SpecialProductPrescriptionsAdd(ProductDTO productDTO, IFormFile technicalDocument, IFormFile technicalDrawing, string[] ProcessOrderNo, string[] ProcessDuration, string[] ProcessId, string[] Count, string[] UnitMeasureId, string[] MaterialId, int SpecialId)
        {
            var url = _configuration["UrlVariable"] + "Product/save";
            var SpecialUrl = _configuration["UrlVariable"] + "Product/GetBySpecialId/" + SpecialId;

            var SpecialPostUrl = _configuration["UrlVariable"] + "Product/UpdateSpecialProduct";
            List<ProductProcessDTO> productProcesses = new List<ProductProcessDTO>();
            List<ProductMaterialDTO> materialDTO = new List<ProductMaterialDTO>();
            List<ProductDocumentDTO> productDocuments = new List<ProductDocumentDTO>();
            List<DocumentDTO> documentDTOs = new List<DocumentDTO>();
            try
            {

                //ProductProccess
                var ProccesCount = 0;
                foreach (var items in ProcessId)
                {
                    foreach (var item in ProcessId.Skip(ProccesCount).Take(1))
                    {
                        ProductProcessDTO proccess = new ProductProcessDTO();
                        foreach (var ProcessOrder in ProcessOrderNo.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessOrderNo = Convert.ToInt32(ProcessOrder);
                        }
                        foreach (var ProcessDurations in ProcessDuration.Skip(ProccesCount).Take(1))
                        {
                            proccess.ProcessDuration = Convert.ToInt32(ProcessDurations);
                        }
                        proccess.ProcessId = Convert.ToInt32(item);
                        proccess.CreateDate = DateTime.Now;
                        proccess.Status = 1;
                        proccess.UpdateDate = DateTime.Now;
                        productProcesses.Add(proccess);
                    }
                    ProccesCount++;
                }
                //ProductMaterial
                var MaterialCount = 0;
                foreach (var item in MaterialId)
                {
                    foreach (var Material in MaterialId.Skip(MaterialCount).Take(1))
                    {
                        ProductMaterialDTO productMaterial = new ProductMaterialDTO();
                        foreach (var Counts in Count.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.Count = Convert.ToInt32(Counts);
                        }
                        foreach (var UnitMeasure in UnitMeasureId.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.HeightMeasureId = Convert.ToInt32(UnitMeasure);

                        }
                        foreach (var materialId in MaterialId.Skip(MaterialCount).Take(1))
                        {
                            productMaterial.MaterialId = Convert.ToInt32(materialId);
                        }
                        productMaterial.CreateDate = DateTime.Now;
                        productMaterial.Status = 1;
                        productMaterial.UpdateDate = DateTime.Now;
                        materialDTO.Add(productMaterial);
                    }
                    MaterialCount++;
                }
                //ProductImage
                if (technicalDrawing != null)
                {
                    string[] fileExtensions = new string[] { "image/jpg", "image/png", "image/jpeg" };
                    string imageExtension = Path.GetExtension(technicalDrawing.FileName);
                    string fileName = technicalDrawing.FileName;
                    if (fileExtensions.Contains(technicalDrawing.ContentType))
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Images/{fileName}");
                        var urlPath = $"wwwroot/Images/{fileName}";
                        using var stream = new FileStream(path, FileMode.Create);
                        technicalDrawing.CopyTo(stream);
                        documentDTOs.Add(new DocumentDTO()
                        {
                            Name = fileName,
                            Type = imageExtension,
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            Path = path,
                            UrlPath = urlPath,
                            Status = 1
                        });

                    }

                }
                //ProductDocument
                if (technicalDocument != null)
                {
                    var fileName = technicalDocument.FileName;
                    var fileExtension = Path.GetExtension(technicalDocument.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Documents/{fileName}");
                    var urlPath = $"wwwroot/Documents/{fileName}";
                    using var stream = new FileStream(path, FileMode.Create);
                    technicalDocument.CopyTo(stream);
                    documentDTOs.Add(new DocumentDTO()
                    {
                        Name = fileName,
                        Type = fileExtension,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        UrlPath = urlPath,
                        Path = path,
                        Status = 1
                    });
                }
                Random random = new Random();
                int barcode = random.Next(0, 100000);
                ProductDTO product = new ProductDTO()
                {
                    Count = 1,
                    EntryDate = DateTime.Now,
                    ExitDate = DateTime.Now,
                    Hour = 1,
                    InvoiceDate = DateTime.Now,
                    InvoiceNo = "1234",
                    IsPrescriptions = true,
                    Minute = 1,
                    ProductCost = "123",
                    Second = 1,
                    ProductAddress = "depo 1",
                    ProductCertificate = "sertifika",
                    TechnicalImage = "teknik resim",
                    ProductionSerialNumber = "1",
                    ProductType = productDTO.ProductType,
                    //yukarıdaki kısım elle girildi
                    BarcodeNo = barcode.ToString(),
                    CategoryId = productDTO.CategoryId,
                    CreateDate = DateTime.Now,
                    Name = productDTO.Name,
                    ProductDescription = productDTO.ProductDescription,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    productProcessDTOs = productProcesses,
                    productMaterialDTOs = materialDTO,
                    documentDTOs = documentDTOs

                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<ProductDTO>(product, url, Token);
                var SpecialResult = ApiHandler.GetAPI<DataDto<SpeacialProductDescriptionDTO>>(SpecialUrl, Token);
                SpeacialProductDescriptionDTO speacial = new SpeacialProductDescriptionDTO();
                speacial = SpecialResult.data;
                speacial.Status = 2;
                speacial.UpdateDate = DateTime.Now;
                var specialPostResult = ApiHandler.PostAPIWithModel<SpeacialProductDescriptionDTO>(speacial, SpecialPostUrl, Token);
                return RedirectToAction("ProductManagement");
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Ürün Stok Sayfası
        public IActionResult ProductStock(int id)
        {
            var url = _configuration["UrlVariable"] + "Product/ProductStockList/" + id;
            var OrderProductionurl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            var Orderurl = _configuration["UrlVariable"] + "Order/listproduction";
            List<OrderDTO> orders = new List<OrderDTO>();
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                var ProductionResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderProductionurl, Token);
                var OrderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(Orderurl, Token);
                ProductDTO product = new ProductDTO();
                foreach (var item in ProductionResult.dataList)
                {
                    foreach (var op in item.OrderProducts.Where(x => x.ProductId == id))
                    {
                        orders.Add(item);
                    }
                }
                foreach (var item in OrderResult.dataList)
                {
                    foreach (var op in item.OrderProducts.Where(x => x.ProductId == id))
                    {
                        orders.Add(item);
                    }
                }
                product = result.dataList.FirstOrDefault();
                var model = (product, orders);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Benzersiz ürün listesi
        public IActionResult SpecialProductList(int id, string filtre)
        {
            var url = _configuration["UrlVariable"] + "Product/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                result.dataList = result.dataList.Where(x => x.Id == id).ToList();
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.ProductionSerialNumber != null && x.ProductionSerialNumber.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(result.dataList);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Benzersiz Ürün Detayı
        public IActionResult GetSpecialProductDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "Product/get/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(url, Token);
                return View(result.data);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}
