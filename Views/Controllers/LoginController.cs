using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vuelos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(DataAcces.DTOModels.Login model)
        {
            Business.Login login = new Business.Login();
            var usersession = login.login(model);
            if (usersession.Status == 1)
            {
                HttpContext.Session.SetString("User", usersession.Data);
                return RedirectToAction("Index", "Vuelo", new { error = "ok" });
            }
            else
            {
                return RedirectToAction("Index", "Login", new { error = "El usuario o clave no es válido" });
            }
        }

        public IActionResult Register()
        {

            return Ok();

        }
    }
}
