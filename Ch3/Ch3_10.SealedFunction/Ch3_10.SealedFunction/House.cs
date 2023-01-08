using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_10.SealedFunction
{
    public class House : Asset
    {
        public decimal Mortgage;
        public sealed override decimal Liability => Mortgage;
    }
}
