using Autofac;
using BaseProject.BusinessProviders;
using BaseProject.DataAccess.Common;
using BaseProject.Services.Common;

namespace BaseProject.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<BusinessProviderModule>();
            builder.RegisterModule<ServiceCommonModule>();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerRequest();
        }
    }
}