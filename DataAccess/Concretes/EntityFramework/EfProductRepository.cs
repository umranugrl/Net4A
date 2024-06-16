using Core.DataAccess;
using DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;
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