using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Counter
    {
        int number = 0;
        int start;
        int multiplier = 0;
        public event EventHandler<CounterEventArgs> CounterChanged;
        public event EventHandler<CounterEventArgs> CounterThresholdReceived;
        public Counter(int start, int multiplier)
        {
            this.start = start;
            this.number = start;
            this.multiplier = multiplier;
        }
        public void Increase()
        {
            this.number++;
            OnCounterChanged(new CounterEventArgs(number));
            if (this.number % this.multiplier==0) 
            {
                OnCounterThresholdReceived(new CounterEventArgs(number));
            }
        }
        protected virtual void OnCounterChanged(CounterEventArgs e)
        {
            CounterChanged?.Invoke(this, e);
        }
        protected virtual void OnCounterThresholdReceived(CounterEventArgs e)
        {
            CounterThresholdReceived?.Invoke(this, e);
        }
    }
}
