using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
   
    internal class Display
    {
        private double displayValue;

        public Display()
        {

        }
        public Display(double val)
        {
            this.displayValue = val;
        }
        public void SetDisplay(double d)
        {
            this.displayValue = d;
        }
        public void SetDisplay(string v)
        {
            double val = 0;
            bool hasBeenParsed=double.TryParse(v, out val);
            if (hasBeenParsed)
            {
                this.displayValue = val;
            }
            else
            {
                this.displayValue = 0;
            }
         
        }
        public override string ToString()
        {
            string priceStr = this.displayValue.ToString();
            string result = "";
            int n = priceStr.Length;
            if (n <= 3)
            {
                result = priceStr;
            }
            else
            {
                int m = n % 3;
                if (m > 0)
                {
                    result += priceStr.Substring(0, m) + ",";
                }
                for (int i = m; i < n; i += 3)
                {
                    result += priceStr.Substring(i, 3) + ",";
                }
                if (result.EndsWith(","))
                {
                    result = result.Substring(0, result.Length - 1);
                }

            }
            return result;
        }

        public double DisplayValue
        {
            get
            {
                return displayValue;
            }
        }
    }
}
