using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3._22_GenericsExample1
{
    internal class StackString
    {
        int position;
        string[] data = new string[100];
        public void Push(string x) => data[position++] = x;
        public string Pop() => data[--position];
    }
}
