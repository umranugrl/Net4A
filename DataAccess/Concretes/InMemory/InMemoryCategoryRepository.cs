using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
        List<Category> categories;

        public InMemoryCategoryRepository()
        {
            categories = new List<Category>();
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            Category? category = categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}