using Core.DataAccess;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryRepository : EfRepositoryBase<Category, BaseDbContext>, ICategoryRepository
    {
        public EfCategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}