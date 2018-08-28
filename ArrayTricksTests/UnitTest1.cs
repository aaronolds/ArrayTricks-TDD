using System;
using Xunit;

namespace ArrayTricks
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var empty = new Set();
            Assert.True(empty.isEmpty());
        }
    }
}
