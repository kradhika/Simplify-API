using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using DH.Simplify.Infrastructure.DI;

namespace DH.Simplify.API
{
    /// <summary>
    /// WebApiApplication
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Application_Start event
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Autofac
            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            DependenciesInstaller.RegisterTypes(builder);
            
            // Get your HttpConfiguration
            var config = GlobalConfiguration.Configuration;

            // Set the dependency resolver to be Autofac
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
