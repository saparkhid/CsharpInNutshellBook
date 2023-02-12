using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3._22_GenericsExample1
{
    internal class StackInt
    {
        int position;
        int[] data = new int[100];
        public void Push(int x) => data[position++] = x;
        public int Pop() => data[--position];
    }
    
}
