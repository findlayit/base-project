using Autofac;
using BaseProject.Common;

namespace BaseProject.DataAccess.Common
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CommonModule>();
        }

    }
}
