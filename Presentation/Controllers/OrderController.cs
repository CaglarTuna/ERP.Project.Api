using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Common;
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
    public class OrderController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();

        public OrderController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Satış için siparişler sayfası
        public IActionResult Order(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                List<OrderDTO> order = new List<OrderDTO>();
                order = result.dataList;
                if (filtre != null)
                {
                    order = order.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(order);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult Orders()
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var Orderurl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                var OrderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(Orderurl, Token);
                List<OrderDTO> orders = new List<OrderDTO>();
                orders = result.dataList;
                foreach (var item in OrderResult.dataList)
                {
                    orders.Add(item);
                }
                return View(orders);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderList(int OrderType, string text)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var Orderurl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                if (OrderType == 1)
                {
                    var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(Orderurl, Token);
                    return PartialView("_orderList", result.dataList);
                }
                else if (OrderType == 2)
                {
                    var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                    return PartialView("_orderList", result.dataList);
                }
                else
                {

                    var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                    var OrderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(Orderurl, Token);
                    List<OrderDTO> orders = new List<OrderDTO>();
                    orders = result.dataList;
                    foreach (var item in OrderResult.dataList)
                    {
                        orders.Add(item);
                    }
                    return PartialView("_orderList", orders);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #region Yeni Satış için sipariş ekleme sayfası
        public IActionResult AddOrder()
        {
            var orderChannelUrl = _configuration["UrlVariable"] + "Order/listOrderChannel";
            var storeListUrl = _configuration["UrlVariable"] + "Store/list";
            var componyListUrl = _configuration["UrlVariable"] + "Company/list";
            var ProductUrl = _configuration["UrlVariable"] + "Product/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var ordeChannelResult = ApiHandler.GetAPI<DataDto<OrderChannelDTO>>(orderChannelUrl, Token);
                var storeResult = ApiHandler.GetAPI<DataDto<StoreDTO>>(storeListUrl, Token);
                var componyList = ApiHandler.GetAPI<DataDto<CompanyDTO>>(componyListUrl, Token);
                var productList = ApiHandler.GetAPI<DataDto<ProductDTO>>(ProductUrl, Token);
                OrderModel model = new OrderModel();
                model.OrderChannelDTOs = ordeChannelResult.dataList;
                model.StoreDTOs = storeResult.dataList;
                model.companyDTOs = componyList.dataList;
                model.productDTOs = productList.dataList;
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Firma adresleri çağırma fonksiyonu
        public JsonResult getComponyAddress(int id)
        {
            string url = _configuration["UrlVariable"] + "Company/companyDetail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                List<CompanyAddressDTO> companyAddressDTOs = new List<CompanyAddressDTO>();
                companyAddressDTOs = result.data.CompanyAddressDTOs;
                return Json(companyAddressDTOs);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region yeni sipariş ekleme post fonksiyonu
        [HttpPost]
        public IActionResult AddOrder(OrderDTO orderDTO, MeetingRecordDTO meetingRecordDTO, string[] Count, string[] ProductId, string[] specialName, int[] SpecialQuantity, string[] SpecialProductDescription, string AddressId)
        {
            TodoSend todoSend = new TodoSend(_configuration);
            var url = _configuration["UrlVariable"] + "Order/savesale";
            List<OrderProductDTO> orderProducts = new List<OrderProductDTO>();
            var productCount = 0;
            List<SpeacialProductDescriptionDTO> speacialProductDescriptions = new List<SpeacialProductDescriptionDTO>();
            var SpecialCount = 0;
            foreach (var item in specialName)
            {
                if (item != null)
                {
                    SpeacialProductDescriptionDTO speacialProduct = new SpeacialProductDescriptionDTO();
                    foreach (var SpecialName in specialName.Skip(SpecialCount).Take(1))
                    {
                        speacialProduct.Name = SpecialName;
                    }
                    foreach (var quantity in SpecialQuantity.Skip(SpecialCount).Take(1))
                    {
                        speacialProduct.Quantitiy = Convert.ToInt32(quantity);
                    }
                    foreach (var specialDesc in SpecialProductDescription.Skip(SpecialCount).Take(1))
                    {
                        speacialProduct.SpecialProductDescription = specialDesc;
                    }
                    speacialProduct.CreateDate = DateTime.Now;
                    speacialProduct.UpdateDate = DateTime.Now;
                    speacialProduct.Status = 1;
                    SpecialCount++;
                    speacialProductDescriptions.Add(speacialProduct);
                }
            }
            foreach (var item in ProductId)
            {
                if (item != null)
                {
                    OrderProductDTO orderProductDTO = new OrderProductDTO();
                    foreach (var PID in ProductId.Skip(productCount).Take(1))
                    {
                        orderProductDTO.ProductId = Convert.ToInt32(PID);
                    }
                    foreach (var count in Count.Skip(productCount).Take(1))
                    {
                        orderProductDTO.Quantitiy = Convert.ToInt32(count);
                    }
                    orderProductDTO.CreateDate = DateTime.Now;
                    orderProductDTO.UpdateDate = DateTime.Now;
                    orderProductDTO.Status = 1;
                    orderProductDTO.StatusId = 1;
                    orderProducts.Add(orderProductDTO);
                    productCount++;
                }
            }
            MeetingRecordDTO meetingRecord = new MeetingRecordDTO()
            {
                CreateDate = DateTime.Now,
                MeetingDate = meetingRecordDTO.MeetingDate,
                MeetingNote = meetingRecordDTO.MeetingNote,
                ReminderDate = meetingRecordDTO.ReminderDate,
                ReminderNote = meetingRecordDTO.ReminderNote,
                UpdateDate = DateTime.Now,
                Status = 1,
            };
            Random random = new Random();
            var Rnd = random.Next(0, 1000);
            OrderDTO order = new OrderDTO()
            {
                AddressId = Convert.ToInt32(AddressId),
                CompanyId = orderDTO.CompanyId,
                speacialProductDescriptions = speacialProductDescriptions,
                OrderChannelId = orderDTO.OrderChannelId,
                StoreId = orderDTO.StoreId,
                UpdateDate = DateTime.Now,
                CreateDate = DateTime.Now,
                Deadline = orderDTO.Deadline,
                OrderCustomerNo = orderDTO.OrderCustomerNo,
                OrderDate = orderDTO.OrderDate,
                OrderNote = orderDTO.OrderNote,
                OrderType = 2,
                Status = 1,
                MeetingRecord = meetingRecord,
                OrderProducts = orderProducts,
                OrderStatus = 1,
                OrderNo = Rnd.ToString(),
                OrderStatuId = 1
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<OrderDTO>(order, url, Token);
                var OrderUrl = _configuration["UrlVariable"] + "Order/listproduction";
                var rsult = ApiHandler.GetAPI<DataDto<OrderDTO>>(OrderUrl, Token);
                int[] role = { 1 };
                var results = todoSend.TodoSendList("Yeni Sipariş Kontrolü Sağlanacak", role, rsult.dataList.OrderByDescending(x => x.Id).FirstOrDefault().Id, Token);
                return RedirectToAction("Orders", "Order");
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Üretim Siparişleri Sayfası
        public IActionResult OrderProduction(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                List<OrderDTO> order = new List<OrderDTO>();
                order = result.dataList;
                if (filtre != null)
                {
                    order = order.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(order);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public IActionResult OrderProductionDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO order = new OrderDTO();
                order = result.dataList.Where(x => x.Id == id).FirstOrDefault();
                return PartialView("_OrderProductDetail", order);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult AddOrderProduction()
        {
            var StoreUrl = _configuration["UrlVariable"] + "Store/list";
            var productUrl = _configuration["UrlVariable"] + "Product/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var storeResult = ApiHandler.GetAPI<DataDto<StoreDTO>>(StoreUrl, Token);
                var productResult = ApiHandler.GetAPI<DataDto<ProductDTO>>(productUrl, Token);
                List<ProductDTO> productDTOs = new List<ProductDTO>();
                List<StoreDTO> storeDTOs = new List<StoreDTO>();
                productDTOs = productResult.dataList;
                storeDTOs = storeResult.dataList;
                var model = (productDTOs, storeDTOs);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        [HttpPost]
        public IActionResult AddOrderProduction(string StoreId, string[] specialName, int[] SpecialQuantity, string[] SpecialProductDescription, string[] ProductId, string[] Quantitiy)
        {
            var url = _configuration["UrlVariable"] + "Order/saveproduction";
            List<OrderProductDTO> orderProductDTOs = new List<OrderProductDTO>();
            var productCount = 0;
            foreach (var item in ProductId)
            {
                OrderProductDTO orderProductDTO = new OrderProductDTO();
                foreach (var product in ProductId.Skip(productCount).Take(1))
                {
                    orderProductDTO.ProductId = Convert.ToInt32(product);
                }
                foreach (var q in Quantitiy.Skip(productCount).Take(1))
                {
                    orderProductDTO.Quantitiy = Convert.ToInt32(q);
                }
                orderProductDTO.CreateDate = DateTime.Now;
                orderProductDTO.Status = 1;
                orderProductDTO.UpdateDate = DateTime.Now;
                orderProductDTO.StatusId = 1;
                orderProductDTOs.Add(orderProductDTO);
                productCount++;
            }
            List<SpeacialProductDescriptionDTO> speacialProductDescriptions = new List<SpeacialProductDescriptionDTO>();
            var SpecialCount = 0;
            foreach (var item in specialName)
            {
                SpeacialProductDescriptionDTO speacialProduct = new SpeacialProductDescriptionDTO();
                foreach (var SpecialName in specialName.Skip(SpecialCount).Take(1))
                {
                    speacialProduct.Name = SpecialName;
                }
                foreach (var quantity in SpecialQuantity.Skip(SpecialCount).Take(1))
                {
                    speacialProduct.Quantitiy = Convert.ToInt32(quantity);
                }
                foreach (var specialDesc in SpecialProductDescription.Skip(SpecialCount).Take(1))
                {
                    speacialProduct.SpecialProductDescription = specialDesc;
                }
                speacialProduct.CreateDate = DateTime.Now;
                speacialProduct.UpdateDate = DateTime.Now;
                speacialProduct.Status = 1;
                SpecialCount++;
                speacialProductDescriptions.Add(speacialProduct);
            }
            Random random = new Random();
            int orderNo = random.Next(0, 10000);
            OrderDTO orderDTO = new OrderDTO()
            {
                CreateDate = DateTime.Now,
                StoreId = Convert.ToInt32(StoreId),
                OrderDate = DateTime.Now,
                OrderNo = orderNo.ToString(),
                Status = 1,
                UpdateDate = DateTime.Now,
                speacialProductDescriptions = speacialProductDescriptions,
                OrderProducts = orderProductDTOs,
                OrderType = 1,
                OrderStatuId = 1,
                OrderStatus = 2
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<OrderDTO>(orderDTO, url, Token);
                return RedirectToAction("Orders", "Order");
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
        public void UpdateProduction(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            var urls = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                result.dataList = result.dataList.Where(x => x.OrderId == id).ToList();
                foreach (var item in result.dataList)
                {
                    OrderProductDTO orderProducts = new OrderProductDTO()
                    {
                        CreateDate = item.CreateDate,
                        UpdateDate = DateTime.Now,
                        StatusId = 3,
                        Id = item.Id,
                        OrderId = item.OrderId,
                        ProductId = item.ProductId,
                        Quantitiy = item.Quantitiy,
                        RealizedProduction = item.RealizedProduction,
                        Status = 1
                    };
                    var post = ApiHandler.PostAPIWithModel<OrderProductDTO>(orderProducts, urls, Token);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public IActionResult Production(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            var urls = _configuration["UrlVariable"] + "Material/ListMaterialStock";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                ProductionModel model = new ProductionModel();
                model.orderProducts = result.dataList;
                model.orderProducts = model.orderProducts.OrderByDescending(x => x.Id).ToList();
                foreach (var item in model.orderProducts.Where(x => x.StatusId == 2))
                {
                    try
                    {
                        var rst = ApiHandler.GetAPI<DataDto<MaterialStockDTO>>(urls, Token);
                        foreach (var pm in item.Products.productMaterialDTOs)
                        {
                            foreach (var material in rst.dataList.Where(x => x.MaterialId == pm.MaterialId))
                            {
                                if (material.Quantity >= pm.Count)
                                {
                                    UpdateProduction((int)item.OrderId);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                if (filtre != null)
                {
                    model.orderProducts = model.orderProducts.Where(x => x.Products.ProductionSerialNumber != null && x.Products.ProductionSerialNumber.ToLower().Contains(filtre.ToLower())
                    || (x.Products.Name != null && x.Products.Name.ToLower().Contains(filtre.ToLower()))
                    || (x.Orders.OrderNo != null && x.Orders.OrderNo.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult GetProductProccess(int id, int opId)
        {

            var url = _configuration["UrlVariable"] + "Product/AllProductProccess";
            var languageId = 1;
            var staffUrl = _configuration["UrlVariable"] + "Staff/list/" + languageId;
            try
            {
                ViewBag.orderId = opId;
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductProcessDTO>>(url, Token);
                var StaffResult = ApiHandler.GetAPI<DataDto<StaffDTO>>(staffUrl, Token);
                ProductionModel model = new ProductionModel();
                model.productProcesses = result.dataList;
                model.staffs = StaffResult.dataList;
                model.productProcesses = model.productProcesses.Where(x => x.ProductId == id).ToList();
                return PartialView("_StaffPartial", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderDetailInfo(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            var OfferUrl = _configuration["UrlVariable"] + "Order/OfferDetail/" + id;
            var offerList = _configuration["UrlVariable"] + "Order/listoffer";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                var OfferResult = ApiHandler.GetAPI<DataDto<OfferDTO>>(OfferUrl, Token);
                var offerListResult = ApiHandler.GetAPI<DataDto<OfferDTO>>(offerList, Token);
                OfferResponseModel model = new OfferResponseModel();
                model.OrderDTO = result.data;
                model.offerDTOs = offerListResult.dataList;
                model.offer = OfferResult.data;
                return View(model); ;
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #region görüşme kayıtları listesi
        public IActionResult MeetingRecordList(int id, DateTime FirstDate, DateTime LastDate, string Filter)
        {
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO orderDTO = new OrderDTO();
                orderDTO = result.data;
                if (Filter != null || FirstDate != DateTime.MinValue || LastDate != DateTime.MinValue)
                {
                    orderDTO.MeetingRecords = orderDTO.MeetingRecords.Where(x => x.MeetingDate >= FirstDate || x.MeetingDate <= LastDate || x.MeetingNote != null && x.MeetingNote.ToLower().Contains(Filter.ToLower())
                    || (x.ReminderDate >= FirstDate || x.ReminderDate <= LastDate)
                    || (x.ReminderNote != null && x.ReminderNote.ToLower().Contains(Filter.ToLower()))
                    ).ToList();
                }
                return View(orderDTO);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region yeni görüşme kaydı ekleme post işlemi
        public JsonResult MeetingRecordAdd(MeetingRecordDTO meetingRecordDTO)
        {
            var url = _configuration["UrlVariable"] + "Order/savemeeting";
            MeetingRecordDTO meetingRecord = new MeetingRecordDTO()
            {
                CreateDate = DateTime.Now,
                MeetingDate = meetingRecordDTO.MeetingDate,
                MeetingNote = meetingRecordDTO.MeetingNote,
                OrderId = meetingRecordDTO.OrderId,
                ReminderDate = meetingRecordDTO.ReminderDate,
                ReminderNote = meetingRecordDTO.ReminderNote,
                Status = 1,
                UpdateDate = DateTime.Now
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<MeetingRecordDTO>(meetingRecord, url, Token);

                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region sipariş teklif listesi
        public IActionResult OfferList(int id)
        {
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            var offerList = _configuration["UrlVariable"] + "Order/listoffer";
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var commonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var offerListResult = ApiHandler.GetAPI<DataDto<OfferDTO>>(offerList, Token);
                var orderResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OfferResponseModel model = new OfferResponseModel();
                model.OrderDTO = orderResult.data;
                model.offerDTOs = offerListResult.dataList;
                model.commons = commonResult.dataList;
                model.productDTOs = orderResult.data.OrderProducts;
                return View(model);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region yeni teklif ekleme fonksiyonu
        public IActionResult AddOffer(OfferDTO offerDTO, string[] ProductId, string[] Quantitiy, string[] UnitOfferAmount, string[] LineOfferAmount)
        {
            TodoSend todoSend = new TodoSend(_configuration);
            var url = _configuration["UrlVariable"] + "Order/saveoffer";
            List<OfferDTO> offerDTOs = new List<OfferDTO>();
            int id = (int)offerDTO.OrderId;
            int count = 0;
            foreach (var item in ProductId)
            {
                OfferDTO offer = new OfferDTO();
                foreach (var productId in ProductId.Skip(count).Take(1))
                {
                    offer.ProductId = Convert.ToInt32(productId);
                }
                foreach (var quantity in Quantitiy.Skip(count).Take(1))
                {
                    offer.Quantitiy = Convert.ToInt32(quantity);
                }
                foreach (var unit in UnitOfferAmount.Skip(count).Take(1))
                {
                    offer.UnitOfferAmount = unit;
                }
                foreach (var line in LineOfferAmount.Skip(count).Take(1))
                {
                    offer.LineOfferAmount = line;
                }
                offer.CreateDate = DateTime.Now;
                offer.CurrencyId = offerDTO.CurrencyId;
                offer.CustomerReply = "";
                offer.FinishDate = offerDTO.FinishDate;
                offer.Kdv = offerDTO.Kdv;
                offer.OfferStatuId = 3;
                offer.OrderId = offerDTO.OrderId;
                offer.PaymentTerm = offerDTO.PaymentTerm;
                offer.Status = 1;
                offer.TotalCost = offerDTO.TotalCost;
                offer.UnitCost = offerDTO.UnitCost;
                offer.UpdateDate = DateTime.Now;
                offerDTOs.Add(offer);
                count++;
            }
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<OfferDTO>(offerDTOs, url, Token);
                int[] role = { 1, 10 };
                var results = todoSend.TodoSendList("Teklif Müşteriye İletilecek", role, (int)offerDTO.OrderId, Token);
                return RedirectToAction("OfferList", new { id = id });
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Müşteri teklif cevabı fonksiyonu
        public JsonResult CustomerReply(OfferDTO offer)
        {
            TodoSend todoSend = new TodoSend(_configuration);
            var url = _configuration["UrlVariable"] + "Order/editoffer";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<OfferDTO>(offer, url, Token);
                if (offer.OfferStatuId == 1)
                {
                    int[] role = { 4 };
                    var results = todoSend.TodoSendList("Tedarik Kontrolü Yapılacak", role, (int)offer.OrderId, Token);
                }
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
        #endregion
        #region red edilen teklif red notu
        public JsonResult RejectNote(OrderDTO orderDTO)
        {
            var url = _configuration["UrlVariable"] + "Order/rejectorder";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<OrderDTO>>(orderDTO, url, Token);
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
        #region Red edilen siparişleri listeleme sayfası
        public IActionResult RejectOrders(string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                List<OrderDTO> orders = new List<OrderDTO>();
                foreach (var item in result.dataList.Where(x => x.RejectNote != null))
                {
                    orders.Add(item);
                }
                if (filtre != null)
                {
                    orders = orders.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(orders);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        #endregion
        public IActionResult OfferRepltPopUp(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/OfferDetail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OfferDTO>>(url, Token);
                OfferDTO offerDTO = new OfferDTO();
                offerDTO = result.data;
                return PartialView("_OfferReply", offerDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult OrderConfirm(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/OrderUpdate";
            try
            {
                OrderDTO orderDTO = new OrderDTO();
                TodoSend todoSend = new TodoSend(_configuration);
                orderDTO.OrderStatuId = 1;
                orderDTO.OrderStatus = 2;
                orderDTO.OrderType = 2;
                orderDTO.Id = id;
                var Token = HttpContext.Session.GetString("token");
                var PostResult = ApiHandler.PostAPIWithModel<DataDto<OrderDTO>>(orderDTO, url, Token);
                int[] roles = { 1, 10 };
                var results = todoSend.TodoSendList("Siparişe Teklif Oluşturulacak", roles, id, Token);
                if (PostResult.statu == true)
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
        #region Üretim Personel Atama
        /// <summary>
        /// Bu fonksiyon üretim sayfasındaki üretimi başlat butonuna tıkanınca çıkan popup submit olunca çalışır
        /// personellere iş atar işi atadıktan sonra orderproduct ıd'si ile orderproduct'ı getirir ve statüsünü üretim üretim devam ediyor olarak günceller
        /// </summary>
        /// <param name="ProcessId"></param>
        /// <param name="ProductId"></param>
        /// <param name="StaffId"></param>
        /// <param name="OrderProductId"></param>
        /// <returns></returns>
        public JsonResult AddStaffProccess(string[] ProcessId, string[] ProductId, string[] StaffId, int OrderProductId)
        {
            List<StaffProcessDTO> staffProcesses = new List<StaffProcessDTO>();
            var url = _configuration["UrlVariable"] + "Staff/AddStaffProccess";
            try
            {
                var count = 0;
                foreach (var item in ProcessId)
                {
                    StaffProcessDTO staffProcessDTO = new StaffProcessDTO();
                    foreach (var product in ProductId.Skip(count).Take(1))
                    {
                        staffProcessDTO.ProductId = Convert.ToInt32(product);
                    }
                    foreach (var Staff in StaffId.Skip(count).Take(1))
                    {
                        staffProcessDTO.StaffId = Convert.ToInt32(Staff);
                    }
                    staffProcessDTO.ProcessId = Convert.ToInt32(item);
                    staffProcessDTO.CreateDate = DateTime.Now;
                    staffProcessDTO.UpdateDate = DateTime.Now;
                    staffProcessDTO.Status = 1;
                    staffProcessDTO.OrderProductId = OrderProductId;
                    staffProcesses.Add(staffProcessDTO);
                    count++;
                }
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<StaffProcessDTO>>(staffProcesses, url, Token);
                var OrderProductUrl = _configuration["UrlVariable"] + "Order/orderProduct/" + OrderProductId;
                var OPResult = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(OrderProductUrl, Token);
                if (OPResult.data == null)
                {
                    var OrderProducstUrl = _configuration["UrlVariable"] + "Order/getOrderProducts/" + OrderProductId;
                    OPResult = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(OrderProducstUrl, Token);
                }
                var Update = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
                OrderProductDTO orderProduct = new OrderProductDTO()
                {
                    CreateDate = OPResult.data.CreateDate,
                    Id = OPResult.data.Id,
                    OrderId = OPResult.data.OrderId,
                    ProductId = OPResult.data.ProductId,
                    Quantitiy = OPResult.data.Quantitiy,
                    RealizedProduction = OPResult.data.RealizedProduction,
                    Status = 1,
                    StatusId = 12,
                    UpdateDate = DateTime.Now,
                };
                var UpdateResult = ApiHandler.PostAPIWithModel<DataDto<OrderProductDTO>>(orderProduct, Update, Token);
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
        public IActionResult OrderProductionControl(DateTime FirstDate, DateTime LastDate, string Filter)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var ProductionUrl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                List<OrderDTO> newresult = new List<OrderDTO>();
                var Token = HttpContext.Session.GetString("token");
                var resultOrder = ApiHandler.GetAPI<DataDto<OrderDTO>>(ProductionUrl, Token);
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                //foreach (var item in result.dataList)
                //{
                //    if (item.OrderProducts.Count != 0)
                //    {
                //        bool a = false;
                //        foreach (var order in item.OrderProducts)
                //        {
                //            if (order.StatusId == 9) a = true;
                //        }
                //        if (a)
                //        {
                //            newresult.Add(item);
                //        }
                //    }
                //}
                //foreach (var item in resultOrder.dataList)
                //{
                //    if (item.OrderProducts.Count != 0)
                //    {
                //        bool a = false;
                //        foreach (var order in item.OrderProducts)
                //        {
                //            if (order.StatusId == 9) a = true;
                //        }
                //        if (a)
                //        {
                //            newresult.Add(item);
                //        }
                //    }
                //}

                return View(result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderControlProduct(int id, string filtre)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                result.dataList = result.dataList.Where(x => x.Id == id).ToList();
                if (filtre != null)
                {
                    result.dataList = result.dataList.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(filtre.ToLower())).ToList();
                }
                return View(result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public JsonResult StaffProccessEffort(StaffProcessDTO[] liste)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Staff/UpdateStaffProcces";
            List<StaffProcessDTO> staff = new List<StaffProcessDTO>();
            foreach (var item in liste)
            {
                item.Status = 1;
                item.UpdateDate = DateTime.Now;
                staff.Add(item);
            }
            try
            {
                var result = ApiHandler.PostAPIWithModel<DataDto<StaffProcessDTO>>(staff, url, Token);
                if (result.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {
                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult GetStaffProcces(int productId, int OrderProductId)
        {
            var url = _configuration["UrlVariable"] + "Staff/GetStaffProccess/" + productId + "/" + OrderProductId;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffProcessDTO>>(url, Token);
                return PartialView("_StaffData", result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #region Reçetesi şimdi oluşturulacak ürünler listesi
        public IActionResult RecipeNNowCreated()
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
                return PartialView("_RecipeNowCreated", responseModel);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Reçetesi şimdi oluşturulacaklar post işlemi
        [HttpPost]
        public JsonResult AddProductRecipe(ProductDTO productDTO, IFormFile technicalDocument, IFormFile technicalDrawing, string[] ProcessOrderNo, string[] ProcessDuration, string[] ProcessId, string[] Count, string[] UnitMeasureId, string[] MaterialId)
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
                var result = ApiHandler.PostAPIWithModel<DataDto<ProductDTO>>(product, url, Token);
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
        #region Reçete eklendikten sonra özel ürünlerin optionlarda listelenmesi için çağıgırılan fonksiyon
        public JsonResult ListSpecialProduct()
        {
            var ProductUrl = _configuration["UrlVariable"] + "Product/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<ProductDTO>>(ProductUrl, Token);
                result.dataList = result.dataList.Where(x => x.ProductType != 1).ToList();
                return Json(result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        public JsonResult AddRealizedProductionCount(OrderProductDTO orderProduct)
        {
            var url = _configuration["UrlVariable"] + "Order/getOrderProducts/" + orderProduct.Id;
            var Update = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                OrderProductDTO productDTO = new OrderProductDTO()
                {
                    RealizedProduction = orderProduct.RealizedProduction,
                    CreateDate = result.data.CreateDate,
                    Id = result.data.Id,
                    OrderId = result.data.OrderId,
                    ProductId = result.data.ProductId,
                    Quantitiy = result.data.Quantitiy,
                    Status = result.data.Status,
                    StatusId = result.data.StatusId,
                    UpdateDate = DateTime.Now
                };
                var results = ApiHandler.PostAPIWithModel<DataDto<OrderProductDTO>>(productDTO, Update, Token);
                if (results.statu == true)
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
        public IActionResult OrderOutput()
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var Token = HttpContext.Session.GetString("token");
            var ProductionUrl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            try
            {
                List<OrderDTO> newResult = new List<OrderDTO>();
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                var ResultOrder = ApiHandler.GetAPI<DataDto<OrderDTO>>(ProductionUrl, Token);
                foreach (var item in ResultOrder.dataList)
                {
                    if (item.OrderProducts.Count != 0)
                    {
                        bool a = true;
                        foreach (var order in item.OrderProducts)
                        {
                            if (order.StatusId != 8) a = false;
                        }
                        if (a)
                        {
                            newResult.Add(item);
                        }
                    }
                }
                foreach (var item in result.dataList)
                {
                    if (item.OrderProducts.Count != 0)
                    {
                        bool a = true;
                        foreach (var order in item.OrderProducts)
                        {
                            if (order.StatusId != 8) a = false;
                        }
                        if (a)
                        {
                            newResult.Add(item);
                        }
                    }
                }
                return View(newResult);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderOutputDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            var ProductionUrl = _configuration["UrlVariable"] + "Order/listOrderProduction";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                var ProductionResult = ApiHandler.GetAPI<DataDto<OrderDTO>>(ProductionUrl, Token);
                var data = result.dataList.Where(x => x.Id == id).FirstOrDefault();
                if (data == null)
                {
                    data = ProductionResult.dataList.Where(x => x.Id == id).FirstOrDefault();
                }
                return PartialView("_OrderOutputDetail", data);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IActionResult OrderDelivery(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                return PartialView("_orderDelivery", result.data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult CreateWayBill(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            var Waybillurl = _configuration["UrlVariable"] + "Order/WayBillUpdate";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO orderDTO = new OrderDTO()
                {
                    AddressId = result.data.AddressId,
                    CompanyId = result.data.CompanyId,
                    CreateDate = result.data.CreateDate,
                    Deadline = result.data.Deadline,
                    Id = result.data.Id,
                    OrderChannelId = result.data.OrderChannelId,
                    OrderCustomerNo = result.data.OrderCustomerNo,
                    OrderDate = result.data.OrderDate,
                    UpdateDate = DateTime.Now,
                    StoreId = result.data.StoreId,
                    OrderFrom = result.data.OrderFrom,
                    OrderNo = result.data.OrderNo,
                    OrderNote = result.data.OrderNote,
                    OrderStatuId = 6,
                    OrderType = result.data.OrderType,
                    Status = result.data.Status,
                    RejectNote = result.data.RejectNote,

                };
                var postResult = ApiHandler.PostAPIWithModel<DataDto<OrderDTO>>(orderDTO, Waybillurl, Token);
                if (postResult.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {

                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public JsonResult OrderDeliver(OrderDTO orderDTO)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + orderDTO.Id;
            var DeliverUrl = _configuration["UrlVariable"] + "Order/WayBillUpdate";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO order = new OrderDTO()
                {
                    AddressId = result.data.AddressId,
                    CompanyId = result.data.CompanyId,
                    CreateDate = result.data.CreateDate,
                    Deadline = result.data.Deadline,
                    DeliveryNote = orderDTO.DeliveryNote,
                    DellveryStaffId = HttpContext.Session.GetInt32("StaffId"),
                    Id = result.data.Id,
                    OrderChannelId = result.data.OrderChannelId,
                    OrderCustomerNo = result.data.OrderCustomerNo,
                    OrderDate = result.data.OrderDate,
                    OrderFrom = result.data.OrderFrom,
                    OrderNo = result.data.OrderNo,
                    UpdateDate = DateTime.Now,
                    OrderStatuId = 5,
                    StoreId = result.data.StoreId,
                    Status = 1,
                    RejectNote = result.data.RejectNote,
                    Receiver = orderDTO.Receiver,
                    OrderNote = result.data.OrderNote,
                    OrderType = result.data.OrderType
                };
                var PostResult = ApiHandler.PostAPIWithModel<DataDto<OrderDTO>>(order, DeliverUrl, Token);
                if (PostResult.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {
                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void OrderProductChange(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/ListOrderProduct";
            var urls = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                result.dataList = result.dataList.Where(x => x.OrderId == id).ToList();
                foreach (var item in result.dataList)
                {
                    OrderProductDTO orderProducts = new OrderProductDTO()
                    {
                        CreateDate = item.CreateDate,
                        UpdateDate = DateTime.Now,
                        StatusId = 2,
                        Id = item.Id,
                        OrderId = item.OrderId,
                        ProductId = item.ProductId,
                        Quantitiy = item.Quantitiy,
                        RealizedProduction = item.RealizedProduction,
                        Status = 1
                    };
                    var post = ApiHandler.PostAPIWithModel<OrderProductDTO>(orderProducts, urls, Token);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public void MaterialStockControl(int OrderId)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + OrderId;
            var MaterilStockUrl = _configuration["UrlVariable"] + "Material/ListMaterialStock";

            var SaveUrl = _configuration["UrlVariable"] + "Order/SaveNeeds";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);

                var MaterialStok = ApiHandler.GetAPI<DataDto<MaterialStockDTO>>(MaterilStockUrl, Token);
                //List<OrderNeedsDto> needsDtos = new List<OrderNeedsDto>();
                int stock = 0;//get;
                List<NeedsDto> list = new List<NeedsDto>();
                //List<NeedsDto> need = new List<NeedsDto>();



                foreach (var item in result.data.OrderProducts)
                {
                    foreach (var pm in item.Products.productMaterialDTOs)
                    {
                        var value = item.Quantitiy * pm.Count;
                        var e = MaterialStok.dataList.Where(x => x.StoreId == result.data.StoreId && x.MaterialId == pm.MaterialId).First();
                        if (e != null)
                        {
                            list.Add(new NeedsDto()
                            {
                                MaterialId = (int)pm.MaterialId,
                                Quantity = MaterialStok.dataList.
                                    Where(x => x.StoreId == result.data.StoreId && x.MaterialId == pm.MaterialId).
                                    GroupBy(x => x.MaterialId & x.StoreId).
                                    Select(m =>
                                    new
                                        {
                                            quantity = m.Sum(v => v.Quantity)
                                        }
                                    ).
                                    First().
                                    quantity,
                                StoreId = (int)result.data.StoreId
                            });
                        }
                    }
                }



                //List<NeedsDto> needs = list.GroupBy(x => x.MaterialId).Select(cl => new NeedsDto
                //{
                //    Quantity = cl.Sum(x => x.Quantity),
                //    MaterialId = cl.FirstOrDefault().MaterialId
                //}).ToList();
                //List<OrderNeedsDto> needs = new List<OrderNeedsDto>();
                int count = 0;
                foreach (var item in result.data.OrderProducts)
                {
                    foreach (var pm in item.Products.productMaterialDTOs)
                    {
                        foreach (var sm in MaterialStok.dataList.Where(x => x.MaterialId == pm.MaterialId && result.data.StoreId == x.StoreId))
                        {
                            if (list.Where(x => x.MaterialId == sm.MaterialId).FirstOrDefault().Quantity >= (int)pm.Count * (int)item.Quantitiy)
                            {
                                if (count>0)
                                {
                                    OrderNeedsDto orderNeeds = new OrderNeedsDto()
                                    {
                                        CreateDate = DateTime.Now,
                                        MaterialId = sm.MaterialId,
                                        OrderId = item.OrderId,
                                        OrderNo = result.data.OrderNo,
                                        ProductId = item.ProductId,
                                        Recruitment = 2,//2 ürün için yeterli materyal var 
                                        Quantity = (int)pm.Count * (int)item.Quantitiy,
                                        ShortBy = 0,
                                        UpdateDate = DateTime.Now,
                                        Status = 1
                                    };
                                    var rslt = ApiHandler.PostAPIWithModel<OrderNeedsDto>(orderNeeds, SaveUrl, Token);
                                    list.Where(x => x.MaterialId == sm.MaterialId).FirstOrDefault().Quantity -= (int)pm.Count * (int)item.Quantitiy;
                                    count++;
                                }
                            }
                            else
                            {
                                OrderNeedsDto orderNeeds = new OrderNeedsDto()
                                {
                                    CreateDate = DateTime.Now,
                                    MaterialId = sm.MaterialId,
                                    OrderId = item.OrderId,
                                    OrderNo = result.data.OrderNo,
                                    ProductId = item.ProductId,
                                    UpdateDate = DateTime.Now,
                                    Recruitment = 1,
                                    Quantity = 0,
                                    ShortBy = ((int)pm.Count * (int)item.Quantitiy) - (list.Where(x => x.MaterialId == sm.MaterialId).FirstOrDefault().Quantity),
                                    Status = 1
                                };
                                var rslt = ApiHandler.PostAPIWithModel<OrderNeedsDto>(orderNeeds, SaveUrl, Token);
                                count++;
                            }

                        }
                    }

                }

            }
            catch(Exception ex)
            {
                var x = ex.ToString();
            }
        }
        public JsonResult CreateOrderProduction(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            var DeliverUrl = _configuration["UrlVariable"] + "Order/WayBillUpdate";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO order = new OrderDTO()
                {
                    AddressId = result.data.AddressId,
                    CompanyId = result.data.CompanyId,
                    CreateDate = result.data.CreateDate,
                    Deadline = result.data.Deadline,
                    DeliveryNote = result.data.DeliveryNote,
                    DellveryStaffId = result.data.DellveryStaffId,
                    Id = result.data.Id,
                    OrderChannelId = result.data.OrderChannelId,
                    OrderCustomerNo = result.data.OrderCustomerNo,
                    OrderDate = result.data.OrderDate,
                    OrderFrom = result.data.OrderFrom,
                    OrderNo = result.data.OrderNo,
                    OrderNote = result.data.OrderNote,
                    OrderStatuId = 2,
                    UpdateDate = DateTime.Now,
                    StoreId = result.data.StoreId,
                    Status = 1,
                    RejectNote = result.data.RejectNote,
                    Receiver = result.data.Receiver,
                    OrderType = result.data.OrderType,
                };
                OrderProductChange(id);
                MaterialStockControl(result.data.Id);
                var postedResult = ApiHandler.PostAPIWithModel<DataDto<OrderDTO>>(order, DeliverUrl, Token);
                if (postedResult.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {
                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        public JsonResult UpdateOrderProduction(int id, int statuıd)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Order/getOrderProducts/" + id;
            var Update = _configuration["UrlVariable"] + "Order/OrderProductionUpdate";
            try
            {
                var result = ApiHandler.GetAPI<DataDto<OrderProductDTO>>(url, Token);
                OrderProductDTO orderProduct = new OrderProductDTO()
                {
                    CreateDate = result.data.CreateDate,
                    Id = result.data.Id,
                    OrderId = result.data.OrderId,
                    ProductId = result.data.ProductId,
                    Quantitiy = result.data.Quantitiy,
                    RealizedProduction = result.data.RealizedProduction,
                    Status = 1,
                    StatusId = statuıd,
                    UpdateDate = DateTime.Now,
                };
                var postResult = ApiHandler.PostAPIWithModel<DataDto<OrderProductDTO>>(orderProduct, Update, Token);
                if (postResult.statu == true)
                {
                    return Json(HttpStatusCode.OK);
                }
                else
                {
                    return Json(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}