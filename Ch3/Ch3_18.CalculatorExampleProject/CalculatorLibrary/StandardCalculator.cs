using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StandardCalculator
    {
        History history;
        Memory memory;
        Display display;

        private double _operand1;
        private double _operand2;
        private Operators _operator;
 

        public StandardCalculator(int memorySize,int historySize)
        {
            history = new History(historySize);
            memory = new Memory(memorySize);
            display = new Display();
        }

        public void SetOperand1(double v)
        {
            _operand1 = v;
            display.SetDisplay(_operand1);
        }
        public void SetOperand2(double v)
        {
            _operand2 = v;
            display.SetDisplay(_operand2);
        }

        public void Clear()
        {
            _operand1 = 0;
            _operand2 = 0;
            display.SetDisplay("");
        }
        public void SetOperator(Operators op)
        {
            _operator = op;
        }

        public void SetDisplay(double number)
        {
            display.SetDisplay(number);
        }
        public string GetDisplay()
        {
            return display.ToString();
        }
        public Operation[] GetHistory()
        {
            return history.ReadAll();
        }
        public Operation Evaluate()
        {
            Operation op = new Operation(_operand1, _operand2);
            if(_operator== Operators.Multiply)
            {
                op.Value = _operand1 * _operand2;
            }
            else if (_operator == Operators.Plus)
            {
                op.Value = _operand1 + _operand2;
            }
            else if (_operator == Operators.Minus)
            {
                op.Value = _operand1 - _operand2;
            }
            else if (_operator == Operators.Divide)
            {
                op.Value = _operand1 / _operand2;
            }

            history.Add(op);
            return op;
        }
        public Operation Add(double a, double b)
        {
            double v = a + b;
            Operation op = new Operation(a, b);
            op.Value = v;
            return op;
        }
        public Operation Subtract(double a, double b)
        {
            double v = a - b;
            Operation op = new Operation(a, b);
            op.Value = v;
            return op;
        }
        public Operation Multiply(double a, double b)
        {
            double v = a * b;
            Operation op = new Operation(a, b);
            op.Value = v;
            return op;
        }
        public Operation Division(double a, double b)
        {
            double v = a / b;
            Operation op = new Operation(a, b);
            op.Value = v;
            return op;
        }

  
    }
}
