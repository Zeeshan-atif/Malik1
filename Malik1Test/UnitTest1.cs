using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace Malik1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = Program.creatMessage();
            string actual = "Hello World";
            Assert.AreEqual(actual, expected);
        }
    }
}
