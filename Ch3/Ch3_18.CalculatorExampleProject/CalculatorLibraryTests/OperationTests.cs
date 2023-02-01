using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibraryTests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void TestConstructorJustOperand1()
        {
            double op1 = 5;
            double op2 = 3;
            Operation op = new Operation(op1, op2);

            Assert.AreEqual(op1, op.Operand1);

        }

        [TestMethod]
        public void TestConstructorJustOperand2()
        {
            double op1 = 5;
            double op2 = 3;
            Operation op = new Operation(op1, op2);

            Assert.AreEqual(op2, op.Operand2);

        }
    }
}
