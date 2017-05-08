using RegistrationMVC.App_Start;
using RegistrationMVC.Infraestructure.Ninject;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RegistrationMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            /*Inyector de dependencias*/
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
    }
}
