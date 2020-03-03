using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ETicaret
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "UrlRewrite",
                url: "{urunAdi}-{idsi}-urunu",
                defaults: new { controller = "Product", action = "Detail", idsi = UrlParameter.Optional }
            ,                namespaces: new string[] { "ETicaret.Controllers" }

                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ,                namespaces: new string[] { "ETicaret.Controllers" }
                );
        }
    }
}
