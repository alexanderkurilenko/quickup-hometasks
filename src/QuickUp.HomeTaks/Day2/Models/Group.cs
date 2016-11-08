using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day2.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string Faculty{ get; set; }
        public int Number{ get; set; }
        public virtual IEnumerable<Student> Students { get; set; }
    }
}
