using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuickUp.HomeTaks.Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickUp.HomeTaks.Day3.Logger;

namespace QuickUp.HomeTaks.Day3.Controllers
{
    [Route("api/students")]
    public class StudentController:Controller
    {

        private readonly StudentRepository _studentRepository;
        private ILoggerFactory _loggerfactory;

        public StudentController(StudentRepository characterRepository,ILoggerFactory loggerfactory)
        {
            _studentRepository = characterRepository;
            _loggerfactory = loggerfactory;
            _loggerfactory.AddFile(Configuration.Path());
        }

        [HttpGet("/students")]
        public IEnumerable<Student> ListStudents()
        {
            var logger = _loggerfactory.CreateLogger("FileLogger");
            logger.LogInformation("Processing request {2}","Students added");
            var students = _studentRepository.GetList();
            return students;
        }

        [HttpGet("/students/byName")]
        public IEnumerable<Student> ListStudentsByNmae()
        {
            var students = _studentRepository.GetList();
            students.OrderBy(pet => pet.FirstMidName);
            return students;
        }

        [HttpPost("/students")]
        public Student CreateStudent(Student student)
        {
            _studentRepository.Create(student);
            return student;
        }

        [HttpGet("/students/{id}")]
        public Student ReadStudent(int id)
        {
            return _studentRepository.GetById(id);
        }

        [HttpDelete("/students/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _studentRepository.Delete(id);
            return Ok();
        }

        [HttpPut("/students/{id}")]
        public void Update(int id)
        {
            var student = _studentRepository.GetById(id);
            _studentRepository.Update(student);
        }

    }
}
