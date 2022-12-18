using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_4.InstanceConstructors
{
    public class Juice
    {
        public decimal Price;
        public int Year;
        public Juice(decimal price) 
        {
            Price = price; 
        }
        public Juice(decimal price, int year) : this(price) 
        { 
            Year = year;
        }
    }
}
