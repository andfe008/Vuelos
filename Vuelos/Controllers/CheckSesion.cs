using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Web;

namespace Vuelos.Controllers
{
    public class CheckSesion : ActionFilterAttribute
    {
        public class SessionCheck : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext actionExecutingContext)
            {
                string ControllerName = (string)actionExecutingContext.RouteData.Values["Controller"];
                var user = actionExecutingContext.HttpContext.Session.GetString("User");


                if (user == null || user == "{}")
                {
                    actionExecutingContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Login",
                        action = "Index",
                        returnurl = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetEncodedUrl(actionExecutingContext.HttpContext.Request)
                    }));
                }
                else
                {
                    var userObject = Newtonsoft.Json.JsonConvert.DeserializeObject<DataAcces.Models.Usuario>(user);
                    if (userObject.IdRol == 1)
                    {
                        if (ControllerName !="Vuelo")
                        {
                            actionExecutingContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                            {
                                controller = "Vuelo",
                                action = "Index",
                                returnurl = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetEncodedUrl(actionExecutingContext.HttpContext.Request)
                            }));
                        }
                    }

                    if (userObject.IdRol == 2)
                    {
                        if (ControllerName !="Usuario")
                        {
                            actionExecutingContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                            {
                                controller = "Usuario",
                                action = "Index",
                                returnurl = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetEncodedUrl(actionExecutingContext.HttpContext.Request)
                            }));
                        }
                    }
                }
            }
        }
    }
}