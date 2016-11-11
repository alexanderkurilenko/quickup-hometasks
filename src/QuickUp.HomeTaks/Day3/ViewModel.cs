using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3
{
    public  class ViewModel<T>
    {
       public IEnumerable<T> Result { get; set; }
       public DateTime Time { get; set; }
       
        public override string ToString()
        {
            return "{\nServer time" + Time.ToString() + "\n" + "Result" + Result.ToString();
        }
    }
}
