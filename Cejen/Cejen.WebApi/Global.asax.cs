using Bootstrap;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Cejen.WebApi.Infra.DI;
using Cejen.WebApi.Infra.DI.Api;
using Cejen.WebApi.Infra.DI.Mvc;
using Cejen.Business.AutoMapper;

namespace Cejen.WebApi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode,
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfiguradorDeInjecaoDeDependencia.ObterDependencyResolver(GlobalConfiguration.Configuration);
            ConfiguradorDeInjecaoDeDependenciaMvc.ObterDependencyResolver();
        }
    }
}
