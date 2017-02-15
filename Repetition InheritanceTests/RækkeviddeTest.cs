using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repetition_Inheritance;

namespace Repetition_InheritanceTests
{
    [TestClass]
    public class RækkeviddeTest
    {
        [TestMethod]
        public void Benzin_RækkeviddeTest()
        {
            BenzinBil TestBil = new BenzinBil("DankMemes", 80600, 2016, 33, "9876543", 25);
            int expected = 825;
            int actual = TestBil.Rækkevidde();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void El_RækkeviddeTest()
        {
            ElBil TestBil = new ElBil("DankMemes", 809000, 2017, "876543", 40, 30);
            int expected = 1200;
            int actual = TestBil.Rækkevidde();

            Assert.AreEqual(expected, actual);
        }
    }
}
