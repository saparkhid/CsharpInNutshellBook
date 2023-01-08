using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_9.Inheritance
{
    public class BaseClass
    {
        public string Name = "Ali";
        public virtual void Foo()
        {
            Console.WriteLine("BaseClass.Foo");
        }
    }
}
