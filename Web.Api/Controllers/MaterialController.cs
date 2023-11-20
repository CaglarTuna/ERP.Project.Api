using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System.Collections.Generic;
using Web.Api.Filters;

namespace Web.Api.Controllers
{   //[EnableCors]
    [ExceptionFilter("")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MaterialController : Controller
    {
        IMaterialService _materialService;
        MaterialDTOValidator _materialDtoValidator;
        IMaterialStockService _materialStockService;
        IMaterialExpertDeliverys _materialExpertDeliverys;
        IMaterialSupplyRequestsService _materialSupplyRequestsService;
        public MaterialController(IMaterialService materialService, IMaterialStockService materialStockService, IMaterialExpertDeliverys materialExpertDeliverys, IMaterialSupplyRequestsService materialSupplyRequestsService)
        {
            _materialService = materialService;
            _materialDtoValidator = new MaterialDTOValidator();
            _materialStockService = materialStockService;
            _materialExpertDeliverys = materialExpertDeliverys;
            _materialSupplyRequestsService = materialSupplyRequestsService;
        }
        [HttpPost("save")]
        public JsonResult SaveMaterial([FromBody] MaterialDTO material)
        {
            FluentValidation.Results.ValidationResult validate = _materialDtoValidator.Validate(material);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + " " + item.ErrorMessage;
                }
                return Json(new ResultDTO<MaterialDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _materialService.Add(material);
            var model = new ResultDTO<MaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("Update")]
        public JsonResult UpdateMaterial(MaterialDTO material)
        {
            FluentValidation.Results.ValidationResult validate = _materialDtoValidator.Validate(material);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + " " + item.ErrorMessage;
                }
                return Json(new ResultDTO<MaterialDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _materialService.Update(material);
            var model = new ResultDTO<MaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("AddMaterialExpertDelivery")]
        public JsonResult AddMaterialExpertDeliverys(MaterialExpertDeliverysDTO materialExpertDeliverys)
        {
            _materialExpertDeliverys.Add(materialExpertDeliverys);
            var model = new ResultDTO<MaterialExpertDeliverysDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("AddMaterialSupplys")]
        public JsonResult AddMaterialSupplyRequest(List<MaterialSupplyRequestsDTO> list)
        {
            _materialSupplyRequestsService.materialSuppliesListAdd(list);
            var model = new ResultDTO<MaterialSupplyRequestsDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("MaterialSupplyRepl")]
        public JsonResult MaterialSupplyRequestReply(List<MaterialSupplyRequestsDTO> materials)
        {
            _materialSupplyRequestsService.materialSupplyRequestReply(materials);
            var model = new ResultDTO<MaterialSupplyRequestsDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("MaterialSupplyRequestList")]
        public JsonResult MaterialSuppleyList()
        {
            var result = _materialSupplyRequestsService.GetAll(1);
            var model = new ResultDTO<MaterialSupplyRequestsDTO>()
            {
                Statu = true,
                DataList = result,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult ListMaterial()
        {
            var result = _materialService.GetAll(1);
            var model = new ResultDTO<MaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("listExpert")]
        public JsonResult ListExpertDelivery()
        {
            var result = _materialService.GetExpertDelivery();
            var model = new ResultDTO<MaterialExpertDeliverysDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("detail/{id}")]
        public JsonResult ListMaterialDetail(int id)
        {
            var result = _materialService.GetById(id, 1);
            var model = new ResultDTO<MaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }

        [HttpPost("certificateMissingMaterial/save")]
        public JsonResult SaveCertificateMissingMaterial(MaterialCertificatesDTO material)
        {
            _materialService.SaveCertificate(material);
            var model = new ResultDTO<MaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("SaveMaterialStock")]
        public JsonResult SaveMaterialStock(MaterialStockDTO materialStockDTO)
        {
            _materialStockService.Add(materialStockDTO);
            var model = new ResultDTO<MaterialStockDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("ListMaterialStock")]
        public JsonResult ListMaterialStock()
        {
            var result = _materialStockService.GetAll(1);
            var model = new ResultDTO<MaterialStockDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("certificateMissingMaterial/list/{id}")]
        public JsonResult ListCertificateMissingMaterial(int id)
        {
            var result = _materialService.getMaterialCertificate(id);
            var model = new ResultDTO<MaterialCertificatesDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpPost("certificateMissingMaterial/delete")]
        public JsonResult deleteMaterialCertificate(MaterialCertificatesDTO materialCertificates)
        {
            bool deleteValue = _materialService.deleteCertificate(materialCertificates.Id);
            if (deleteValue)
            {
                var model = new ResultDTO<MaterialCertificatesDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {

                var model = new ResultDTO<MaterialCertificatesDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}
