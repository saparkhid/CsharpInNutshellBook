using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StandardCalculator
    {
        History history;
        Memory memory;
        Display display;
        public StandardCalculator(int memorySize,int historySize)
        {
            history = new History(historySize);
            memory = new Memory(memorySize);
            display = new Display();
        }

        public void SetDisplay(double number)
        {

        }
    }
}
