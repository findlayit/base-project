using Autofac;
using BaseProject.Common;

namespace BaseProject.BusinessProvider.Common
{
    public class BusinessProviderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonModule>();
        }
    }
}
