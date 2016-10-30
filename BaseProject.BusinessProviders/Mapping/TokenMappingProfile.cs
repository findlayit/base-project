using AutoMapper;
using BaseProject.BusinessProvider.Models.Users;
using BaseProject.Domain.Users;

namespace BaseProject.BusinessProviders.Mapping
{
    public class TokenMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Token, TokenEntity>();
            CreateMap<TokenEntity, Token>();
        }
    }
}