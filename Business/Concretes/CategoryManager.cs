using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            Category? category = await _categoryRepository.GetAsync(i => i.Id == id);
            return category;
        }
    }
}