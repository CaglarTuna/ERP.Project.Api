using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
    [ApiController]
    [Route("api/[controller]")]
    public class RawMaterialController : Controller
    {
        IRawMaterialService _rawMaterialService;
        RawMaterialDTOValidator _rawMaterialValidator; //Validasyon yanlızca save ve update lerde olacak.

        public RawMaterialController(IRawMaterialService rawMaterialService)
        {
            _rawMaterialService = rawMaterialService;
            _rawMaterialValidator = new RawMaterialDTOValidator();
        }

        [HttpPost("save")]
        public JsonResult Save(RawMaterialDTO rawMaterialDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _rawMaterialValidator.Validate(rawMaterialDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<RawMaterialDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }

            _rawMaterialService.Add(rawMaterialDTO);
            var model = new ResultDTO<RawMaterialDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult List()
        {
            var result = _rawMaterialService.GetAll(1);
            var model = new ResultDTO<RawMaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }

        //ön yüzde kullanıcıya açık değil
        [HttpGet("get/{id}")]
        public JsonResult List(int id)
        {
            var result = _rawMaterialService.GetById(id, 1);
            var model = new ResultDTO<RawMaterialDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }

        //ön yüzde kullanıcıya açık değil
        [HttpPost("update")]
        public JsonResult Update(RawMaterialDTO rawMaterial)
        {
            var updatedvalue=_rawMaterialService.Update(rawMaterial);
            if (updatedvalue)
            {
                var model = new ResultDTO<RawMaterialDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<RawMaterialDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}
