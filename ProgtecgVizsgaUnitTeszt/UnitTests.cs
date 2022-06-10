using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgtechVizsga;

namespace ProgtecgVizsgaUnitTeszt
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetInstanceTest()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            Assert.IsNotNull(ss);
        }

        [TestMethod]
        public void ZeroSwapTest0()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "alma";
            string expectedString = "alma";
            string actualString = ss.Swap(testString, 'a', 'e', 0);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void ZeroSwapTest1()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "valami";
            string expectedString = "valami";
            string actualString = ss.Swap(testString, 'a', 'e', 0);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void OneSwapTest0()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "alma";
            string expectedString = "elme";
            string actualString = ss.Swap(testString, 'a', 'e', 1);

            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void OneSwapTest1()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "valami";
            string expectedString = "velemi";
            string actualString = ss.Swap(testString, 'a', 'e', 1);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void TwoSwapTest0()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "alma";
            string expectedString = "alme";
            string actualString = ss.Swap(testString, 'a', 'e', 2);

            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void TwoSwapTest1()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "valami";
            string expectedString = "valemi";
            string actualString = ss.Swap(testString, 'a', 'e', 2);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void ThreeSwapTest0()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "oooooo";
            string expectedString = "ooiooi";
            string actualString = ss.Swap(testString, 'o', 'i', 3);

            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void ThreeSwapTest1()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "aaaaaa";
            string expectedString = "aaeaae";
            string actualString = ss.Swap(testString, 'a', 'e', 3);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void FourSwapTest0()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "oooooooo";
            string expectedString = "oooioooi";
            string actualString = ss.Swap(testString, 'o', 'i', 4);

            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void FourSwapTest1()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string testString = "aaaaaaaa";
            string expectedString = "aaaeaaae";
            string actualString = ss.Swap(testString, 'a', 'e', 4);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        [ExpectedException(typeof(NullStringParameterException))]
        public void NullStringTest()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string newString = ss.Swap(null, 'a', 'b', 0);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeIntegerParameterExcepton))]
        public void NegativeIntegerTest()
        {
            StringCharSwapper ss = StringCharSwapper.getInstance();
            string newString = ss.Swap("valami", 'a', 'b', -1);
        }
    }
}
