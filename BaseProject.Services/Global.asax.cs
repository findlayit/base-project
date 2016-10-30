using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using BaseProject.BusinessProviders;
using BaseProject.Common;
using BaseProject.DataAccess.Common;

namespace BaseProject.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            // autofac container
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule<ServicesModule>();
            builder.RegisterModule<DataAccessModule>();

            // Auto Mapper v5 Support
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                MappingConfiguration.Configure(typeof(ServicesModule).Assembly, cfg);
                MappingConfiguration.Configure(typeof(BusinessProviderModule).Assembly, cfg);
            });

            var mapper = mapperConfiguration.CreateMapper();
            builder.RegisterInstance(mapper).As<IMapper>();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
