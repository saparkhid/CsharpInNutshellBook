using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_14.GeneralPurposeStack
{
    public class Stack
    {
        int position;
        object[] data;
        public Stack()
        {
            data = new object[10];
        }
        public void Push(object obj) 
        { 
            data[position] = obj;
            position++;
        }
        public object Pop() 
        {
            position--;
            object result= data[position];
            return result;
        }
        public int PositionIndex
        {
            get { return position; }
        }
    }
}
