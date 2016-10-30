using AutoMapper;
using BaseProject.BusinessProvider.Models.Users;

namespace BaseProject.BusinessProviders.Mapping
{
    public class RegistrationRequestMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<RegistrationRequest, BaseProject.Domain.Users.RegistrationRequest>();
            CreateMap<BaseProject.Domain.Users.RegistrationRequest, RegistrationRequest>();
        }
    }
}