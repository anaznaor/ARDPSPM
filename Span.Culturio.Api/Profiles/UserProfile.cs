using AutoMapper;
using Span.Culturio.Api.Data.Entities;
using Span.Culturio.Api.Models;

namespace Span.FairBank.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>();
                //.ForMember(dest => dest.Id, src => src.Ignore());
            CreateMap<User, UserDto>();
        }
    }
}