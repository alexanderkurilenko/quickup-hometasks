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
            using (StudentContext db = new StudentContext())
            {
                // создаем два объекта User
                Student user1 = new Student { Name = "Tom", Age = 33 };
                Student user2 = new Student { Name = "Sam", Age = 26 };

                // добавляем их в бд
                db.Students.Add(user1);
                db.Students.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Students;
                Console.WriteLine("Список объектов:");
                foreach (Student u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
            Console.Read();
        }
    }
}
