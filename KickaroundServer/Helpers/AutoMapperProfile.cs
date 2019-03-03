using AutoMapper;
using KickaroundServer.Dtos.User;
using KickaroundServer.Entities;

namespace KickaroundServer.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
