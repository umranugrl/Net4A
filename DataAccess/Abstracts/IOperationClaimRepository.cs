using Core.DataAccess;
using Core.Entities;

namespace DataAccess.Abstracts
{
    public interface IOperationClaimRepository : IRepository<OperationClaim>, IAsyncRepository<OperationClaim>
    {
    }
}