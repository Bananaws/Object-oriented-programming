using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void NODTest()
        {
            int a = 2806;
            int b = 345;
            int expected = 23;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }
    }
}