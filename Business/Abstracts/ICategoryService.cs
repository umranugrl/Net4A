using Entities;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<Category?> GetByIdAsync(int id);
    }
}