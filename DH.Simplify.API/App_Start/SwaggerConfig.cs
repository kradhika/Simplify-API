using System.Web.Http;
using WebActivatorEx;
using DH.Simplify.API;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace DH.Simplify.API
{
    /// <summary>
    /// Swagger Configuration
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Register Method
        /// </summary>
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        // Use "SingleApiVersion" to describe a single version API. Swagger 2.0 includes an "Info" object to
                        // hold additional metadata for an API. Version and title are required but you can also provide
                        // additional fields by chaining methods off SingleApiVersion.                        
                        c.SingleApiVersion("v1", "DH.Simplify.API");

                        // If you annotate Controllers and API Types with
                        // Xml comments (http://msdn.microsoft.com/en-us/library/b2s063f7(v=vs.110).aspx), you can incorporate
                        // those comments into the generated docs and UI. You can enable this by providing the path to one or
                        // more Xml comment files.
                        var docFile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "bin\\SimplifyApiDoc.xml");
                        c.IncludeXmlComments(docFile);

                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}
