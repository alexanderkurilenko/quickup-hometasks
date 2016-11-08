using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day2.Models
{
    public class StudentRepository:IRepository<Student>
    {
        private readonly UniverContext _db;


        public StudentRepository(UniverContext db)
        {
            this._db = db;
        }

        public override IEnumerable<Student> GetList()
        {
            return _db.Students;
        }

        public override Student GetById(int id)
        {
            return StudentRepository.Find(_db.Students, id);
        }

        public override void Create(Student st)
        {
            _db.Students.Add(st);
            _db.SaveChanges();
        }

        public override void Delete(int id)
        {
            Student student = StudentRepository.Find(_db.Students, id);
            _db.Students.Remove(student);
        }
        public override void Save()
        {
            _db.SaveChanges();
        }
        public override void Update(Student item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
       
    }
}
