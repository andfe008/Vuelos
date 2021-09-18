using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static Vuelos.Controllers.CheckSesion;

namespace Vuelos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [SessionCheck]
        public IActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View(usuario.Select());
        }

        [SessionCheck]
        public IActionResult Privacy()
        {
            return View();
        }

        [SessionCheck]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
