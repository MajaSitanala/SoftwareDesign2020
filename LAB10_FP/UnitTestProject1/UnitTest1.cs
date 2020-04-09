using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB10_FP_VS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestRomenConversion_1()
        {
            var arabic = new Arabic(1);
            var expected = "I";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_2()
        {
            var arabic = new Arabic(2);
            var expected = "II";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_3()
        {
            var arabic = new Arabic(3);
            var expected = "III";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_4()
        {
            var arabic = new Arabic(4);
            var expected = "IV";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_5()
        {
            var arabic = new Arabic(5);
            var expected = "V";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_6()
        {
            var arabic = new Arabic(6);
            var expected = "VI";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_9()
        {
            var arabic = new Arabic(9);
            var expected = "IX";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_10()
        {
            var arabic = new Arabic(10);
            var expected = "X";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_27()
        {
            var arabic = new Arabic(27);
            var expected = "XXVII";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_48()
        {
            var arabic = new Arabic(48);
            var expected = "XLVIII";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_59()
        {
            var arabic = new Arabic(59);
            var expected = "LIX";
            Assert.AreEqual(expected, arabic.ToRoman());
        }


        [TestMethod]
        public void TestRomenConversion_402()
        {
            var arabic = new Arabic(402);
            var expected = "CDII";
            Assert.AreEqual(expected, arabic.ToRoman());
        }

        [TestMethod]
        public void TestRomenConversion_1024()
        {
            var arabic = new Arabic(1024);
            var expected = "MXXIV";
            Assert.AreEqual(expected, arabic.ToRoman());
        }
    }
}
