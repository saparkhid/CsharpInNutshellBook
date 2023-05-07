using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    //1-> output
    //1-> input
    //public delegate int MyFunc(int arg);
    public delegate TOutput MyFunc<in TInput,out TOutput> (TInput input);
    public delegate TOutput MyFunc<in TInput1,in TInput2, out TOutput>(TInput1 arg1, TInput2 arg2);
}
