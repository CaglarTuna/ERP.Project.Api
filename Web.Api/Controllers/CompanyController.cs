using DTO;
using DTO.DTOValidators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using Web.Api.Filters;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        ICompanyService _companyService;
        ICompanyAdressService _companyAdressService;
        CompanyDTOValidator _companyDTOValidator;
        CompanyAddressDTOValidator _companyAddressDtoValidator;

        public CompanyController(ICompanyService companyService, ICompanyAdressService companyAdressService)
        {
            _companyService = companyService;
            _companyDTOValidator = new CompanyDTOValidator();
            _companyAdressService = companyAdressService;
            _companyAddressDtoValidator = new CompanyAddressDTOValidator();
        }

        [HttpPost("save")]
        public JsonResult Save([FromBody] CompanyDTO companyDTO)
        {
            FluentValidation.Results.ValidationResult validate = _companyDTOValidator.Validate(companyDTO);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + "  " + item.ErrorMessage;
                }
                return Json(new ResultDTO<CompanyDTO>()
                {
                    Statu = false,
                    Message = message

                });
            }
            _companyService.Add(companyDTO);
            var model = new ResultDTO<CompanyDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpPost("saveAddress")]
        public JsonResult saveAdress([FromBody] CompanyAddressDTO companyAddress)
        {
            FluentValidation.Results.ValidationResult validate = _companyAddressDtoValidator.Validate(companyAddress);
            if (!validate.IsValid)
            {
                string message = "";
                foreach (var item in validate.Errors)
                {
                    message = message + " " + item.ErrorMessage;
                }
                return Json(new ResultDTO<CompanyAddressDTO>()
                {
                    Statu = false,
                    Message = message
                });
            }
            _companyAdressService.Add(companyAddress);
            var model = new ResultDTO<CompanyAddressDTO>()
            {
                Statu = true,
                Message = "Success"
            };
            return Json(model);
        }
        [HttpGet("list")]
        public JsonResult List()
        {
            var result = _companyService.GetAll(1);
            var model = new ResultDTO<CompanyDTO>()
            {
                Statu = true,
                Message = "Success",
                DataList = result
            };
            return Json(model);
        }
        [HttpGet("detail/{companyId}")]
        public JsonResult Detail(int companyId)
        {
            var result = _companyService.GetById(companyId, 1);
            var model = new ResultDTO<CompanyDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("companyDetail/{companyId}")]
        public JsonResult CompanyDetail(int companyId)
        {
            var result = _companyService.getComponyDetail(companyId);
            var model = new ResultDTO<CompanyDTO>()
            {
                Statu = true,
                Message = "Success",
                Data = result
            };
            return Json(model);
        }
        [HttpGet("offer/list")]
        public JsonResult ListOffer(int offerId)
        {
            var resutl = _companyService.GetAll(1);
            return Json(resutl);
        }
        [HttpGet("order/list")]
        public JsonResult ListOrder()
        {
            var result = _companyService.GetAll(1);
            return Json(result);
        }
        [HttpGet("product/list")]
        public JsonResult ListProduct()
        {
            var result = _companyService.GetAll(1);
            return Json(result);
        }
        [HttpGet("address")]
        public JsonResult AddressCompany()
        {
            var result = _companyService.GetAll(1);
            return Json(result);
        }
        [HttpPost("update")]
        public JsonResult Update(CompanyDTO companyDTO)
        {
            bool updatedvalue = _companyService.Update(companyDTO);
            if (updatedvalue)
            {
                var model = new ResultDTO<CompanyDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<CompanyDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpPost("editAdres")]
        public JsonResult AdressUpdate(CompanyAddressDTO companyAddressDTO)
        {
            bool updateValue = _companyAdressService.Update(companyAddressDTO);
            if (updateValue)
            {
                var model = new ResultDTO<CompanyAddressDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<CompanyAddressDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
        [HttpGet("delete/{id}")]
        public JsonResult Delete(int id)
        {
            bool deletedvalue = _companyService.Delete(id);
            if (deletedvalue)
            {
                var model = new ResultDTO<CompanyDTO>()
                {
                    Statu = true,
                    Message = "Success"
                };
                return Json(model);
            }
            else
            {
                var model = new ResultDTO<CompanyDTO>()
                {
                    Statu = false,
                    Message = "Fail"
                };
                return Json(model);
            }
        }
    }
}