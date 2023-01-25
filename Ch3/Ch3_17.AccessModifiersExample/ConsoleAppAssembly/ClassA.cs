using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssembly
{
    public class ClassA : ClassLibrary1.Class1
    {
        protected override void Foo()
        {
            base.Foo();
        }
        protected override void Bar()
        {
            base.Bar();
        }
     

    }
}
