using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void NODTest()
        {
            int a = 12;
            int b = 24;
            int expected = 12;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }

        [TestMethod()]
        public void NODTest1()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c));
        }

        [TestMethod()]
        public void NODTest2()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d));
        }

        [TestMethod()]
        public void NODTest3()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int e = 258;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d, e));
        }
    }
}