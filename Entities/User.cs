﻿using Core.Entities;

namespace Entities
{
    public class User : BaseUser
    {
        public virtual List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}