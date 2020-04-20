using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace laba3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const int n = 6;
            int[] a = new int[n] { 3, 12, 5, -9, 8, -4 };
            int res = laba3.Program.Example(a, n);
            Assert.AreEqual(193, res);
        }
    }
}
