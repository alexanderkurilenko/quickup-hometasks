using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuickUp.HomeTasks.Day1.DB.code_first
{
    class GroupContext:DbContext
    {
        public GroupContext()
            : base("DbConnection")
        {

        }
        public DbSet<Group> Groups { get; set; }
    }
}
