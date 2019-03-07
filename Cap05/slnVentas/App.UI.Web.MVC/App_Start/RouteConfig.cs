using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App.UI.Web.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*Ruta estática*/
            routes.MapRoute(
                name: "rutaEstaticaCatalogo",
                url: "Catalogo",
                defaults: new
                {
                    controller = "Producto",
                    action = "Index2"
                }
                );

            

            /*Ruta SEO*/
            routes.MapRoute(
                name: "rutaSEOEstaticaCatalogo",
                url: "Catalogo/{id}/{name}",
                defaults: new
                {
                    controller = "Producto",
                    action = "Edit"
                }
                );

            /*Mapa de ruta por defecto va al final*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new string[] {"App.Ui.Web.MVC.Controllers"}
            );
        }
    }
}
