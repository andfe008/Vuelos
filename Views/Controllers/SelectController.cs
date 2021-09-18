using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vuelos.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult City()
        {
            Business.Select select = new Business.Select();
            return Ok(select.City());
        }
        
        public IActionResult Airline()
        {
            Business.Select select = new Business.Select();
            return Ok(select.Airline());
        }

        public IActionResult Filter(int id)
        {
            Business.Select select = new Business.Select();
            return Ok(select.Filter(id));
        }


        public IActionResult Flys()
        {
            Business.Select select = new Business.Select();
            return Ok(select.Flys());
        }

    }
}
