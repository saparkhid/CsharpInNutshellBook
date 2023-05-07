using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._6_InterfaceAndDelegate
{
    internal class TransformerSeyedMostafa : ITransformerSeyedMostafa
    {
        public int TransformCuber(int x)
        {
            return x * x * x;
        }

        public int TransformSquare(int x)
        {
            return x * x;
        }
    }
}
