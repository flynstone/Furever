using AutoMapper;
using Furever.Entities.DataTransferObjects.Animals;
using Furever.Entities.Models;

namespace Furever.Api.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map Entities (Models) to Data Transfer Object (see WebApp.Entities)
            CreateMap<Animal, AnimalDto>().ReverseMap();
            CreateMap<AnimalCreationDto, Animal>();
        }
    }
}
