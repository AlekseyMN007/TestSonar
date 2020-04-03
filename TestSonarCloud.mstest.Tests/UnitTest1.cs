using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSonarCloud.mstest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expectedValue = "Your sign is: dfg";

            string value = Creater.CreateName();

            Assert.AreEqual(expectedValue, value);
        }
    }
}
