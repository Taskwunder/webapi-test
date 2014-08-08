using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbClasses.Model;

namespace DbClasses
{
    public class TestContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<WorkTask> Tasks { get; set; }
    }
}
