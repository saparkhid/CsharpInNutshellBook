using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_16.ToStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D("V1");
            v1.X = 3;
            v1.Y = -5;
            Vector2D v2 = new Vector2D("V2");
            v2.X = 4;
            v2.Y = 8;
            double dot = v1.Dot(v2);
           

            Console.WriteLine(dot);
            Console.ReadKey();
        }
    }
}
