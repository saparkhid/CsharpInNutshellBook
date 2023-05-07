using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._6_InterfaceAndDelegate
{
    public class UtilityD
    {
        public static void TransformAll(int[] values, MyIntIntDelegate t)
        {
            for (int i = 0; i < values.Length; i++)
                values[i] = t.Invoke(values[i]);
        }
    }
}
