using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverloadingResolution
{
    public class AutoPrinter
    {
        public AutoPrinter()
        {

        }
        public void Print(Car c)
        {
            Console.WriteLine("Car:" + c.Name);
        }
        public void Print(Vehicle v)
        {
            Console.WriteLine("Vehicle:" + v.Name);
        }
    }
}
