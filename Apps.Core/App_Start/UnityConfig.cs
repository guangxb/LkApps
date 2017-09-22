using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace Apps.Core
{
    public static class UnityConfig
    {
        public static void RegisterComponentsByWebApi()
        {
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //×¢Èë Ioc
            // var container = new UnityContainer();

            //var container = new UnityContainer();
            //DependencyRegisterType.Container(ref container);
            //DependencyRegisterType.ContainerPartial(ref container);
            //GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            DependencyRegisterType.Container(container);
            //DependencyRegisterType.ContainerPartial(container);
            //DependencyRegisterType.SCVContainer(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}