using Business.Dtos.Category;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Category GetById(int id);
        Task<List<CategoryForListingDto>> GetAll();
        Task Add(CategoryForAddDto category);
        void Update(Category category);
        void Delete(int id);
    }
}