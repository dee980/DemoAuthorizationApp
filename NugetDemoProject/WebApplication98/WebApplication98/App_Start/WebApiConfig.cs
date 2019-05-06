using Authorization_Module_BAL;
using Authorization_Module_BAL.Mapping;
using Authorization_Module_DAL;
using Authorization_Module_DAL.Contexts;
using Authorization_Module_Framework_API.Handlers;
using Authorization_Module_Framework_API.Resolver;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace WebApplication98
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());

            var container = new Unity.UnityContainer();
            container.RegisterServiceDAL();
            container.RegisterServiceBAL();
            container.RegisterType<AuthorizationModuleDbContext>(new HierarchicalLifetimeManager(), new InjectionConstructor("Default"));
            var Mappingconfigure = MappingRegister.Initlize();
            container.RegisterInstance<IMapper>(Mappingconfigure.CreateMapper());

            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
