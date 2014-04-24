using System.Web.Mvc;
using System.Web.Routing;

namespace PatternViewModel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{action}.html",
                defaults: new { controller = "Home" }
            );
        }
    }
}
