using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._3_DelegateExample3
{
    public class Light
    {
        int watt;
        public Light(int watt)
        {
            this.watt = watt;
        }
        public void Print()
        {
            Console.WriteLine("Light power:"+watt);
        }
    }
}
