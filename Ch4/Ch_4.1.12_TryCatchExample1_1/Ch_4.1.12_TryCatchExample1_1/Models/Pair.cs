using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch_4._1._12_TryCatchExample1_1.Models
{
    public class Pair
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pair()
        {

        }
        public Pair(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}