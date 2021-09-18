using Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Vuelos.Controllers.CheckSesion;

namespace Vuelos.Controllers
{
    public class UsuarioController : Controller
    {
        [SessionCheck]
        public IActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View(usuario.Select());
        }
    }
}
