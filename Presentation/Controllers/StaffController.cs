using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Presentation.ApiHandlers;
using Presentation.Filter;
using Presentation.ResponseModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ActionFilters]
    public class StaffController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public StaffController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Personel Yönetimi sayfalı listeleme işlemi
        public IActionResult Index(int languageId, string filtre)
        {
            languageId = 1;
            string url = _configuration["UrlVariable"] + "Staff/list/" + languageId;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                var commonResult = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                List<CommonDTO> commons = new List<CommonDTO>();
                List<StaffDTO> Staff = new List<StaffDTO>();
                Staff = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    Staff = Staff.Where(x => x.Name != null && x.Name.ToLower().Contains(filtre.ToLower())
                    || (x.Surname != null && x.Surname.ToLower().Contains(filtre.ToLower()))
                    || (x.Email != null && x.Email.ToLower().Contains(filtre.ToLower()))
                    || (x.Telephone != null && x.Telephone.ToLower().Contains(filtre.ToLower()))
                    || (x.Department != null && x.Department.ToLower().Contains(filtre.ToLower()))
                    || (x.Address != null && x.Address.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                commons = commonResult.dataList;
                var model = (Staff, commons);
                return View(model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Personel yönetimi sayfası edit popup
        public IActionResult getStaffEdit(int id)
        {
            string url = _configuration["UrlVariable"] + "Staff/detail/" + id;
            var commonUrl = _configuration["UrlVariable"] + "Common/list";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                StaffDTO staffDTO = new StaffDTO();
                List<CommonDTO> commons = new List<CommonDTO>();
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                var common = ApiHandler.GetAPI<DataDto<CommonDTO>>(commonUrl, Token);
                staffDTO = result.data;
                commons = common.dataList;
                var model = (staffDTO, commons);
                return PartialView("_staffEdit", model);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Personeller sayfası listeleme işlemi
        public IActionResult Staff(string filtre)
        {
            string url = _configuration["UrlVariable"] + "Staff/list/" + 1;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                List<StaffDTO> staff = new List<StaffDTO>();
                staff = result.dataList;
                if (!String.IsNullOrEmpty(filtre))
                {
                    staff = staff.Where(x => x.Name != null && x.Name.ToLower().Contains(filtre.ToLower())
                    || (x.Surname != null && x.Surname.ToLower().Contains(filtre.ToLower()))
                    || (x.Email != null && x.Email.ToLower().Contains(filtre.ToLower()))
                    || (x.Telephone != null && x.Telephone.ToLower().Contains(filtre.ToLower()))
                    || (x.Department != null && x.Department.ToLower().Contains(filtre.ToLower()))
                    || (x.Address != null && x.Address.ToLower().Contains(filtre.ToLower()))
                    ).ToList();
                }
                return View(staff);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Personel Detay Sayfası
        public IActionResult StaffInfo(int id)
        {
            string url = _configuration["UrlVariable"] + "Staff/detail/" + id;
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                StaffDTO staff = new StaffDTO();
                staff = result.data;
                return View(staff);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region personel yönetimi sayfası Personel detay fonksiyonu
        public JsonResult getStaff(int id)
        {
            string url = _configuration["UrlVariable"] + "Staff/detail/" + id;

            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                StaffDTO staf = new StaffDTO();
                staf = result.data;
                return Json(staf);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Staff Aktif Pasif Fonksiyonu
        public JsonResult confirm(int id)
        {
            string url = _configuration["UrlVariable"] + "Staff/detail/" + id;
            string update = _configuration["UrlVariable"] + "Staff/Confirm";
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.GetAPI<DataDto<StaffDTO>>(url, Token);
                StaffDTO staf = new StaffDTO();
                staf = result.data;
                if (staf.Status == 1)
                {
                    staf.Status = 2;
                }
                else
                {
                    staf.Status = 1;
                }
                var deger = ApiHandler.PostAPIWithModel<StaffDTO>(staf, update, Token);
                return Json(1);
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Personel Ekleme Fonksiyonu
        public JsonResult AddStaff(StaffDTO staff, string[] Process, string[] roles)
        {
            string url = _configuration["UrlVariable"] + "Staff/save";
            Random random = new Random();
            List<StaffRolesDTO> role = new List<StaffRolesDTO>();

            List<StaffProcessPermisionsDTO> permisions = new List<StaffProcessPermisionsDTO>();
            int staffNo = random.Next(0, 10000);
            foreach (var item in roles)
            {
                role.Add(new StaffRolesDTO()
                {
                    CreateDate = DateTime.Now,
                    RoleId = Convert.ToInt32(item),
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            foreach (var item in Process)
            {
                permisions.Add(new StaffProcessPermisionsDTO()
                {
                    ProcessId = Convert.ToInt32(item),
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Status = 1
                });
            }
            StaffDTO staffDTO = new StaffDTO()
            {
                Name = staff.Name,
                Surname = staff.Surname,
                Email = staff.Email,
                Telephone = staff.Telephone,
                Department = staff.Department,
                Address = staff.Address,
                RoleId = staff.RoleId,
                ProcessId = staff.ProcessId,
                StaffNo = staffNo.ToString(),
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Status = 1,
                StaffProcessPermisionsDTOs = permisions,
                StaffRolesDTO = role
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<StaffDTO>>(staffDTO, url, Token);
                if (result.statu == true)
                {
                    return Json(1);
                }
                else
                {
                    return Json(2);
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
        #endregion
        #region Personel Güncelleme Fonksiyonu
        public JsonResult editStaff(StaffDTO staff, string[] Process, string[] roles)
        {
            string url = _configuration["UrlVariable"] + "Staff/update";
            List<StaffRolesDTO> role = new List<StaffRolesDTO>();
            List<StaffProcessPermisionsDTO> permisions = new List<StaffProcessPermisionsDTO>();
            foreach (var item in roles)
            {
                role.Add(new StaffRolesDTO()
                {
                    CreateDate = DateTime.Now,
                    RoleId = Convert.ToInt32(item),
                    Status = 1,
                    UpdateDate = DateTime.Now
                });
            }
            foreach (var item in Process)
            {
                permisions.Add(new StaffProcessPermisionsDTO()
                {
                    ProcessId = Convert.ToInt32(item),

                    UpdateDate = DateTime.Now,
                    Status = 1
                });
            }
            StaffDTO staffDTO = new StaffDTO()
            {
                Id = staff.Id,
                Name = staff.Name,
                Surname = staff.Surname,
                Email = staff.Email,
                Telephone = staff.Telephone,
                Department = staff.Department,
                Address = staff.Address,
                RoleId = staff.RoleId,
                ProcessId = staff.ProcessId,
                StaffNo = staff.StaffNo,
                UpdateDate = DateTime.Now,
                Status = 1,
                StaffProcessPermisionsDTOs = permisions,
                StaffRolesDTO = role
            };
            try
            {
                var Token = HttpContext.Session.GetString("token");
                var result = ApiHandler.PostAPIWithModel<DataDto<StaffDTO>>(staffDTO, url, Token);
                if (result.statu == true)
                {
                    return Json(1);
                }
                else
                {
                    return Json(2);
                }
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }
        #endregion
        public IActionResult StaffEffort(int id)
        {
            var Token = HttpContext.Session.GetString("token");
            var url = _configuration["UrlVariable"] + "Staff/effort/" + id;
            try
            {
                var result = ApiHandler.GetAPI<DataDto<StaffProcessDTO>>(url, Token);
                return View(result.dataList);
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
