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
    public class DisplayTests
    {
        [TestMethod()]
        public void ToStringTest5Digits()
        {
            Display d = new Display(32817);
            string expected = "32,817";
            string actual = d.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest7Digits()
        {
            Display d = new Display(1328147);
            string expected = "1,328,147";
            string actual = d.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest3Digits()
        {
            Display d = new Display(132);
            string expected = "132";
            string actual = d.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest4Digits()
        {
            Display d = new Display(6132);
            string expected = "6,132";
            string actual = d.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest10Digits()
        {
            Display d = new Display(6132742133);
            string expected = "6,132,742,133";
            string actual = d.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetDisplayDouble231()
        {
            Display d = new Display();
            d.SetDisplay(5);
            double expected = 5;
            double actual = d.DisplayValue;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void SetDisplayFromString()
        {
            Display d = new Display();
            d.SetDisplay("23321");
            double expected = 23321;
            double actual = d.DisplayValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetDisplayFromString2()
        {
            Display d = new Display();
            d.SetDisplay("abdcd");
            double expected = 0;
            double actual = d.DisplayValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetDisplayFromString3()
        {
            Display d = new Display();
            d.SetDisplay("");
            double expected = 0;
            double actual = d.DisplayValue;
            Assert.AreEqual(expected, actual);
        }
    }
}