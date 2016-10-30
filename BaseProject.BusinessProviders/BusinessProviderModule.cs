using Autofac;
using BaseProject.BusinessProvider.Common;
using BaseProject.DataAccess;

namespace BaseProject.BusinessProviders
{
    public class BusinessProviderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DataAccessModule>();
            builder.RegisterModule<BusinessProvider.Common.BusinessProviderModule>();

            builder.RegisterType<UserManager>().As<IUserManager>();
            //builder.Register(c => new UserManager(c.Resolve<IUserRepository>(), c.Resolve<ITokenRepository>(), c.Resolve<IRoleRepository>())).As(typeof(IUserManager));
        }

    }
}
