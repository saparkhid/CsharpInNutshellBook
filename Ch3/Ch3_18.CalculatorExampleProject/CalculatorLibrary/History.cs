using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal class History
    {
        private Operation[] operations;
        int currentIndex = 0;
        int nSize = 0;
        public History(int size)
        {
            nSize = size;
            operations = new Operation[size];
        }
        public void Add(Operation op) 
        { 
            
            if (currentIndex < operations.Length)
            {
                operations[currentIndex] = op;
                currentIndex++;
            }
        }

        public Operation[] ReadAll()
        {
            Operation[] o = new Operation[currentIndex];
            for(int i = 0; i < currentIndex; i++)
            {
                o[i] = operations[i];
            }

            return o;
        }

        public int Count
        {
            get
            {
                return currentIndex;
            }
        }

    }
}
