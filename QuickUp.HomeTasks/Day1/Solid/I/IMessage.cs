using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.I
{
    interface IMessage
    {
        bool Send(IList<String> toAddresses, string messageBody);
    }
}
