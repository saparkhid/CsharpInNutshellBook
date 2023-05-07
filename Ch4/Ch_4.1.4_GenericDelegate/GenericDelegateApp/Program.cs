using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateApp
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Calculate(10, program.Square);
            program.Calculate(10, program.Cube);

            program.Calculate(10.5f, program.Cube);
            Console.ReadKey();
        }

        public int Square(int  x) => x * x;
        public int Cube(int x) =>   x * x * x;
        public float Square(float x) => x * x;
        public float Cube(float x) => x * x * x;
        public void Calculate(int y,Transformer<int> transformer)
        {
            int result=transformer.Invoke(y);
            Console.WriteLine(result);
        }
        public void Calculate(float y, Transformer<float> transformer)
        {
            float result = transformer.Invoke(y);
            Console.WriteLine(result);
        }
    }
}
