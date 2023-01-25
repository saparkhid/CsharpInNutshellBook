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
        public History(int size)
        {
            operations = new Operation[size];
        }
    }
}
