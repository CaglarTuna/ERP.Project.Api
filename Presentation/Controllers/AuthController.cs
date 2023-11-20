using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Generators;
using Presentation.ApiHandlers;
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
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index(string message)
        {
            ViewBag.message = message;
            return View();
        }
        public IActionResult Login(UserDTO userDTO)
        {
            var url = _configuration["UrlVariable"] + "Account/login";
            try
            {
                var result = ApiHandler.PostAPITokenWithModel<DataDto<StaffDTO>>(userDTO, url);
                ViewBag.message = result.message;
                if (result.data != null)
                {
                    var Roles = result.data.StaffRolesDTO;
                    var StaffName = result.data.Name + " " + result.data.Surname;
                    HttpContext.Session.SetInt32("StaffId", result.data.Id);
                    HttpContext.Session.SetString("token", result.data.Token);
                    HttpContext.Session.SetString("UserName", StaffName);
                    HttpContext.Session.SetString("RoleList", JsonConvert.SerializeObject(Roles));
                    var list = HttpContext.Session.GetString("RoleList");
                    var liste = JsonConvert.DeserializeObject<List<StaffRolesDTO>>(list);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Auth", new { message = ViewBag.message });
                }
            }
            catch (System.Exception ex)
            {
                return RedirectToAction("Index", "Auth",new { message = ViewBag.message});
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("StaffId");
            HttpContext.Session.Remove("token");
            HttpContext.Session.Remove("RoleList");
            return RedirectToAction("Index", "Auth");
        }
    }
}
