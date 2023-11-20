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
    public class ProductController : Controller
    {
        IProductService _productService;
        ProductDTOValidator _productDtoValidator;
        IStaffProcessService _staffProcessService;
        StaffProccessDTOValidator _staffProccessValidator;
        ISpecialProductDescriptionService _specialProductDescriptionService;
        IProductStockService _productStockService;
        public ProductController(IProductService productService, IStaffProcessService staffProcessService, ISpecialProductDescriptionService specialProductDescriptionService, IProductStockService productStockService)
        {
            _productService = productService;
            _productDtoValidator = new ProductDTOValidator();
            _staffProcessService = staffProcessService;
            _staffProccessValidator = new StaffProccessDTOValidator();
            _specialProductDescriptionService = specialProductDescriptionService;
            _productStockService = productStockService;
        }


        [HttpPost("save")]
        public JsonResult SaveProductPrescription(ProductDTO productDTO)
        {
            FluentValidation.Results.ValidationResult validationResult = _productDtoValidator.Validate(productDTO);
            if (!validationResult.IsValid)
            {
                string message = "";
                foreach (var item in validationResult.Errors)
                {
                    message = message + " " + item.ErrorMessage;
                }
                return Json(new ResultDTO<ProductDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _productService.Add(productDTO);
            var model = new ResultDTO<ProductDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("saveproductionassignee")]
        public JsonResult SaveProductPrescription(List<StaffProcessDTO> staffProcesses)
        {
            foreach (var item in staffProcesses)
            {
                FluentValidation.Results.ValidationResult validationResult = _staffProccessValidator.Validate(item);
                if (!validationResult.IsValid)
                {
                    string message = "";
                    foreach (var item2 in validationResult.Errors)
                    {
                        message = message + " " + item2.ErrorMessage;
                    }
                    return Json(new ResultDTO<StaffProcessDTO>()
                    {
                        Statu = false,
                        Message = message
                    });
                }
            }
            _staffProcessService.AddStaffProccess(staffProcesses);
            var model = new ResultDTO<StaffProcessDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("UpdateSpecialProduct")]
        public JsonResult UpdateSpecialProduct(SpeacialProductDescriptionDTO speacialProduct)
        {
            _specialProductDescriptionService.Update(speacialProduct);
            var model = new ResultDTO<SpeacialProductDescriptionDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult List()
        {
            var result = _productService.GetAll(1);
            var model = new ResultDTO<ProductDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("ListCategory/{id}")]
        public  IActionResult ListCategoryIdProducts(int id)
        {
            var result =  _productService.GetByCategoryIdProducts(id);
            var model = new ResultDTO<ProductDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Ok(model);
        }
        [HttpGet("ListSpecialProduct")]
        public JsonResult GetSpecialProductList()
        {
            var result = _specialProductDescriptionService.GetAll(1);
            var model = new ResultDTO<SpeacialProductDescriptionDTO>()
            {
                Statu = true,
                DataList = result,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("GetBySpecialId/{id}")]
        public JsonResult GetByIdSpecialProduct(int id)
        {
            var result = _specialProductDescriptionService.GetById(id, 1);
            var model = new ResultDTO<SpeacialProductDescriptionDTO>()
            {
                Statu = true,
                Data = result,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("get/{id}")]
        public JsonResult productDetail(int id)
        {
            var result = _productService.GetById(id, 1);
            var model = new ResultDTO<ProductDTO>()
            {
                Statu = true,
                Data = result,
                Message = "Success"
            };
            return Json(model);

        }
        [HttpPost("update")]
        public JsonResult UpdateProduct(ProductDTO productDTO)
        {
            var result = _productService.Update(productDTO);
            var model = new ResultDTO<ProductDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("UpdateProductStock")]
        public JsonResult UpdateProductStock(ProductStockDTO productStockDTO)
        {
            var result = _productStockService.ProductStockUpdate(productStockDTO);
            var model = new ResultDTO<ProductStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("AddProductStock")]
        public JsonResult AddProductStockEntry(ProductStockDTO productStock)
        {
            _productStockService.Add(productStock);
            var model = new ResultDTO<ProductStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("ProductStockList/{id}")]
        public JsonResult ProductStockList(int id)
        {
            var result = _productStockService.GetByIdProductStock(id);
            var model = new ResultDTO<ProductDTO>()
            {
                DataList = result,
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("AllProductProccess")]
        public JsonResult ProductProccesList()
        {
            var result = _productService.productProcesses();
            var model = new ResultDTO<ProductProcessDTO>()
            {
                DataList = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
    }
}
