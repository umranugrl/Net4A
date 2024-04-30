using Core.DataAccess;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserRepository : EfRepositoryBase<User, BaseDbContext>, IUserRepository
    {
        public EfUserRepository(BaseDbContext context) : base(context)
        {
        }
    }
}