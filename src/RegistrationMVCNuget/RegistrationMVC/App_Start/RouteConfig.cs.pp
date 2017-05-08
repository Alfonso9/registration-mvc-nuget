using System.Web.Mvc;
using System.Web.Routing;

namespace $rootnamespace$.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region  CuentasController
            routes.MapRoute(
                name: "Controlador Cuentas",
                url: "Cuentas/{action}",
                defaults: new { controller = "Cuentas", action = "IniciarSesion"}
            );
            #endregion

            #region  PrincipalController
            routes.MapRoute(
                name: "Controlador Principal",
                url: "Principal/{action}",
                defaults: new { controller = "Principal", action = "Index" }
            );
            #endregion

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Cuentas", action = "IniciarSesion", id = UrlParameter.Optional }
            );
        }
    }
}
