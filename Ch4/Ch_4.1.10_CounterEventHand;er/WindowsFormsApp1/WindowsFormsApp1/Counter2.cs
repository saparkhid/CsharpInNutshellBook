using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public delegate void CounterChangedDelegate(int counter);
    public class Counter2
    {
        int number = 0;
        int start;
        int multiplier = 0;
        public event CounterChangedDelegate OnCounterChanged;
        public event CounterChangedDelegate OnCounterThresholdReceived;
        public Counter2(int start, int multiplier)
        {
            this.start = start;
            this.number = start;
            this.multiplier = multiplier;
        }
        public void Increase()
        {
            this.number++;
            OnCounterChanged(number);
            if (this.number % this.multiplier == 0)
            {
                OnCounterThresholdReceived(number);
            }
        }
    }
}
