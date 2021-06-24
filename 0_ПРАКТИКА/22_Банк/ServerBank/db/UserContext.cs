using ServerBank.db.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ServerBank.db
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base("DbConnection")
        {
        }
    }
}
