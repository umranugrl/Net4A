using Core.DataAccess;
using Entities;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimRepository : IRepository<UserOperationClaim>, IAsyncRepository<UserOperationClaim>
    {
    }
}