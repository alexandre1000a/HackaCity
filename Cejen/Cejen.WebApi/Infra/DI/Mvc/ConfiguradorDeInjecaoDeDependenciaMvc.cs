using Microsoft.Practices.Unity;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

using Cejen.Infra;
using Cejen.WebApi.Controllers;

namespace Cejen.WebApi.Infra.DI.Mvc
{
    public static class ConfiguradorDeInjecaoDeDependenciaMvc
    {
        public static IDependencyResolver ObterDependencyResolver()
        {
            var container = ObterContainer();
            return new UnityDependencyResolverMvc(container);
        }

        private static IUnityContainer ObterContainer()
        {
            var container = new UnityContainer();
            RegistrarAssembly(Assembly.GetAssembly(typeof(CejenDbContext)), container);
            RegistrarServicosMvc(container);
            //container.RegisterType<IUnitOfWork, UnitOfWork>(new InjectionProperty("UnitOfWork"));

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
            container.RegisterType<IControllerActivator, UnityHttpControllerActivatorMvc>();
        }
    }
}