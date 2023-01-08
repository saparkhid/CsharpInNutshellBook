using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_10.SealedFunction
{
    public class Stock : Asset
    {
        public long SharesOwned;
        public override decimal Liability => base.Liability;

    }
}
