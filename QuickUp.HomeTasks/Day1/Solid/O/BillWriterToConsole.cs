using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickUp.HomeTasks.Day1.Solid.S;

namespace QuickUp.HomeTasks.Day1.Solid.O
{
    class BillWriterToConsole
    {
        public void Write(BillRepository rep)
        {
            foreach (Purchase it in rep.Container)
            {
                foreach (Item item in it.Get_Purchase)
                {
                    Console.Write(item.Name, item.Price, item.Code);
                }
            }
        }
    }
}
