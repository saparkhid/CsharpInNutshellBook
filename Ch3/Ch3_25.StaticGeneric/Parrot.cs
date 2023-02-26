using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_25.StaticGeneric
{
    public class Parrot <T>
    {
        public static int dispersalCount;

        public T FlyTo(string destination)
        {
            return default(T);
        }

        public override string ToString()
        {
            return dispersalCount.ToString();
        }

        public void Birth()
        {
            dispersalCount++;

        }
        public void Kill()
        {
            dispersalCount--;
        }
    }
}
