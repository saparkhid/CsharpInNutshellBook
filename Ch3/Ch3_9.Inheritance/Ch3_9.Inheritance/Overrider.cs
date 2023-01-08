using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_9.Inheritance
{
    public class Overrider : BaseClass
    {
        public override void Foo() 
        {
           
            Console.WriteLine("Overrider.Foo");
        }
    }
}
