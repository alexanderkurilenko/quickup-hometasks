using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.L
{
    class Mobile_Phone:ICall
    {
        private Boolean _isCharged;
        Mobile_Phone(bool charge)
        {
            _isCharged = charge;
        }
        public void call()
        {
            if (!_isCharged)
            {
                return;
            }
        }
        public bool IsCharged
        {
            get { return this._isCharged; }
            set { this._isCharged = value; }
        }
    }
}
