using System;
using clicker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unittest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow page = new MainWindow();
            Assert.IsTrue(page.buy1(420));
            Assert.IsTrue(page.buy1(312));
            Assert.IsFalse(page.buy1(311));
            Assert.IsFalse(page.buy1(2));
            Assert.IsTrue(page.buy2(1333));
            Assert.IsTrue(page.buy2(1228));
            Assert.IsFalse(page.buy2(311));
            Assert.IsFalse(page.buy2(2));
            Assert.IsTrue(page.buy3(2777));
            Assert.IsTrue(page.buy3(2748));
            Assert.IsFalse(page.buy3(311));
            Assert.IsFalse(page.buy3(2));
            Assert.IsTrue(page.buy4(4900));
            Assert.IsTrue(page.buy4(4872));
            Assert.IsFalse(page.buy4(311));
            Assert.IsFalse(page.buy4(2));
        }
    }
}
