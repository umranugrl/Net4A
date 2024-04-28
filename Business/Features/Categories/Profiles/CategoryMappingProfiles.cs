using AutoMapper;
using Business.Features.Categories.Commands.Create;
using Entities;

namespace Business.Features.Categories.Profiles
{
    public class CategoryMappingProfiles : Profile
    {
        public CategoryMappingProfiles()
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }
    }
}