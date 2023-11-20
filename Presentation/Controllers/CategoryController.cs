using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Common;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();

        public CategoryController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult ProductCategory(string filtre)
        {
           
            var url = _configuration["UrlVariable"] + "Category/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CategoryDTO>>(url, Token);
                CategoryDTO cate = new CategoryDTO();
                List<CategoryDTO> categories = new List<CategoryDTO>();
                categories = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    categories = categories.Where(x => x.CategoryLanguageDTOs.Any(y => y.Name != null && y.Name.ToLower().Contains(filtre.ToLower()))).ToList();
                }
                return View(categories);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        public IActionResult editProductCategory(int id)
        {
            var url = _configuration["UrlVariable"] + "Category/get/" + id + "/" + 1;
            var listCategoryUrl = _configuration["UrlVariable"] + "Category/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CategoryDTO>>(url, Token);
                var listCategory = ApiHandler.GetAPI<DataDto<CategoryDTO>>(listCategoryUrl, Token);
                CategoryDTO categoryDTO = new CategoryDTO();
                List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
                categoryDTO = result.data;
                categoryDTOs = listCategory.dataList;
                var model = (categoryDTO, categoryDTOs);
                return PartialView("_editCategory", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }

        public JsonResult AddCategory(CategoryDTO categoryDTO)
        {
            string url = _configuration["UrlVariable"] + "Category/save";
            if (categoryDTO.TopCategoryId == 0)
            {
                var categoryName = new CategoryLanguageDTO()
                {
                    Name = categoryDTO.Name,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    LanguageId = 1
                };
                var result = new CategoryDTO()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CategoryLanguageDTO = categoryName
                };
                try
                {
                    var Token = HttpContext.Session.GetString("token");
                    var ApiResult = ApiHandler.PostAPIWithModel<CategoryDTO>(result, url, Token);
                    return Json(1);
                }
                catch (System.Exception)
                {

                    return null;
                }
            }
            else
            {
                var categoryName = new CategoryLanguageDTO()
                {
                    Name = categoryDTO.Name,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    LanguageId = 1
                };
                var result = new CategoryDTO()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CategoryLanguageDTO = categoryName,
                    TopCategoryId = categoryDTO.TopCategoryId
                };
                try
                {
                    var Token = HttpContext.Session.GetString("token");
                    var ApiResult = ApiHandler.PostAPIWithModel<CategoryDTO>(result, url, Token);
                    return Json(1);
                }
                catch (System.Exception ex)
                {

                    return null;
                }
            }
        }

        public JsonResult editCategory(CategoryDTO category)
        {
            string url = _configuration["UrlVariable"] + "Category/update";
            if (category.TopCategoryId == null)
            {
                var categoryName = new CategoryLanguageDTO()
                {
                    Id = category.ProductLanguageCategoriesId,
                    Name = category.Name,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    LanguageId = 1,
                    CategoriesId = category.CategoriesId,

                };
                var result = new CategoryDTO()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CategoryLanguageDTO = categoryName,
                    Id = category.Id
                };
                try
                {
                    var Token = HttpContext.Session.GetString("token");
                    var apiResult = ApiHandler.PostAPIWithModel<CategoryDTO>(result, url, Token);
                    return Json(1);
                }
                catch (System.Exception ex)
                {
                    return null;
                }
            }
            else
            {
                var categoryName = new CategoryLanguageDTO()
                {
                    Name = category.Name,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    LanguageId = 1,
                    CategoriesId = category.CategoriesId,
                    Id = category.ProductLanguageCategoriesId
                };
                var result = new CategoryDTO()
                {
                    Id = category.Id,
                    UpdateDate = DateTime.Now,
                    Status = 1,
                    CategoryLanguageDTO = categoryName,
                    TopCategoryId = category.TopCategoryId
                };
                try
                {
                    var Token = HttpContext.Session.GetString("token");
                    var apiResult = ApiHandler.PostAPIWithModel<CategoryDTO>(result, url, Token);
                    return Json(1);
                }
                catch (System.Exception)
                {
                    return null;
                }
            }
        }
    }
}
