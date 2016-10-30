using AutoMapper;
using BaseProject.BusinessProvider.Models.Users;
using BaseProject.Domain.Users;

namespace BaseProject.BusinessProviders.Mapping
{
    public class UserMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<User, UserEntity>();
            CreateMap<UserEntity, User>();
        }
    }
}