using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._6_InterfaceAndDelegate
{
    public class SquareTransformer : ITransformer
    {
        public int Transform(int x)
        {
            return x * x;
        }
    }
}
