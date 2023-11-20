using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : Controller
    {
        IMaterialSuppliersService _materialSuppliersService;
        MaterialSupplierDTOValidators _materialSupperlier;
        ISawdustStockService _sawdustStockService;
        SawdustStockDTOValidator _sawstockDtoValidator;
        IProductStockService _productStockService;
        ProductStockDTOValidator _productStockDtoValidator;
        IMaterialStockService _materialStockService;
        MaterialStockDTOValidator _materialStockDtoValidator;
        public StockController(IMaterialSuppliersService materialService, ISawdustStockService sawdustStockService, IProductStockService productStockService, IMaterialStockService materialStockService)
        {
            _materialSuppliersService = materialService;
            _materialSupperlier = new MaterialSupplierDTOValidators();
            _sawdustStockService = sawdustStockService;
            _sawstockDtoValidator = new SawdustStockDTOValidator();
            _productStockService = productStockService;
            _productStockDtoValidator = new ProductStockDTOValidator();
            _materialStockService = materialStockService;
            _materialStockDtoValidator = new MaterialStockDTOValidator();
        }
        [HttpGet("listSupply")]
        public JsonResult ListMaterialSupply()
        {
            var result = _materialSuppliersService.GetAll(1);
            var model = new ResultDTO<MaterialSupplierDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpPost("saveSupply")]
        public JsonResult SaveMaterialSupply(MaterialSupplierDTO material)
        {
            _materialSuppliersService.Add(material);
            var model = new ResultDTO<MaterialSupplierDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        //Talaş

        [HttpGet("listSawdustStockInput")]
        public JsonResult ListSawdustInput()
        {
            var result = _sawdustStockService.GetAll(1);
            var model = new ResultDTO<SawdustStockDTO>()
            {
                DataList = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpPost("saveInputSawdust")]
        public JsonResult saveInputSawdust(SawdustStockDTO entity)
        {
            _sawdustStockService.Add(entity);
            var model = new ResultDTO<SawdustStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("listProductStockInput")]
        public JsonResult ListProductInput()
        {
          var result=  _productStockService.GetAll(1);
            var model = new ResultDTO<ProductStockDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList=result
            };
            return Json(model);
        }
        [HttpPost("saveInputProduct")]
        public JsonResult SaveInputProduct(ProductStockDTO entity)
        {
            _productStockService.Add(entity);
            var model = new ResultDTO<ProductStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("listStockMaterial")]
        public JsonResult ListStockMaterial()
        {
          var result=  _materialStockService.GetAll(1);
            var model = new ResultDTO<MaterialStockDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList=result
               
            };
            return Json(model);
        }
        [HttpPost("saveInputMaterial")]
        public JsonResult SaveInputMaterial(MaterialStockDTO material)
        {
            _materialStockService.Add(material);
            var model = new ResultDTO<MaterialStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
    }
}
