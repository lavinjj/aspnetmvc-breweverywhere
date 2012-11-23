using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using BrewEverywhere.Interfaces.Logging;
using BrewEverywhere.Services.Logging;
using System.Reflection;
using Autofac.Integration.Mvc;
using BrewEverywhere.Interfaces.Data;
using BrewEverywhere.Data;
using Autofac.Integration.WebApi;

namespace BrewEverywhere
{
    public class IOCConfig
    {
        public static void RegisterIOCContainers()
        {
            // autofac configuration
            var builder = new ContainerBuilder();
            // register controllers with IoC Container
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // register service implementations with IoC Container
            builder.RegisterType<Log4NetLoggerService>().As<ILoggerService>();
            builder.RegisterType<BrewEverywhereRepository>().As<IBrewEverywhereRepository>();
            // put controller services here
            // convert Container Builder to an IContainer instance
            IContainer container = builder.Build();
            // Set the dependency resolver for Web API.
            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

            // Set the dependency resolver for MVC.
            var mvcResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(mvcResolver);
        }
    }
}