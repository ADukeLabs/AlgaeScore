using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASWeb2._0
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "Process/Home/",
                defaults: new { controller = "Process", action = "DefaultHome" }
                );

            routes.MapRoute(
                name: "Image",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Process", action = "Index", name = UrlParameter.Optional }
                );
        }
    }
}
