using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuickUp.HomeTasks.Day1.Solid.S
{
    class BillViewer
    {
        BillRepository bills = new BillRepository();
        public void Print()
        {
            foreach (Purchase it in bills.Container)
            {
                foreach (Item item in it.Get_Purchase)
                {
                    Console.Write(item.Name,item.Price,item.Code);
                }
            }
        }
        public void PrintToTxt()
        {
            foreach (Purchase it in bills.Container)
            {
                foreach (Item item in it.Get_Purchase)
                {
                    using (StreamWriter writetext = new StreamWriter("Bills.txt"))
                    {
                        writetext.WriteLine(item.Name, item.Price, item.Code);
                    }
                }
            }
        }
    }
}
