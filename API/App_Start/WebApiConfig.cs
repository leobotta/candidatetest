using Autofac;
using Autofac.Integration.WebApi;
using Entities.Abstractions;
using Entities.AppService;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //var builder = new ContainerBuilder();

            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterModule(new AutofacModule()); // same as with ASP.NET MVC Controllers

            //var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }

    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder bd)
        {
            base.Load(bd);

            bd.RegisterType<DeveloperRepository>().As<IDeveloperRepository>().InstancePerLifetimeScope();

            bd.RegisterType<DeveloperService>().As<IDeveloperService>().InstancePerLifetimeScope();
        }
    }
}
