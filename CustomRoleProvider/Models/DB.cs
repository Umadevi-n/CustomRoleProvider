using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CustomRoleProvider.Models
{
    public class DB:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }
    }
}