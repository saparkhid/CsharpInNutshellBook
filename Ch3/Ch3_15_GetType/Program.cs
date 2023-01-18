using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_15_GetType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Type of x at runtime:");
            Console.WriteLine(x.GetType().ToString());

            Console.WriteLine(x.GetType()== typeof(int));
            Console.ReadKey();
        }
    }
}
