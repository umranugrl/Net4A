﻿using Core.DataAccess;
using Entities;

namespace DataAccess.Abstracts
{
    public interface IOperationClaimRepository : IRepository<OperationClaim>, IAsyncRepository<OperationClaim>
    {
    }
}