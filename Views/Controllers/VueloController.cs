using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Vuelos.Controllers
{
    public class VueloController : Controller
    {
        //[Authorization]
        public ActionResult Index()
        {
            Business.Vuelo vuelo = new Business.Vuelo();
            ViewBag.title = "Lista de vuelos";
            return View(vuelo.List());
        }

        public ActionResult New(DTONuevoVuelo model)
        {

            Business.Vuelo vuelo = new Business.Vuelo();
            if (vuelo.New(model).Status ==1)
            {
                return RedirectToAction("Index","Vuelo");
            }
            return RedirectToAction("ErrorPage","Vuelo",new {error ="No se pudo insertar el registro"});
        }

        public ActionResult ErrorPage(string error)
        {
            ViewBag.Error = error;
            return View();
        }
    }
}
