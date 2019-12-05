using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Transport tran = new Transport();
            Rain rain = new Rain();
            tran = (Transport)rain.Clone();
        }
        [TestMethod]
        public void TestMethod4()
        {
            Rain tran = new Rain(2, 3, 2);
            Rain rain = new Rain(3, 3, 3);
            tran = (Rain)rain.Clone();
        }
    }
}
