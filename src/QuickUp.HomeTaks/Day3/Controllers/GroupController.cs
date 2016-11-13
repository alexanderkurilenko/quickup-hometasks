
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using QuickUp.HomeTaks.Day2.Models;
using QuickUp.HomeTaks.Day3;
using QuickUp.HomeTaks.Day3.Filters;
using QuickUp.HomeTaks.Day3.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Controllers
{
    //[WrappFilter(_groupModel.ToString())]
    [Route("api/groups")]
    public class GroupController : Controller
    {
        private ILoggerFactory _loggerfactory;
        private readonly GroupRepository _groupRepository;
          
        public GroupController(GroupRepository groupRepository,ILoggerFactory loggerfactory)
        {
            _groupRepository = groupRepository;
            _loggerfactory = loggerfactory;
            _loggerfactory.AddFile(Configuration.Path());
            
        }
        [HttpGet("/groups")]
      
        public IEnumerable<Group> ListGroup()
        {
            var logger = _loggerfactory.CreateLogger("ListLogger");
            var students = _groupRepository.GetList();
            logger.LogInformation("all students were  shown", _groupRepository.GetList());
            return students;
        }

        [HttpGet("/groups/byFaculty")]
        public IEnumerable<Group> ListGroupsByFaculty()
        {
            var groups = _groupRepository.GetList();
            groups.OrderBy(gr => gr.Faculty);
            return groups;
        }

        [HttpPost("/groups")]
        public Group CreateGroup(Group group)
        {
            _groupRepository.Create(group);
            return group;
        }

        [HttpGet("/groups/{id}")]
        public Group ReadGroup(int id)
        {
            return _groupRepository.GetById(id);
        }

        [HttpDelete("/groups/{id}")]
        public IActionResult DeleteGroupById(int id)
        {
            _groupRepository.Delete(id);
            return Ok();
        }

        [HttpPut("/groups/{id}")]
        public void Update(int id)
        {
            var student = _groupRepository.GetById(id);
            _groupRepository.Update(student);
        }

    }
}
