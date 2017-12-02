using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using Microsoft.Practices.Unity;
using Cejen.Infra;

namespace Cejen.WebApi.Infra.DI.Api
{
    public static class ConfiguradorDeInjecaoDeDependencia
    {
        public static IDependencyResolver ObterDependencyResolver(HttpConfiguration config)
        {
            var container = ObterContainer(config);
            return new UnityDependencyResolver(container);
        }

        private static IUnityContainer ObterContainer(HttpConfiguration config)
        {
            var container = new UnityContainer();
            RegistrarAssembly(Assembly.GetAssembly(typeof(CejenDbContext)), container);
            //RegistrarAssembly(Assembly.GetAssembly(typeof(TemaController)), container);
            //RegistrarAssembly(Assembly.GetAssembly(typeof(ITemaBusiness)), container);
            RegistrarServicosMvc(container);
            //container.RegisterType<IUnitOfWork, UnitOfWork>(new InjectionProperty("UnitOfWork"));

            config.DependencyResolver = new UnityDependencyResolver(container);

            return container;
        }

        private static void RegistrarAssembly(Assembly assembly, UnityContainer container)
        {
            var classes = from t in assembly.GetTypes()
                          where t.IsPublic && !t.IsAbstract && t.IsClass
                          select t;

            foreach (var type in classes)
                foreach (var @interface in type.GetInterfaces())
                    container.RegisterType(@interface, type, new PerResolveLifetimeManager());
        }

        private static void RegistrarServicosMvc(IUnityContainer container)
        {
            container.RegisterType<IHttpControllerActivator, UnityHttpControllerActivator>();
        }
    }
}