using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstracts;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfOperationClaimRepository : EfRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
    {
        public EfOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }
}