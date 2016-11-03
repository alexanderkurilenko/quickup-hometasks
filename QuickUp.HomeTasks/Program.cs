using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickUp.HomeTasks.Day1.DB.code_first;

namespace QuickUp.HomeTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            Group gr = new Group { Faculty = "FKSIS", Number = 4 };
            Student st1 = new Student { Name = "Tom", Age = 33,Group=gr};
            Student st2 = new Student { Name = "Sasha", Age = 28 };
             
            StudentRepository db = new StudentRepository();
            GroupRepository g = new GroupRepository();
               
            db.Create(st1);
            db.Create(st2);
            db.Save();
            g.Save();
            Console.WriteLine("Объекты успешно сохранены");

            IEnumerable<Student> c = db.GetItemList();
            foreach (Student s in c)
            {
                Console.Write(s.Name);
            }
              
            
            Console.Read();
        }
    }
}
