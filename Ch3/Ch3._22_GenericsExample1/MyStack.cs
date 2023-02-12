using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3._22_GenericsExample1
{
    public class MyStack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T x) => data[position++] = x;
        public T Pop() => data[--position];
    }
}
