using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesGraphingCalc;

namespace ce103_hw6_calc_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        public void CalculateTest1()
        {
            var expected = RPN.Calculate("68 + 20");
            var actual = 88;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest2()
        {
            var expected = RPN.Calculate("99 - 44");
            var actual = 55;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CalculateTest3()
        {
            var expected = RPN.Calculate("sqrt(4");
            var actual = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            var expected = RPN.Calculate("ln(e^5");
            var actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            var expected = RPN.Calculate("lg(10");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest6()
        {
            var expected = RPN.Calculate(" %100");
            var actual = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest7()
        {
            var expected = RPN.Calculate(" !5");
            var actual = 120;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest8()
        {
            var expected = RPN.Calculate(" 15 * 4");
            var actual = 60;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest9()
        {
            var expected = RPN.Calculate(" 100 / 4");
            var actual = 25;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest10()
        {
            var expected = RPN.Calculate(" 5^2");
            var actual = 25;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest11()
        {
            var expected = RPN.Calculate(" 3^4");
            var actual = 81;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest12()
        {
            var expected = RPN.Calculate(" 0^y");
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest13()
        {
            var expected = RPN.Calculate("(4/1000");
            var actual = 0.004;
            Assert.AreEqual(expected, actual);
        }
    }
}
