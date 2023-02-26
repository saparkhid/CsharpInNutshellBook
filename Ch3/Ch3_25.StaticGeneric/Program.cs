using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_25.StaticGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Panda p1 = new Panda();
            Panda p2 = new Panda();

            Panda.CountryName = "Iran";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            */
            Parrot<int> parrot1 = new Parrot<int>();
            Parrot<int> parrot2 = new Parrot<int>();

            Parrot<int>.dispersalCount = 2;


            Parrot<string> parrotStr1 = new Parrot<string>();
            Parrot<string> parrotStr2 = new Parrot<string>();
            Parrot<string> parrotStr3 = new Parrot<string>();

            Parrot<string>.dispersalCount = 6;

            parrot1.Birth();
            parrotStr1.Kill();

            Console.WriteLine(parrot1.ToString());
            Console.WriteLine(parrotStr1.ToString());


            Console.ReadKey();
        }
    }
}
