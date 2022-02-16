using AutoMapper;
using Furever.Entities.DataTransferObjects.Animals;
using Furever.Entities.DataTransferObjects.Categories;
using Furever.Entities.DataTransferObjects.Refuges;
using Furever.Entities.Models;

namespace Furever.Api.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map Entities (Models) to Data Transfer Object (see WebApp.Entities)


            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CategoryCreationDto, Category>();

            CreateMap<Refuge, RefugeDto>().ReverseMap();
            CreateMap<RefugeCreationDto, Refuge>();

            CreateMap<Animal, AnimalDto>()
                .ForMember(a => a.Category, options => options.MapFrom(x => x.Category.Species))
                .ForMember(a => a.Refuge, options => options.MapFrom(e => e.Refuge.Username));
            CreateMap<AnimalCreationDto, Animal>();
        }
    }
}
