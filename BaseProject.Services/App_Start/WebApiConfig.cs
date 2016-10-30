using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BaseProject.Services
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var corsDomains = WebConfigurationManager.AppSettings["CorsDomains"];
            //var cors = new EnableCorsAttribute(corsDomains, "*", "*","Content-Type");
            //cors.SupportsCredentials = true;
            //config.EnableCors(cors);

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
