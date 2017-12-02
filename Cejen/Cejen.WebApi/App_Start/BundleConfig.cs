using System.Web;
using System.Web.Optimization;

namespace Cejen.WebApi
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {



            bundles.Add(new ScriptBundle("~/bundles/javascriptq").Include(
                      "~/Scripts/jquery-1.9.1.js",
                      "~/Scripts/skel.min.js",
                      "~/Scripts/video.js",
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/jquery.singlePageNav.min.js",
                      "~/Scripts/parallax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-touch.js",
                        "~/Scripts/angular-animate.js",
                        "~/Scripts/angular-ui/ui-bootstrap.js",
                        "~/Scripts/angular-ui/ui-utils.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                        "~/Scripts/angular-sanitize.js",
                        "~/Scripts/angular-route.js"
                        ));

            bundles.Add(new StyleBundle("~/bundles/app/app-angular").Include(
                        "~/app/app.js",
                        "~/app/directives.js",
                        "~/app/config-route.js"));


            bundles.Add(new StyleBundle("~/bundles/app/dataServices").Include(
                      "~/app/dataServices/dataServices.js",
                      "~/app/dataServices/temaServices.js",
                      "~/app/dataServices/textoTemaServices.js"
                      ));



            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                       "~/app/application/home/home.controller.js",
                       "~/app/application/fotos/fotos.controller.js",
                       "~/app/application/video/video.controller.js",
                       "~/app/application/navbar/navbar.controller.js",
                       "~/app/application/navbarHome/navbarHome.controller.js",
                       "~/app/application/partialView/noticias/noticias.controller.js",
                       "~/app/application/partialView/listaNoticias/listaNoticias.controller.js"

                       ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/ui-bootstrap-csp.css",
                "~/Content/bootstrap-image-gallery.css",
                "~/Content/cejen-themes/home.css",
                "~/Content/style.css",
                "~/Content/video.css",
                "~/Content/thumbnail-gallery"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            System.Web.Optimization.BundleTable.EnableOptimizations = false;
        }
    }
}