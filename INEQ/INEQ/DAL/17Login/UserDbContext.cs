using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using INEQ.Models._17Login;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace INEQ.DAL._17Login
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base ("UserDbContext")
        {

        }

        public DbSet<UserAccount> userAccount { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}