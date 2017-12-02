using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cejen.WebApi.Infra.DI.Mvc
{
    public class UnityHttpControllerActivatorMvc : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}