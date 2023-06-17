using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void FindGCDSteinTest()
        {
            int a = 298467352;
            int b = 569484;
            int[] c = { a, b };
            long time;
            int expected = 4;
            Assert.AreEqual(expected, Form1.FindGCDStein(out time, c));
        }

        [TestMethod()]
        public void NODTest()
        {
            int a = 298467352;
            int b = 569484;
            int[] c = { a, b };
            long time;
            int expected = 4;
            Assert.AreEqual(expected, Form1.NOD(out time, c));
        }
    }
}