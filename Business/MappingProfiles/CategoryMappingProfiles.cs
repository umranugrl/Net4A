using AutoMapper;
using Business.Dtos.Category.Request;
using Business.Dtos.Category.Responce;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MappingProfiles
{
    public class CategoryMappingProfiles : Profile
    {
        public CategoryMappingProfiles() 
        {
            CreateMap<Category, AddCategoryRequest>().ReverseMap();
            CreateMap<Category, ListCategoryResponce>().ReverseMap();
        }
    }
}