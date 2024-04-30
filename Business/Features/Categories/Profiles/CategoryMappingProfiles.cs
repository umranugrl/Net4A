using AutoMapper;
using Business.Features.Categories.Commands.Create;
using Business.Features.Categories.Commands.Update;
using Business.Features.Categories.Queries.GetById;
using Business.Features.Categories.Queries.GetList;
using Entities;

namespace Business.Features.Categories.Profiles
{
    public class CategoryMappingProfiles : Profile
    {
        public CategoryMappingProfiles()
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetAllCategoryResponse>().ReverseMap();
            CreateMap<Category, GetByIdCategoryResponse>().ReverseMap();
            CreateMap<Category, UpdateCategoryResponse>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryResponse>().ReverseMap();
        }
    }
}