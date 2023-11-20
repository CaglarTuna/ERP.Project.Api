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
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessController : Controller
    {
        IProcessService _processService;
        ProcessDTOValidator _processValidator;
        public ProcessController(IProcessService categoryService)
        {
            _processService = categoryService;
            _processValidator = new ProcessDTOValidator();
        }

        [HttpPost("save")]
        public JsonResult Save(ProcessDTO processDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _processValidator.Validate(processDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<ProcessDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _processService.Add(processDTO);
            var model = new ResultDTO<ProcessDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list/{languageId}")]
        public JsonResult List(int languageId)
        {
            var result = _processService.GetAll(languageId);
            var model = new ResultDTO<ProcessDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpPost("update")]
        public JsonResult update(ProcessDTO processDTO)
        {
            _processService.Update(processDTO);
            var model = new ResultDTO<ProcessDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
    }
}
