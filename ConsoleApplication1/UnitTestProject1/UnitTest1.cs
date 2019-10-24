using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            stack S1 = new stack(15);

            S1.Push(1);
            S1.Push(2);
            S1.Push(3);
            Assert.AreEqual(3, S1.Count());

        }

        [TestMethod]
        public void TestPop()
        {
            stack S2 = new stack(15);

            S2.Push(1);
            Assert.AreEqual(1, S2.Pop());

            S2.Push(2);
            Assert.AreEqual(2, S2.Pop());

        }

        [TestMethod]
        public void TestPeek()
        {
            stack S3 = new stack(10);

            S3.Push(1);
            S3.Push(2);
            S3.Push(3);
            Assert.AreEqual(3, S3.Peek());

        }

        [TestMethod]
        public void TestCount()
        {
            stack S4 = new stack(7);

            S4.Push(1);
            S4.Push(2);
            S4.Push(3);
            S4.Push(4);
            S4.Push(5);
            S4.Push(6);
            Assert.AreEqual(6, S4.Count());

        }

        [TestMethod]
        public void TestClear()
        {
            stack S5 = new stack(10);

            S5.Push(1);
            S5.Push(2);
            S5.Push(3);
            S5.Push(4);
            S5.Push(5);
            S5.Push(6);
            S5.Push(7);
            S5.Clear();
            Assert.AreEqual(0, S5.Count());
        }
    }
}
