using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Operation
    {
        public Operation()
        {

        }

        public Operation(double op1,double op2)
        {   
            Operand1 = op1;
            Operand2 = op2;
        }

        public double Value { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
    }
}

