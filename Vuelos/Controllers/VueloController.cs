using DataAcces.DTOModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Vuelos.Controllers.CheckSesion;

namespace Vuelos.Controllers
{
    public class VueloController : Controller
    {
        
        [SessionCheck]
        public IActionResult Index()
        {
            Business.Vuelo vuelo = new Business.Vuelo();
            ViewBag.title = "Lista de vuelos";
            return View(vuelo.List());
        }

        [SessionCheck]
        public IActionResult New(DTONuevoVuelo model)
        {

            Business.Vuelo vuelo = new Business.Vuelo();
            if (vuelo.New(model).Status ==1)
            {
                return RedirectToAction("Index","Vuelo");
            }
            return RedirectToAction("ErrorPage","Vuelo",new {error ="No se pudo insertar el registro"});
        }

        [SessionCheck]
        public IActionResult ErrorPage(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        public IActionResult ChangeStatus(DataAcces.Models.Vwvuelos model)
        {
            Business.Vuelo vuelo = new Business.Vuelo();
            return Ok(vuelo.ChangeStatus(model));
        }
    }
}
