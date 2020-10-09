using Microsoft.VisualStudio.TestTools.UnitTesting;
using FanOutPut2;
using System;

namespace FanOutPutTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNavn()
        {
            //Arrange
            FanOutPut n1 = new FanOutPut();
                


            n1.Name = "n";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTemp()
        {
            FanOutPut t1 = new FanOutPut();
            t1.Temp = 22;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFugt()
        {
            FanOutPut f1 = new FanOutPut();
            f1.Temp = 25;
        }


    }
}

