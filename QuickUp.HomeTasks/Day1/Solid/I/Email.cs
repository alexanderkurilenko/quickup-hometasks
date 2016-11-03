using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.I
{
    class Email:IEmailMessage
    {
        public IList<String> BccAddresses { get; set; }
        public string Subject { get; set; }
        public bool Send(IList<String> toAddresses, string messageBody)
        {
            return true;
        }
    }
}
