using Aureum.Pass.DTOs;
using Aureum.Pass.Models;
using AutoMapper;

namespace Aureum.Pass.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<CreateUserDTO, AuthUser>();
            CreateMap<PutAuthDTO, AuthUser>();
            CreateMap<AuthUser, ReadAuthDTO>();
        }
    }
}
