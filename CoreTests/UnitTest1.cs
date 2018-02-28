using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c1 = new x64.Class1();
            Assert.AreEqual(42, c1.Foo());
        }
    }
}
