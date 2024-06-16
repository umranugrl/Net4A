using Core.DataAccess;
using Entities;
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