using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.S
{
    class Purchase
    {
        private DateTime _date;
        private const double DISCOUNT = 0.03;
        private List<Item> _purchase;
        private int _number;
        private int _totalsum;
        public Purchase(int number,DateTime date)
        {
            _purchase = new List<Item>();
            _number = number;
            _date = date;
        }
        public void Add(Item item)
        {
            _purchase.Add(item);
        }
        public void Remove(Item item)
        {
            _purchase.Remove(item);
        }
        public int Get_count()
        {
            return _purchase.Count;
        }
        public double Total_sum()
        {
            uint summ = 0;
            foreach (Item it in _purchase)
            {
                summ += it.Price;
            }
            return (summ*(1-DISCOUNT));
        }
        public IEnumerable<Item> Get_Purchase
        {
            get { return this._purchase; }
        }
        public int Number
        {
            get { return this._number; }
        }
        public DateTime Date{
            get { return this._date; }
        }
    }
}
