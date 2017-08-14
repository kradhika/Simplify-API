using System.Web.Http;
using Microsoft.Web.Http.Routing;
using System.Web.Http.Routing;
using DH.Simplify.API.Infrastructure.Filters;

namespace DH.Simplify.API
{
    /// <summary>
    /// Handles WebAPI routing
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Initializes WebAPI routing
        /// </summary>
        /// <param name="config">HttpConfiguration object</param>
        public static void Register(HttpConfiguration config)
        {
            config.AddApiVersioning();

            var constraintResolver = new DefaultInlineConstraintResolver()
            {
                ConstraintMap =
                {
                    ["apiVersion"] = typeof( ApiVersionRouteConstraint )
                }
            };
            config.MapHttpAttributeRoutes(constraintResolver);

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;            
            config.Filters.Add(new ValidationActionFilter());
            config.Filters.Add(new HandleApiExceptionFilter());

            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );

            // To disable tracing, please comment out or remove the following line of code
            config.EnableSystemDiagnosticsTracing();
        }
    }
}
