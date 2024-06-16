using Core.Entities;

namespace Entities
{
    public class OperationClaim : Core.Entities.OperationClaim
    {
        public virtual List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
