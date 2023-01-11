using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_11.BaseKeyword
{
    public class SamsungA12 : Mobile
    {
        
        public SamsungA12() :base("A12")
        {
         
        }
        public override void PrintMobileInfo()
        {
            base.PrintMobileInfo();
            Console.WriteLine("Some other info");
        }
        public void PrintThis()
        {
            this.PrintMobileInfo();
        }
        public void PrintBase()
        {
            base.PrintMobileInfo();
        }
    }
}
