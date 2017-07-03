using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RegistrationMVC.Filters
{
    public class SesionIniciada : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                //var _Usuario = HttpContext.Current.Session["Usuario"];

                //if (_Usuario == null)
                //{

                //}

                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    { "controller", "Principal" },
                    { "action", "Index" }
                });
            }
        }
    }
}