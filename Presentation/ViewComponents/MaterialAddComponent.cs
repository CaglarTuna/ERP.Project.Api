using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ViewComponents
{
    public class MaterialAddComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public MaterialAddComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IViewComponentResult Invoke()
        {
            string firma = _configuration["UrlVariable"] + "Company/list";
            string hammadde = _configuration["UrlVariable"] + "RawMaterial/list";
            string commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var company = ApiHandler.GetAPI<DataDto<CompanyDTO>>(firma,Token);
                var rawMaterial = ApiHandler.GetAPI<DataDto<RawMaterialDTO>>(hammadde,Token);
                var common = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                List<RawMaterialDTO> rawMaterials = new List<RawMaterialDTO>();
                List<CompanyDTO> companyDTOs = new List<CompanyDTO>();
                List<CommonDTO> commons = new List<CommonDTO>();
                commons = common.dataList;
                rawMaterials = rawMaterial.dataList;
                companyDTOs = company.dataList;
                var model = (rawMaterials, companyDTOs, commons);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
