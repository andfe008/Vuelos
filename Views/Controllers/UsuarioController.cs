using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vuelos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            Business.Select select = new Business.Select();
            //return Ok(select.());

            return View();
        }
    }
}
