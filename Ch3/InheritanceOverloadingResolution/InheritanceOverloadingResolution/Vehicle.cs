using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverloadingResolution
{
    public class Vehicle
    {
        public string Name { get; set; }
        public Vehicle(string name)
        {
            Name = name;
        }   
    }
}
