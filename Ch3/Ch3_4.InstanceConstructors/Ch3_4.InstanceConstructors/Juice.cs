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
        public int ID=100;
        
        public Juice(decimal price)
        {
            Price = price;
        }
        public Juice(decimal price, int year) : this(price)
        {
            Year = year;
        }
        public Juice(decimal price, int year, int id) : this(price, year)
        {
            Year = year;
            ID = id;
        }
        
    }
}
