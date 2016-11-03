using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.D
{
    class Mobile_phone
    {
        private string _model;
        private Tech _description;
        Mobile_phone(Tech desc,string model)
        {
            this._description = desc;
            this._model = model;
        }
    }
}
