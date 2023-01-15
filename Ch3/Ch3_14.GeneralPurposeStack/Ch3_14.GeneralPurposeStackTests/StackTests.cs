using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ch3_14.GeneralPurposeStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_14.GeneralPurposeStack.Tests
{
    [TestClass()]
    public class StackTests
    {
      
        [TestMethod()]
        public void PushTest()
        {
           Stack stack = new Stack();
           stack.Push(5);
           stack.Push(1);
           int currentPosition = stack.PositionIndex;
           Assert.AreEqual(2, currentPosition);
        }

        [TestMethod()]
        public void PopTest()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(1);
            int result = (int)stack.Pop();
            Assert.AreEqual(1, result);
        }
  

        [TestMethod()]
        public void PushTest2()
        {
            Stack stack = new Stack();
            stack.Push(5);
            int result = (int)stack.Pop();
            Assert.AreEqual(5, result);
        }
    }
}