using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_9.Inheritance
{
    public class Hider : BaseClass
    {
        public new string Name = "Reza";
        public new void Foo()
        {
            
            Console.WriteLine("Hider.Foo");
        }
    }
}
