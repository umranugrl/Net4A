using Core.DataAccess;
using Entities;
using DataAccess.Abstracts;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
    {
        public EfUserOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }
}