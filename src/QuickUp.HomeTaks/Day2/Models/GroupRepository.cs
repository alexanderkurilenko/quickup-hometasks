using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuickUp.HomeTaks.Day2.Models
{
    public class GroupRepository : IRepository<Group>
    {
        private readonly UniverContext _db;

        public GroupRepository(UniverContext db)
        {
            this._db = db;
        }

        public override IEnumerable<Group> GetList()
        {
            return _db.Groups;
        }

        public override Group GetById(int id)
        {
            return GroupRepository.Find(_db.Groups, id);
        }

        public override void Create(Group st)
        {
            _db.Groups.Add(st);
            _db.SaveChanges();
        }

        public override void Delete(int id)
        {
            Group group = GroupRepository.Find(_db.Groups, id);
            _db.Groups.Remove(group);
        }

        public override void Save()
        {
            _db.SaveChanges();
        }
        public override void Update(Group item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
    }
}
