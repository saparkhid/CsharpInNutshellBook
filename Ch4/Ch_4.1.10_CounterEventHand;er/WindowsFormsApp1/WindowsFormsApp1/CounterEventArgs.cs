using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CounterEventArgs : EventArgs
    {
        public int Number;
 
        public CounterEventArgs(int number)
        {
            Number = number;
          
          
        }
    }
}
