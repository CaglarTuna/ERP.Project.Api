using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        CategoryDTOValidator _categoryValidator;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _categoryValidator = new CategoryDTOValidator();
        }

        [HttpPost("save")]
        public JsonResult Save(CategoryDTO categoryDTO)
        {
            FluentValidation.Results.ValidationResult resultValidator = _categoryValidator.Validate(categoryDTO);
            if (!resultValidator.IsValid)
            {
                string message = "";
                foreach (var item in resultValidator.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<CategoryDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _categoryService.Add(categoryDTO);
            var model = new ResultDTO<CategoryDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
       
        [HttpGet("list/{languageId}")]
        public JsonResult List(int languageId)
        {
            var result = _categoryService.GetAll(languageId);
            var model = new ResultDTO<CategoryDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("get/{id}/{languageId}")]
        public JsonResult List(int id, int languageId)
        {
            var result = _categoryService.GetById(id, languageId);
            var model = new ResultDTO<CategoryDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpPost("delete/{id}")]
        public JsonResult Delete(int id)
        {
            bool deletedvalue = _categoryService.Delete(id);
            if (deletedvalue)
            {
                var model = new ResultDTO<CategoryDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<CategoryDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }

        [HttpPost("update")]
        public JsonResult Update(CategoryDTO category)
        {
            bool updatedvalue = _categoryService.Update(category);
            if (updatedvalue)
            {
                var model = new ResultDTO<CategoryDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<CategoryDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}