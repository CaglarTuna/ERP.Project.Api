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
    public class StoreController : Controller
    {
        IStoreService _storeService;
        StoreDTOValidator _storeValidator; //Validasyon yanlızca save ve update lerde olacak.

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
            _storeValidator = new StoreDTOValidator();
        }

        [HttpPost("save")]
        public JsonResult Save(StoreDTO storeDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _storeValidator.Validate(storeDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<StoreDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }

            _storeService.Add(storeDTO);
            var model = new ResultDTO<StoreDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult List()
        {
            var result = _storeService.GetAll(1);
            var model = new ResultDTO<StoreDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("get/{id}")]
        public JsonResult List(int id)
        {
            var result = _storeService.GetById(id, 1);
            var model = new ResultDTO<StoreDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result

            };
            return Json(model);
        }

        //ön yüzde kullanıcıya açık değil
        [HttpPost("update")]
        public JsonResult Update(StoreDTO store)
        {
            var updatedvalue=_storeService.Update(store);
            if (updatedvalue)
            {
                var model = new ResultDTO<StoreDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<StoreDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }   
        }
    }
}
