using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCWebApp_Entities.SystemEntities;

namespace MVCWebApp_Entities
{
    public class MVCWebAppDBContext : DbContext
    {
        public DbSet<SystemRole> SystemRole { get; set; }
        public DbSet<SystemURL> SystemURL { get; set; }
        public DbSet<SystemURLFunction> SystemURLFunction { get; set; }
        public DbSet<SystemURLMenu> SystemURLMenu { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
        public DbSet<SystemUserRole> SystemUserRole { get; set; }
    }
}