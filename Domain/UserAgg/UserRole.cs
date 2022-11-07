﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Domain.UserAgg
{
    public class UserRole : BaseEntity
    {
        private UserRole()
        {

        }
        public UserRole(Guid roleId)
        {
            RoleId = roleId;
        }

        public Guid UserId { get; internal set; }
        public Guid RoleId { get; private set; }
    }
}
