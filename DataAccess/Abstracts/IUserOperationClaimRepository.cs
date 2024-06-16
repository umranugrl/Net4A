using Core.DataAccess;
using Core.Entities;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimRepository : IRepository<UserOperationClaim>, IAsyncRepository<UserOperationClaim>
    {
    }
}