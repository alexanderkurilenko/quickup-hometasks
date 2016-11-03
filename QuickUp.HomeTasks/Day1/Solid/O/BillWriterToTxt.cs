using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickUp.HomeTasks.Day1.Solid.S;
using System.IO;

namespace QuickUp.HomeTasks.Day1.Solid.O
{
    class BillWriterToTxt
    {
        public void Write(BillRepository rep)
        {
            foreach (Purchase it in rep.Container)
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
