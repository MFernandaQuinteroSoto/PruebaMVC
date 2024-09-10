using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp_y_mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //debe estregar el recurso ignorando el resto de las rutas.

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",  //ese recurso es solicitado a travez de la url del navegador. 
                //controllers: crea una instancia del controlador <<Home>>
                //action: Invoca el método <<index>>, se expecifica la acción que desea realizar en la aplicación.
                //id: Especifica el parametro de entrada del método de la accion.

                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
                
            );  
        }
    }
}
