using INEQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace INEQ.DAL._8ComponentType
{
    public class ComponentTypeDbContext : DbContext
    {
        public ComponentTypeDbContext() : base("ComponentTypeContext")
        {

        }

        public DbSet<ComponentType> componentType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    }
}