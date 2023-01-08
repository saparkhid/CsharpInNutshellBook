using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_8_Inheritance
{
    public class House : Asset
    {
        public decimal Mortgage;

        public override bool Equals(object? obj)
        {
            House? h = obj as House; //down cast

            return h != null && h.Mortgage == Mortgage ;
        }
    }
}
