using Business.Abstracts;
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
        List<Category> categories;

        public CategoryManager()
        {
            this.categories = new List<Category>();
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return this.categories;
        }

        public void Delete(int id)
        {
            Category category = categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                categories.Remove(category);
            }
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Update(Category updatedCategory)
        {
            Category category = categories.FirstOrDefault(c => c.CategoryId == updatedCategory.CategoryId);
            if (category != null)
            {
                category.CategoryName = updatedCategory.CategoryName;
            }
        }

    }
}