using Core.DataAccess;
using Entities;

namespace DataAccess.Abstracts
{
    //Ürün veri deposunun interface hali
    public interface IProductRepository : IRepository<Product>, IAsyncRepository<Product>
    {

    }
}