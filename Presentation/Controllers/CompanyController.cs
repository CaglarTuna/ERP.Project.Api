using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class CompanyController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public CompanyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public IActionResult Company()
        {
            string url = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                List<CompanyDTO> dto = new List<CompanyDTO>();
                dto = result.dataList;

                return View(dto);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        public JsonResult FindConpany(string Filter)
        {
            string url = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                List<CompanyDTO> dto = new List<CompanyDTO>();
                dto = result.dataList;
                if (!String.IsNullOrEmpty(Filter))
                {
                    dto = dto.Where(x =>
                    x.TaxNumber != null && x.TaxNumber.ToLower().Contains(Filter.ToLower())
                    || (x.TaxOffice != null && x.TaxOffice.ToLower().Contains(Filter.ToLower()))
                    || (x.Department != null && x.Department.ToLower().Contains(Filter.ToLower()))
                    || (x.ContactPerson != null && x.ContactPerson.ToLower().Contains(Filter.ToLower()))
                    || (x.Email != null && x.Email.ToLower().Contains(Filter.ToLower()))
                    || (x.Phone != null && x.Phone.ToLower().Contains(Filter.ToLower()))
                    || (x.Telephone != null && x.Telephone.ToLower().Contains(Filter.ToLower()))
                    ).ToList();
                }
                return Json(dto);
            }
            catch (System.Exception ex)
            {
                return Json(HttpStatusCode.BadRequest);
            }
        }
        
        public IActionResult CompanyInfo(int id)
        {
            string url = _configuration["UrlVariable"] + "Company/detail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                CompanyDTO companyDTO = new CompanyDTO();
                companyDTO = result.data;
                return View(companyDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        
        public JsonResult getCompany(int id)
        {
            string url = _configuration["UrlVariable"] + "Company/detail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                CompanyDTO companyDTO = new CompanyDTO();
                companyDTO = result.data;
                return Json(companyDTO);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        
        public IActionResult CompanyManagement(string filtre)
        {
            string url = _configuration["UrlVariable"] + "Company/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                List<CompanyDTO> dto = new List<CompanyDTO>();
                dto = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    dto = dto.Where(x =>
                    x.TaxNumber != null && x.TaxNumber.ToLower().Contains(filtre.ToLower())
                    || (x.TaxOffice != null && x.TaxOffice.ToLower().Contains(filtre.ToLower()))
                    || (x.Department != null && x.Department.ToLower().Contains(filtre.ToLower()))
                    || (x.ContactPerson != null && x.ContactPerson.ToLower().Contains(filtre.ToLower()))
                    || (x.Email != null && x.Email.ToLower().Contains(filtre.ToLower()))
                    || (x.Phone != null && x.Phone.ToLower().Contains(filtre.ToLower()))
                    || (x.Telephone != null && x.Telephone.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(dto);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        
        public IActionResult CompanyAdress(int id,string filtre)
        {
            string url = _configuration["UrlVariable"] + "Company/companyDetail/" + id;
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                var commonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                CompanyDTO company = new CompanyDTO();
                company = result.data;
                List<CommonDTO> commons = new List<CommonDTO>();
                commons = commonResult.dataList;
                var model = (company, commons);
                return View(model);
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }
     
        public IActionResult geteditComponyAdress(int id, int addresId)
        {
            string url = _configuration["UrlVariable"] + "Company/companyDetail/" + id;
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var commonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                CompanyAddressDTO dto = new CompanyAddressDTO();
                List<CommonDTO> commons = new List<CommonDTO>();
                commons = commonResult.dataList;
                dto = result.data.CompanyAddressDTOs.Where(x => x.Id == addresId).FirstOrDefault();
                var model = (dto, commons);
                return PartialView("_editComponyAdress", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
      
        public JsonResult getCityList(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            string commonUrl = _configuration["UrlVariable"] + "Common/getCity/" + id;
            try
            {
                var result = ApiHandler.GetAPI<DataDto<CityDTO>>(commonUrl, Token);
                List<CityDTO> cities = new List<CityDTO>();

                foreach (var item in result.dataList)
                {
                    CityDTO cityDTO = new CityDTO();
                    cityDTO.cityName = item.CityLanguage.FirstOrDefault().Name;
                    cityDTO.CityId = item.Id;
                    cities.Add(cityDTO);
                }
                return Json(cities);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
      
        public JsonResult confirm(int id)
        {
            string url = _configuration["UrlVariable"] + "Company/detail/" + id;
            string UpdateUrl = _configuration["UrlVariable"] + "Company/update";
            var Token = HttpContext.Session.GetString("token");
            try
            {
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                if (result.data.Status == 1)
                {
                    result.data.Status = 2;
                }
                else
                {
                    result.data.Status = 1;
                }
                CompanyDTO companyDTO = new CompanyDTO()
                {
                    ContactPerson = result.data.ContactPerson,
                    CreateDate = result.data.CreateDate,
                    Email = result.data.Email,
                    Department = result.data.Department,
                    Id = result.data.Id,
                    Name = result.data.Name,
                    Phone = result.data.Phone,
                    Prefix = result.data.Prefix,
                    Status = result.data.Status,
                    TaxNumber = result.data.TaxNumber,
                    TaxOffice = result.data.TaxOffice,
                    Telephone = result.data.Telephone,
                    UpdateDate = DateTime.Now
                };

                var Update = ApiHandler.PostAPIWithModel<CompanyDTO>(companyDTO, UpdateUrl, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
      
        public JsonResult AddCompany(CompanyDTO companyDTO)
        {
            string url = _configuration["UrlVariable"] + "Company/save";
            try
            {
                CompanyDTO company = new CompanyDTO()
                {
                    Prefix = companyDTO.Prefix,
                    ContactPerson = companyDTO.ContactPerson,
                    CreateDate = DateTime.Now,
                    Department = companyDTO.Department,
                    Email = companyDTO.Email,
                    Name = companyDTO.Name,
                    Phone = companyDTO.Phone,
                    Status = 1,
                    TaxNumber = companyDTO.TaxNumber,
                    TaxOffice = companyDTO.TaxOffice,
                    Telephone = companyDTO.Telephone,
                    UpdateDate = DateTime.Now
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<CompanyDTO>(company, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        
        public JsonResult EditCompany(CompanyDTO companyDTO)
        {
            string url = _configuration["UrlVariable"] + "Company/update";
            try
            {
                CompanyDTO company = new CompanyDTO()
                {
                    ContactPerson = companyDTO.ContactPerson,
                    Department = companyDTO.Department,
                    Email = companyDTO.Email,
                    Name = companyDTO.Name,
                    Phone = companyDTO.Phone,
                    Status = 1,
                    TaxNumber = companyDTO.TaxNumber,
                    TaxOffice = companyDTO.TaxOffice,
                    Telephone = companyDTO.Telephone,
                    UpdateDate = DateTime.Now,
                    Id = companyDTO.Id,
                    Prefix = companyDTO.Prefix
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<CompanyDTO>(company, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    
        public IActionResult CompanyManagementAdress(int id)
        {
            string url = _configuration["UrlVariable"] + "Company/companyDetail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<CompanyDTO>>(url, Token);
                CompanyDTO dto = new CompanyDTO();
                dto = result.data;
                return View(dto);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
      
        public JsonResult AddCompanyAdress(CompanyAddressDTO companyAddress)
        {
            string url = _configuration["UrlVariable"] + "Company/saveAddress";
            try
            {
                CompanyAddressDTO addressDTO = new CompanyAddressDTO()
                {
                    Address = companyAddress.Address,
                    AddressTitle = companyAddress.AddressTitle,
                    CompanyId = companyAddress.CompanyId,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    PostCode = companyAddress.PostCode,
                    Status = 1,
                    CityId = companyAddress.CityId,
                    CountryId = companyAddress.CountryId
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<CompanyAddressDTO>(addressDTO, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        
        public JsonResult editComponyAdress(CompanyAddressDTO companyAddressDTO)
        {
            string url = _configuration["UrlVariable"] + "Company/editAdres";
            try
            {
                CompanyAddressDTO companyAddress = new CompanyAddressDTO()
                {
                    Address = companyAddressDTO.Address,
                    AddressTitle = companyAddressDTO.AddressTitle,
                    CityId = companyAddressDTO.CityId,
                    CompanyId = companyAddressDTO.CompanyId,
                    CountryId = companyAddressDTO.CountryId,
                    Id = companyAddressDTO.Id,
                    PostCode = companyAddressDTO.PostCode,
                    Status = 1,
                    UpdateDate = DateTime.Now
                };
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<CompanyAddressDTO>(companyAddress, url, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        
        public IActionResult CompanyOrderHistory(int id,DateTime FirstDate,DateTime LastDate,string Filter)
        {
            var url = _configuration["UrlVariable"] + "Order/listproduction";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                List<OrderDTO> orders = new List<OrderDTO>();
                orders = result.dataList;
                orders = orders.Where(x => x.CompanyId == id).ToList();
                if (Filter != null||FirstDate!=DateTime.MinValue||LastDate!=DateTime.MinValue)
                {
                    orders = orders.Where(x => x.OrderNo != null && x.OrderNo.ToLower().Contains(Filter.ToLower())
                      || (x.OrderDate != null && x.OrderDate >= FirstDate || x.OrderDate <= LastDate)
                      || (x.Offers.Count() > 0 && x.Offers.Any(z => z.TotalCost != null && z.TotalCost.ToLower().Contains(Filter.ToLower())))
                    ).ToList();
                }
                return View(orders);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
       
        public IActionResult CompanyOrderDetail(int id)
        {
            var url = _configuration["UrlVariable"] + "Order/orderProduct/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<OrderDTO>>(url, Token);
                OrderDTO order = new OrderDTO();
                order = result.data;
                return View(order);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        public IActionResult CompanyMaterialCertificate(int id)
        {
            var url = _configuration["UrlVariable"] + "Material/certificateMissingMaterial/list/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<MaterialCertificatesDTO>>(url, Token);
                return View(result.dataList);
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
