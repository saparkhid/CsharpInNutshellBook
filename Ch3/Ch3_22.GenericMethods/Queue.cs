using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_22.GenericMethods
{
    internal class Queue<T1,T2>
    {
        public List<Block<T1, T2>> Items { get; set; }

        public Queue()
        {
            Items = new List<Block<T1, T2>>();
        }
    }
}
