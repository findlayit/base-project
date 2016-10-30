using AutoMapper;
using BaseProject.BusinessProvider.Models.Users;

namespace BaseProject.BusinessProviders.Mapping
{
    public class LoginResultMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<LoginResult, BaseProject.Domain.Users.LoginResult>();
            CreateMap<BaseProject.Domain.Users.LoginResult, LoginResult>();
        }

    }
}