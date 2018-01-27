
using System;
using LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test h = new Test();
            h.test = "test";
            JsonMapper.ToJson(h);
            Assert.IsFalse(false);
            Assert.IsTrue(h.test.Equals("test"));
        }

        public class Test
        {
            public string test;
        }
    }
}
