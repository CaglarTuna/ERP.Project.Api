using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ConsumptionMaterialController : Controller
    {
        IConsumptionMaterialService _consumptionMaterialService;
        IConsumptionMaterialStockService _consumptionMaterialStockService;

        ConsumptionMaterialDTOValidator _consumptionMaterialValidator;

        public ConsumptionMaterialController(IConsumptionMaterialService consumptionMaterialService, IConsumptionMaterialStockService consumptionMaterialStockService)
        {
            _consumptionMaterialService = consumptionMaterialService;
            _consumptionMaterialValidator = new ConsumptionMaterialDTOValidator();
            _consumptionMaterialStockService = consumptionMaterialStockService;
        }
        [HttpPost("save")]
        public JsonResult Index(ConsumptionMaterialDTO consumptionMaterialDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _consumptionMaterialValidator.Validate(consumptionMaterialDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<ConsumptionMaterialDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _consumptionMaterialService.Add(consumptionMaterialDTO);
            var model = new ResultDTO<ConsumptionMaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult List()
        {
            var result = _consumptionMaterialService.GetAll(1);
            var model = new ResultDTO<ConsumptionMaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("detail/{id}")]
        public JsonResult Detail(int id)
        {
            var result = _consumptionMaterialService.getConsumptionMaterialDetail(id);
            var model = new ResultDTO<ConsumptionMaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("ListStock")]
        public JsonResult ConsuptionStock()
        {
            var result = _consumptionMaterialStockService.GetAll(1);
            var model = new ResultDTO<ConsumptionMaterialStockDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpPost("saveStock")]
        public JsonResult AddConsuptionStock(ConsumptionMaterialStockDTO consumptionMaterialStock)
        {
            _consumptionMaterialStockService.Add(consumptionMaterialStock);
            var model = new ResultDTO<ConsumptionMaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);

        }
        [HttpGet("StockDetail")]
        public JsonResult ConsuptionStockDetail(int id)
        {
            var result = _consumptionMaterialStockService.GetById(id, 1);
            var model = new ResultDTO<ConsumptionMaterialStockDTO>()
            {
                Data = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpPost("update")]
        public JsonResult Update(ConsumptionMaterialDTO consumptionMaterialDTO)
        {
            var updatedvalue = _consumptionMaterialService.Update(consumptionMaterialDTO);
            if (updatedvalue)
            {
                var model = new ResultDTO<ConsumptionMaterialDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<ConsumptionMaterialDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("UpdateStock")]
        public JsonResult UpdateStock(ConsumptionMaterialStockDTO consumptionMaterialStock)
        {

            var update = _consumptionMaterialStockService.Update(consumptionMaterialStock);
            if (update)
            {
                var model = new ResultDTO<ConsumptionMaterialStockDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<ConsumptionMaterialStockDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}
