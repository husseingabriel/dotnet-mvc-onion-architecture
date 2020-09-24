using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Services;
using OnionArchitecture.Infrastructure.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace OnionArchitecture.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPersonService, PersonService>();
            container.RegisterType(typeof(IRepository<>), typeof(BaseRepository<>));
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}