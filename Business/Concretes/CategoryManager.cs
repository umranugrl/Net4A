using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(int id)
        {
            Category? categoryToDelete = _categoryRepository.Get(i => i.Id == id);
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        //public void Delete(int id)
        //{
        //    Category category = categories.FirstOrDefault(c => c.Id == id);
        //    if (category != null)
        //    {
        //        categories.Remove(category);
        //    }
        //}

        //public Category GetById(int id)
        //{
        //    return categories.FirstOrDefault(c => c.Id == id);
        //}

        //public void Update(Category updatedCategory)
        //{
        //    Category category = categories.FirstOrDefault(c => c.Id == updatedCategory.Id);
        //    if (category != null)
        //    {
        //        category.CategoryName = updatedCategory.CategoryName;
        //    }
        //}
    }
}