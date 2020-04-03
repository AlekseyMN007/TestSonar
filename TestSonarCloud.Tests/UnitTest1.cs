using System;
using Xunit;

namespace TestSonarCloud.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedValue = "Your sign is: dfg";

            string value = Creater.CreateName();

            Assert.Equal(expectedValue,value);
        }
    }
}
