using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuickUp.HomeTasks.Day1.DB.code_first
{
    class StudentContext:DbContext
    {
        public StudentContext(): base("DbConnection")
        {

        }
        public DbSet<Student> Students { get; set; } 
    }
}
