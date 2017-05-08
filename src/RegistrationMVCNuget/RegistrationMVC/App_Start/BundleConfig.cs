using System.Web.Optimization;

//namespace $rootnamespace$.App_Start
namespace RegistrationMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //========================================= Inician Estilos ===============================================

            bundles.Add(new StyleBundle("~/bundles/boostrap-font-styles")
                .Include("~/Scripts/bower_components/vendors/tether/dist/js/tether.min.js")
                .Include("~/Scripts/bower_components/vendors/bootstrap/dist/css/bootstrap.min.css")
                .Include("~/Scripts/bower_components/vendors/font-awesome/css/font-awesome.min.css")
            );

            //Estilos Base
            bundles.Add(new StyleBundle("~/bundles/site-style")
               .Include("~/Content/css/Site.css")
            );

            //========================================= Terminan Estilos ===============================================

            //========================================= Inician Scripts ===============================================

            //Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/jquery-bootstrap-scripts")
                .Include("~/Scripts/bower_components/vendors/jquery/dist/jquery.min.js")
                .Include("~/Scripts/bower_components/vendors/tether/dist/js/tether.min.js")
                .Include("~/Scripts/bower_components/vendors/bootstrap/dist/js/bootstrap.min.js")
                .Include("~/Scripts/ie10-viewport-bug-workaround.js")
            );
            
            //Scripts base
            bundles.Add(new ScriptBundle("~/bundles/base-scripts")
                .Include("~/Scripts/BaseSite.js")
                .Include("~/Scripts/ServicesSite.js")
            );

            BundleTable.EnableOptimizations = true;
        }
    }
}