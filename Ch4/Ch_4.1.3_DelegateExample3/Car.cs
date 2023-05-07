using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._3_DelegateExample3
{
    public class Car
    {
        string name;

        public Car(string name)
        {
            this.name = name;
        }

        public void PrintCar()
        {
            Console.WriteLine("Car information:");
            Console.WriteLine("Name:"+ this.name);
        }
        public static void Power()
        {

        }
    }
}
