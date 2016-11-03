using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.S
{
    class Item
    {
        private string _name;
        private uint _price;
        private int _code;
        public Item(string name, uint price, int code)
        {
            this._name = name;
            this._price = price;
            this._code = code;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public uint Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public int Code
        {
            get { return this._code; }
        }
    }
}
