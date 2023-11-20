using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using Web.Api.Filters;
using Web.Api.Helpers;

namespace Web.Api.Controllers
{
    [ExceptionFilter("")]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private IConfiguration _config;
        private JwtSettings JwtSettings;
        private IStaffService _staffService;
        public AccountController(IConfiguration config, IOptions<JwtSettings> jwtSettings, IStaffService staffService)
        {
            _config = config;
            JwtSettings = jwtSettings.Value;
            _staffService = staffService;
        }
        //Swagger çalışması için ekstra  route yazmak yerine HttpPost veya HttpGet gibi özelliklerin yanına route belirtebilirsiniz
        [AllowAnonymous]
        [HttpPost("login")]
        public JsonResult Login([FromBody] UserDTO userDTO)
        {
            var result = _staffService.GetBy(userDTO.Email, userDTO.Password);

            if (result != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", result.Email));
                claims.Add(new Claim("displayname", result.Email));
                foreach (var item in result.StaffRolesDTO)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item.Roles.Name));
                }
                var token = JwtHelper.GetJwtToken(result.Email, JwtSettings, new TimeSpan(0, 60, 0), claims.ToArray());
                result.Token = token;
                var model = new ResultDTO<StaffDTO>()
                {
                    Data = result,
                    Message = "Kullanıcı Girişi Başarılı",
                    Statu = true
                };
                return Json(model);
            }
            var ExModel = new ResultDTO<StaffDTO>()
            {
                Data = result,
                Message = "Kullanıcı Adı veya Şifre Hatalı",
                Statu = true
            };
            return Json(ExModel);
        }
    }
}