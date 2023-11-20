using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System.Collections.Generic;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        IOrderService _orderService;
        OrderDTOValidator _orderValidator;
        IOfferService _offerService;
        OfferDTOValidator _offerValidator;
        IMeetingRecordService _meetingRecordService;
        MeetingRecordDTOValidator _meetingRecordValidator;
        IOrderTypeService _orderTypeService;
        OrderTypeDTOValidator _orderTypeValidator;
        IOrderProductService _orderProductService;
        OrderProductDTOValidator _orderProductValidator;
        IOrderChannelService _orderChannelService;
        IOrderNeesService _orderNeesService;

        public OrderController(IOrderService orderService, IOfferService offerService
            , IMeetingRecordService meetingRecordService
              , IOrderTypeService orderTypeService,
            IOrderProductService orderProductService, IOrderChannelService orderChannelService, IOrderNeesService orderNeesService)
        {
            _orderService = orderService;
            _orderValidator = new OrderDTOValidator();
            _offerService = offerService;
            _offerValidator = new OfferDTOValidator();
            _meetingRecordService = meetingRecordService;
            _meetingRecordValidator = new MeetingRecordDTOValidator();
            _orderTypeService = orderTypeService;
            _orderTypeValidator = new OrderTypeDTOValidator();
            _orderProductService = orderProductService;
            _orderProductValidator = new OrderProductDTOValidator();
            _orderChannelService = orderChannelService;
            _orderNeesService = orderNeesService;
        }

        [HttpPost("saveproduction")]
        public JsonResult SaveProduction(OrderDTO orderDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _orderValidator.Validate(orderDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<OrderDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _orderService.AddProduction(orderDTO);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("savesale")]
        public JsonResult SaveSale(OrderDTO orderDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _orderValidator.Validate(orderDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<OrderDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _orderService.Add(orderDTO);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("SaveNeeds")]
        public JsonResult SaveNeeds(OrderNeedsDto orderNeedsDto)
        {
            _orderNeesService.Add(orderNeedsDto);
            var model = new ResultDTO<OrderNeedsDto>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("savemeeting")]
        public JsonResult SaveMeeting(MeetingRecordDTO meetingRecordDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _meetingRecordValidator.Validate(meetingRecordDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<MeetingRecordDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _meetingRecordService.Add(meetingRecordDTO);
            var model = new ResultDTO<MeetingRecordDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("saveoffer")]
        public JsonResult SaveOffer(List<OfferDTO> offerDTO)
        {
            _offerService.listOfferAdd(offerDTO);
            var model = new ResultDTO<OfferDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("rejectorder")]
        public JsonResult RejectOrder(OrderDTO orderDTO)
        {

            _orderService.OrderRejectNote(orderDTO);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("ListOrderProduct")]
        public JsonResult OrderProduuctList()
        {
            var result = _orderProductService.GetAll(1);
            var model = new ResultDTO<OrderProductDTO>()
            {
                DataList = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpGet("listproduction")]
        public JsonResult List()
        {
            var result = _orderService.GetAll(1);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("listOrderProduction")]
        public JsonResult ListOrderProduction()
        {
            var result = _orderService.GetOrderProductionList();
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("listoffer")]
        public JsonResult ListOffer()
        {
            var resutl = _offerService.GetAll(1);
            var model = new ResultDTO<OfferDTO>()
            {
                Statu = true,
                DataList = resutl,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("listrejectedsale")]
        public JsonResult ListRejectedSale()
        {
            var resutl = _orderService.GetAll(1);
            return Json(resutl);
        }
        [HttpGet("listsale")]
        public JsonResult ListSale()
        {
            var resutl = _orderService.GetAll(1);
            return Json(resutl);
        }
        [HttpGet("listmeeting")]
        public JsonResult ListMeeting()
        {
            var resutl = _meetingRecordService.GetAll(1);
            return Json(resutl);
        }
        [HttpGet("listOrderChannel")]
        public JsonResult ListOrderChannel()
        {
            var result = _orderChannelService.GetAll(1);
            var model = new ResultDTO<OrderChannelDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("detail/{orderId}")]
        public JsonResult Detail(int orderId)
        {
            var result = _orderService.GetById(orderId, 1);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("OfferDetail/{id}")]
        public JsonResult OfferDetail(int id)
        {
            var result = _offerService.getLastOffer(id);
            var model = new ResultDTO<OfferDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("orderProduct/{id}")]
        public JsonResult OrderProductStock(int id)
        {
            var result = _orderService.getOrder(id);
            var model = new ResultDTO<OrderDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }

        [HttpGet("getOrderProducts/{id}")]
        public JsonResult GetOrderProducts(int id)
        {
            var result = _orderProductService.GetById(id, 1);
            var model = new ResultDTO<OrderProductDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpPost("editoffer")]
        public JsonResult Edit(OfferDTO offer)
        {
            bool updateValue = _offerService.Update(offer);
            if (updateValue)
            {
                var model = new ResultDTO<OfferDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<OfferDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("OrderUpdate")]
        public JsonResult OrderUpdate(OrderDTO orderDTO)
        {
            bool updateValue = _orderService.OrderConfirmUpdate(orderDTO); ;
            if (updateValue)
            {
                var model = new ResultDTO<OrderDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<OrderDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("OrderProductUpdate")]
        public JsonResult OrderProductUpdate(OrderProductDTO orderProduct)
        {
            var updateProduct = _orderProductService.GetById(orderProduct.Id, 1);
            updateProduct.RealizedProduction = orderProduct.RealizedProduction;
            bool updateValue = _orderProductService.Update(updateProduct);
            if (updateValue)
            {
                var model = new ResultDTO<OrderProductDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<OrderProductDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("OrderProductionUpdate")]
        public JsonResult OrderProducProductionUpdate(OrderProductDTO productDTO)
        {
            var updateProduct = _orderProductService.Update(productDTO);
            if (updateProduct)
            {
                var model = new ResultDTO<OrderProductDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<OrderProductDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("WayBillUpdate")]
        public JsonResult OrderWaybillUpdate(OrderDTO orderDTO)
        {
            var updateOrder = _orderService.OrderWaybillUpdate(orderDTO);
            if (updateOrder)
            {
                var model = new ResultDTO<OrderDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<OrderDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
            
        }
        [HttpGet("OrderWithProduct/{id}/{OrderId}")]
        public JsonResult OrderWithProductId(int id, int OrderId)
        {
            var result = _orderProductService.getProductWithOrderId(id, OrderId);
            var model = new ResultDTO<OrderProductDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);

        }
    }
}