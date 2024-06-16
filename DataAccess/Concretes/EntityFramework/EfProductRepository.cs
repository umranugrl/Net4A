using Core.DataAccess;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfProductRepository : EfRepositoryBase<Product, BaseDbContext>, IProductRepository
    {
        public EfProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}