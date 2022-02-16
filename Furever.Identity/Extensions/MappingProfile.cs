using AutoMapper;
using Furever.Identity.Models;
using Furever.Identity.Models.ViewModels;

namespace Furever.Identity.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
