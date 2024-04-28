using Business.Dtos.Category.Request;
using Business.Dtos.Category.Responce;
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
        Task<List<ListCategoryResponce>> GetAll();
        Task Add(AddCategoryRequest category);
        void Update(Category category);
        void Delete(int id);
    }
}