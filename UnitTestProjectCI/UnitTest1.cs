using System;
using System.Collections;

using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProjectCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassNumber()
        {
            int a = 5;
            int b = 2;
            int result = 7;

            Assert.AreEqual(result, a + b);
        }

        [TestMethod]
        public void TestMinusNumber()
        {
            int a = 5;
            int b = 2;
            int result = 3;

            Assert.AreEqual(result, a - b);
        }
    }
}
