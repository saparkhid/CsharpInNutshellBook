using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal class Memory
    {
        MemoryItem[] memoryItems;

        public Memory(int size)
        {
            memoryItems = new MemoryItem[size];
        }
    }
}
