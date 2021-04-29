using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace _15_EntityFramework
{
    internal class DataBaseContext : DbContext
    {
        public DbSet<UserNews> News { get; private set;}
        public DataBaseContext() : base("DbConnectionString")
        {

        }
    }
}
