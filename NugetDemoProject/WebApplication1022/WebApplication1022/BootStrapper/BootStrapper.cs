using Authorization_Module_BAL;
using Authorization_Module_BAL.Mapping;
using Authorization_Module_Common.Resolver;
using Authorization_Module_DAL;
using Authorization_Module_DAL.Contexts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace WebApplication1022.Resolver
{
    public class BootStrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<AuthorizationModuleDbContext>(new HierarchicalLifetimeManager(), new InjectionConstructor("Default"));
            container.RegisterServiceBAL();
            container.RegisterServiceDAL();
            var Mappingconfigure = MappingRegister.Initlize();
            container.RegisterInstance<IMapper>(Mappingconfigure.CreateMapper());
            return container;
        }
    }
}