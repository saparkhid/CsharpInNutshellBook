using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Tests
{
    [TestClass()]
    public class StandardCalculatorTests
    {
        [TestMethod()]
        public void StandardCalculatorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetDisplayTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OperandsOperators1()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            sc.SetOperand1(55);
            sc.SetOperand2(10);
            sc.SetOperator(Operators.Plus);
            Operation opResult= sc.Evaluate();
            Assert.AreEqual(opResult.Value, 65);
        }

        [TestMethod()]
        public void TestDisplayWithOperator1()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            sc.SetOperand1(5135);
            string display=sc.GetDisplay();
            Assert.AreEqual(display, "5,135");
        }

        [TestMethod()]
        public void TestDisplayWithOperator2()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            sc.SetOperand1(5435);
            sc.SetOperand2(55135);
            string display = sc.GetDisplay();
            Assert.AreEqual(display, "55,135");
        }

        [TestMethod()]
        public void TestHistoryLen2()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            sc.SetOperand1(12);
            sc.SetOperand2(34);
            sc.SetOperator(Operators.Minus);
            sc.Evaluate();

            sc.SetOperand1(12);
            sc.SetOperand2(34);
            sc.SetOperator(Operators.Plus);
            sc.Evaluate();

            Assert.AreEqual(sc.GetHistory().Length, 2);
        }

        [TestMethod()]
        public void Add23()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            Operation op= sc.Add(2, 3);
            double expected = 5;
            double actual = op.Value;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Mul23()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            Operation op = sc.Multiply(2, 3);
            double expected = 6;
            double actual = op.Value;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Div42()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            Operation op = sc.Division(4, 2);
            double expected = 2;
            double actual = op.Value;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sub42()
        {
            StandardCalculator sc = new StandardCalculator(10, 10);
            Operation op = sc.Subtract(4, 2);
            double expected = 2;
            double actual = op.Value;
            Assert.AreEqual(expected, actual);
        }
    }
}