﻿using AutoMapper;
using BaseProject.BusinessProvider.Models.Users;
using BaseProject.Domain.Users;

namespace BaseProject.BusinessProviders.Mapping
{
    public class RoleMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Role, RoleEntity>();
            CreateMap<RoleEntity, Role>();
        }
    }
}