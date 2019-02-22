using System.Web.Mvc;
using System.Web.Routing;

namespace Colors
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AddColors",
                url: "{controller}/{action}/{color1}/{color2}/{result}",
                defaults: new { controller = "Home", action = "Index",
                    color1 = UrlParameter.Optional,
                    color2 = UrlParameter.Optional, 
                    result = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
