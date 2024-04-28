using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Category;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Add(CategoryForAddDto dto)
        {
            //Manual mapping
            //Category category = new();
            //category.CategoryName = dto.CategoryName;
            //category.CreatedDate = DateTime.Now;

            //Auto mapping
            Category category = _mapper.Map<Category>(dto);

            await _categoryRepository.AddAsync(category);
        }

        public void Delete(int id)
        {
            Category? categoryToDelete = _categoryRepository.Get(i => i.Id == id);
            throw new NotImplementedException();
        }

        public async Task<List<CategoryForListingDto>> GetAll()
        {
            List<Category> categories = await _categoryRepository.GetListAsync();

            List<CategoryForListingDto> response = categories.Select(c => new CategoryForListingDto()
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
            }).ToList();

            return response;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

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