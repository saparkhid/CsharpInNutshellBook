using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3._22_GenericsExample1
{
    internal class StackStudent
    {
        int position;
        Student[] data = new Student[100];
        public void Push(Student x) => data[position++] = x;
        public Student Pop() => data[--position];
    }
}
