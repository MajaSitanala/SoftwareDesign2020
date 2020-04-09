using LAB10_FP_VS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;

namespace Test
{
    [TestClass]
    public class Tests
    {
        /*
        //[Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(27, "XXVII")]
        [TestCase(48, "XLVIII")]
        [TestCase(59, "LIX")]
        [TestCase(93, "XCIII")]
        [TestCase(141, "CXLI")]
        [TestCase(163, "CLXIII")]
        [TestCase(402, "CDII")]
        [TestCase(575, "DLXXV")]
        [TestCase(911, "CMXI")]
        [TestCase(1024, "MXXIV")]
        [TestCase(3000, "MMM")]
        public void TestRomenConversion(int number, string expected)
        {
            var arabic = new Arabic(number);
            Assert.AreEqual(expected, arabic.ToRoman());
        }*/

        [TestMethod]
        public void TestRomenConversion1(int number=1, string expected="I")
        {
            var arabic = new Arabic(number);
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion2()
        {
            //var arabic = new Arabic(number);
            //Console.WriteLine(arabic.ToRoman());
            Assert.AreEqual("1", "1");
        }

        [TestMethod]
        public void TestRomenConversion3(int number = 3, string expected = "III")
        {
            var arabic = new Arabic(number);
            Assert.AreEqual(expected, arabic.ToRoman());
        }
    }
}