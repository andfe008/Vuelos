using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Vuelos.Controllers.CheckSesion;

namespace Vuelos.Controllers
{
    public class SelectController : Controller
    {
        [SessionCheck]
        public IActionResult Index()
        {
            return View();
        }

        [SessionCheck]
        public IActionResult City()
        {
            Business.Select select = new Business.Select();
            return Ok(select.City());
        }

        [SessionCheck]
        public IActionResult Airline()
        {
            Business.Select select = new Business.Select();
            return Ok(select.Airline());
        }

        [SessionCheck]
        public IActionResult Filter(int id)
        {
            Business.Select select = new Business.Select();
            return Ok(select.Filter(id));
        }

        [SessionCheck]
        public IActionResult Flys()
        {
            Business.Select select = new Business.Select();
            return Ok(select.Flys());
        }

    }
}
