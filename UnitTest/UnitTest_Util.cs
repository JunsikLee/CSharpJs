using CSharpJs.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public class Test
        {
            private string value = "test";

            public string Value { get => value; set => this.value = value; }
        }
           
        [TestMethod]
        public void TestMethod_Singleton()
        {
            Assert.IsNotNull(Singleton<Test>.Instance());
        }
    }
}
