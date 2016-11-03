using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUp.HomeTasks.Day1.Solid.D
{
    class Tech
    {
        private int _screen_width;
        private int _scree_heidht;
        private int _ppi;
        Tech(int width, int height, int ppi)
        {
            this._screen_width = width;
            this._ppi = ppi;
            this._scree_heidht = height;
        }
    }
}
