using Autofac;
using BaseProject.Common;

namespace BaseProject.Services.Common
{
    public class ServiceCommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonModule>();
        }
    }
}