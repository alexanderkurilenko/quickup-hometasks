using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.DB.code_first
{
    class Group
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Faculty { get; set;}
        public virtual ICollection<Student> Students { get; set; }
        public Group()
        {
            Students = new List<Student>();
        }
    }
}
