using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuickUp.HomeTasks.Day1.DB.code_first
{
    class GroupRepository:IRepository<Group>
    {
        private GroupContext db;
        public GroupRepository()
        {
            this.db = new GroupContext();
        }

            public IEnumerable<Group> GetItemList()
            {
                return db.Groups;
            }

            public Group GetItem(int id)
            {
                return db.Groups.Find(id);
            }

            public void Create(Group group)
            {
                db.Groups.Add(group);
                db.SaveChanges();
            }

            public void Update(Group group)
            {
                db.Entry(group).State = EntityState.Modified;
            }

            public void Delete(int id)
            {
                Group student = db.Groups.Find(id);
                if (student != null)
                    db.Groups.Remove(student);
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
