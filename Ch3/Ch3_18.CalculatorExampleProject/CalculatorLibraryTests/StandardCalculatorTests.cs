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