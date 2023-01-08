using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_10.SealedFunction
{
    public class Asset
    {
        public string Name;
        public virtual decimal Liability => 0; 
    }
}
