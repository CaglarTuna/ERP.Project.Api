using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
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
    public class StandController : Controller
    {
        IStandService _standService;
        StandDTOValidator _standValidator;
        public StandController(IStandService standService)
        {
            _standService = standService;
            _standValidator = new StandDTOValidator();
        }
        [HttpPost("save")]
        public JsonResult save(StandDTO standDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _standValidator.Validate(standDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + " " + item.ErrorMessage;
                }
                return Json(new ResultDTO<StandDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _standService.Add(standDTO);
            var model = new ResultDTO<StandDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list/{languageId}")]
        public JsonResult List(int languageId)
        {
            var result = _standService.GetAll(1);
            var model = new ResultDTO<StandDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("get/{id}")]
        public JsonResult List(int id, int languageId)
        {
            var result = _standService.GetById(id, 1);
            var model = new ResultDTO<StandDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("delete/{id}")]
        public JsonResult Delete(int id)
        {
            bool deletedvalue = _standService.Delete(id);
            if (deletedvalue)
            {
                var model = new ResultDTO<StaffDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<StaffDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }

        [HttpPost("update")]
        public JsonResult Update(StandDTO stand)
        {
            var updatedvalue=_standService.Update(stand);
            if (updatedvalue)
            {
                var model = new ResultDTO<StandDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<StandDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}
