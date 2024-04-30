using Entities;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<Product?> GetByIdAsync(int id);
    }
}