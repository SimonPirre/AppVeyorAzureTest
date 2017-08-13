using System;
using Xunit;

namespace XUnitSample.Test
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Test", "Test");
        }
    }
}
