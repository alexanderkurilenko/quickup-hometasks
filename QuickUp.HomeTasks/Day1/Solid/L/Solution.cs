using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.L
{
    class Solution
    {
        public void MakeCall(ICall phone)
        {
            if (phone is Mobile_Phone)
                ((Mobile_Phone)phone).IsCharged = true;
            phone.call();
        }
    }
}
