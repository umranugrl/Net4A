using AutoMapper;
using Business.Features.Auth.Commands.Register;
using Entities;

namespace Business.Features.Auth.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, RegisterCommand>().ReverseMap();
        }
    }
}