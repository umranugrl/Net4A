using Core.DataAccess;
using Entities;

namespace DataAccess.Abstracts
{
    public interface ICategoryRepository :IRepository<Category>, IAsyncRepository<Category>
    {

    }
}