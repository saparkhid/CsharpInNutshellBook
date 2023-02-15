using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_22.GenericMethods
{
    internal class Block<T1,T2>  
    {
        ///--------------
        ///-     -      -
        ///--------------
        public T1 Part1 { get; set; }
        public T2 Part2 { get; set; }

        public override string ToString()
        {
            return Part1.ToString() + " | " + Part2.ToString();
        }
    }
}
