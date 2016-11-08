using Microsoft.AspNetCore.Mvc;
using QuickUp.HomeTaks.Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day2.Controllers
{
    [Route("students")]
    public class StudentController:Controller
    {

        private readonly StudentRepository _studentRepository;

        public StudentController(StudentRepository characterRepository)
        {
            _studentRepository = characterRepository;
        }

        [HttpGet("/students/list")]
        public IEnumerable<Student> ListStudents()
        {
            var students = _studentRepository.GetList();
            return students;
        }

        [HttpGet("/students/list/byName")]
        public IEnumerable<Student> ListStudentsByNmae()
        {
            var students = _studentRepository.GetList();
            students.OrderBy(pet => pet.FirstMidName);
            return students;
        }

        [HttpPost("/students")]
        public string CreateStudent(Student student)
        {
            _studentRepository.Create(student);
            return "Данные внесены";
        }

        [HttpGet("/students/{id}")]
        public Student ReadStudent(int id)
        {
            return _studentRepository.GetById(id);
        }

        [HttpDelete("/students/delete/{id}")]
        public string DeleteStudentById(int id)
        {
            _studentRepository.Delete(id);
            return "Данные удалены";
        }

        [HttpPut("/students/update/{id}")]
        public void Update(int id)
        {
            var student = _studentRepository.GetById(id);
            _studentRepository.Update(student);
        }

    }
}
