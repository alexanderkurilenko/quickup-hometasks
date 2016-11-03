using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.I
{
    interface IEmailMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }
}
