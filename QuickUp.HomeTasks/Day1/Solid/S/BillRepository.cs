using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.S
{
    class BillRepository
    {
        private List<Purchase> _bills = new List<Purchase>();
        public IEnumerable<Purchase> Load(DateTime date)
        {
            return _bills.FindAll(delegate(Purchase id)
            {
                return id.Date == date;
            });
        }
        public void Delete(Purchase purchase)
        {
            _bills.Remove(purchase);
        }
        public void Save(Purchase purchase)
        {
            _bills.Add(purchase);
        }
        public IEnumerable<Purchase> Container
        {
            get { return this._bills; }
        }
    }
}
