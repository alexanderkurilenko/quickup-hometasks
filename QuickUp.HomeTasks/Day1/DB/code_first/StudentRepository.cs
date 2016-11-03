using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuickUp.HomeTasks.Day1.DB.code_first
{
    class StudentRepository : IRepository<Student>
    {
        
            private StudentContext db;

            public StudentRepository()
            {
                this.db = new StudentContext();
            }

            public IEnumerable<Student> GetItemList()
            {
                return db.Students;
            }

            public Student GetItem(int id)
            {
                return db.Students.Find(id);
            }

            public void Create(Student student)
            {
                db.Students.Add(student);
                //db.SaveChanges();
            }

            public void Update(Student student)
            {
                db.Entry(student).State = EntityState.Modified;
            }

            public void Delete(int id)
            {
                Student student = db.Students.Find(id);
                if (student != null)
                    db.Students.Remove(student);
            }

            public void Save()
            {
                db.SaveChanges();
            }

            private bool disposed = false;

            public virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
}