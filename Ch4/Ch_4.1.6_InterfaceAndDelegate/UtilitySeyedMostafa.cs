using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._6_InterfaceAndDelegate
{
    public class UtilitySeyedMostafa
    {
        public static void TransformAll(int[] values, ITransformerSeyedMostafa t,bool cube=false)
        {
            if (cube)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = t.TransformCuber(values[i]);
            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = t.TransformSquare(values[i]);
            }
        }
    }
}
