﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserRole
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }

    }
}
