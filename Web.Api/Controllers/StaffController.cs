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
    public class StaffController : Controller
    {
        IStaffService _staffService;
        StaffDTOValidator _staffDTOValidator;
        IStaffProcessService _staffProccess;
        public StaffController(IStaffService staffService, IStaffProcessService staffProccess)
        {
            _staffService = staffService;
            _staffDTOValidator = new StaffDTOValidator();
            _staffProccess = staffProccess;
        }

        [HttpPost("save")]
        public JsonResult Save([FromBody] StaffDTO staffDTO)
        {
            FluentValidation.Results.ValidationResult validate = _staffDTOValidator.Validate(staffDTO);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<StaffDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _staffService.Add(staffDTO);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }

        [HttpPost("update")]
        public JsonResult Update([FromBody] StaffDTO staffDTO)
        {
            FluentValidation.Results.ValidationResult validate = _staffDTOValidator.Validate(staffDTO);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<StaffDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _staffService.Update(staffDTO);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("Confirm")]
        public JsonResult Confirm(StaffDTO staffDTO)
        {
            _staffService.StaffConfirm(staffDTO);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list/{languageId}")]
        public JsonResult List(int languageId)
        {
            var result = _staffService.GetAll(languageId);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("get/{staffId}/{languageId}")]
        public JsonResult GetById(int staffId, int languageId)
        {
            var result = _staffService.GetById(staffId, languageId);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("delete/{staffId}")]
        public JsonResult Delete(int staffId)
        {
            bool deletedvalue = _staffService.Delete(staffId);
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

        [HttpGet("detail/{staffId}")]
        public JsonResult Detail(int staffId)
        {
            var result = _staffService.GetById(staffId, 1);
            var model = new ResultDTO<StaffDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }

        [HttpGet("effort/{staffId}")]
        public JsonResult Effort(int staffId)
        {
            var result = _staffProccess.GetByStaffId(staffId);
            var model = new ResultDTO<StaffProcessDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpPost("AddStaffProccess")]
        public JsonResult SaveStaffProccess(List<StaffProcessDTO> staffProcesses)
        {
            _staffProccess.AddStaffProccess(staffProcesses);
            var model = new ResultDTO<StaffProcessDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("GetStaffProccess/{ProductId}/{OrderProductId}")]
        public JsonResult StaffProccessControl(int ProductId, int OrderProductId)
        {
            var result = _staffProccess.GetBy(ProductId, OrderProductId);
            var model = new ResultDTO<StaffProcessDTO>()
            {
                DataList = result,
                Message = "Success",
                Statu = true
            };
            return Json(model);
        }
        [HttpPost("UpdateStaffProcces")]
        public JsonResult StaffProccessUpdate(List<StaffProcessDTO> staffProcesses)
        {
            var result = _staffProccess.UpdateStaffProccess(staffProcesses);
            var model = new ResultDTO<StaffProcessDTO>()
            {
                Statu = result,
                Message = "Success"
            };
            return Json(model);
        }
    }
}