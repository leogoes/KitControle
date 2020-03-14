using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kit.UI.Models;
using Kit.Domain.Models;
using Kit.Application.Interfaces;

namespace Kit.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAppServiceBase<Usuario> _appServiceBase;

        public HomeController(ILogger<HomeController> logger, IAppServiceBase<Usuario> appServiceBase)
        {
            _logger = logger;
            _appServiceBase = appServiceBase;
        }

        public IActionResult Index()
        {
            var usuario = _appServiceBase.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
