using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentation.ApiHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly IConfiguration _configuration;
        ApiHandler ApiHandler = new ApiHandler();
        public CurrencyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult CurrencyList()
        {
            return View();
        }
    }
}
