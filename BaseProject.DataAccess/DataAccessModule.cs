﻿using System.Data.Entity;
using Autofac;
using BaseProject.Domain.Users;
using FlexProviders.Aspnet;
using FlexProviders.EF;
using FlexProviders.Membership;
using FlexProviders.Roles;

namespace BaseProject.DataAccess
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Common Data Access Module
            builder.RegisterModule<BaseProject.DataAccess.Common.DataAccessModule>();
            // Repositories for this module
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<RoleRepository>().As<IRoleRepository>();
            builder.RegisterType<TokenRepository>().As<ITokenRepository>();
            
            // Flex and membership stuff
            builder.RegisterType<AspnetEnvironment>().As<IApplicationEnvironment>();

            builder.RegisterType<FlexRoleStore<RoleEntity, UserEntity>>().As<IFlexRoleStore>();
            builder.RegisterType<FlexRoleProvider>().As<IFlexRoleProvider>();
            builder.RegisterType<FlexMembershipProvider<UserEntity>>().As<IFlexMembershipProvider<UserEntity>>();
            builder.RegisterType<FlexMembershipUserStore<UserEntity>>().As<IFlexUserStore<UserEntity>>();

            // The DbContext
            builder.RegisterType<UserContext>().As<DbContext>();
        }
    }
}
