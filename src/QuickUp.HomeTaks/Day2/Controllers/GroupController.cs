using Microsoft.AspNetCore.Mvc;
using QuickUp.HomeTaks.Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day2.Controllers
{
    [Route("groups")]
    public class GroupController : Controller
    {

        private readonly GroupRepository _groupRepository;

        public GroupController(GroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        [HttpGet("/groups/list")]
        public IEnumerable<Group> ListGroup()
        {
            var students = _groupRepository.GetList();
            return students;
        }

        [HttpGet("/groups/list/byFaculty")]
        public IEnumerable<Group> ListGroupsByFaculty()
        {
            var groups = _groupRepository.GetList();
            groups.OrderBy(gr => gr.Faculty);
            return groups;
        }

        [HttpPost("/groups")]
        public string CreateGroup(Group group)
        {
            _groupRepository.Create(group);
            return "Данные внесены";
        }

        [HttpGet("/groups/{id}")]
        public Group ReadGroup(int id)
        {
            return _groupRepository.GetById(id);
        }

        [HttpDelete("/groups/delete/{id}")]
        public string DeleteGroupById(int id)
        {
            _groupRepository.Delete(id);
            return "Данные удалены";
        }

        [HttpPut("/groups/update/{id}")]
        public void Update(int id)
        {
            var student = _groupRepository.GetById(id);
            _groupRepository.Update(student);
        }

    }
}
