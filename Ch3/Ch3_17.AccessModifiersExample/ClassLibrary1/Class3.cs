using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class3 : Class1
    {
        protected override void Foo()
        {
            base.Foo();
        }
        private protected override void FooBar()
        {
            base.FooBar();
        }
    }
}
