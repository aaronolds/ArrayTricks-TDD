using System;
using Xunit;

namespace ArrayTricks
{
    public class SetUnitTest
    {
        private Set _empty;
        private Set _one;
        private Set _two;
        public SetUnitTest()
        {
            _empty = new Set();
            _one = new Set(1);
            _two = new Set(2);
            _one.add("a");

            _two.add("a");
            _two.add("b");
        }

        [Fact]
        public void IsEmptyTest()
        {
            Assert.True(_empty.isEmpty());
            Assert.False(_one.isEmpty());
        }

        [Fact]
        public void AddItemTest()
        {
            Assert.False(_one.isEmpty());
            Assert.False(_two.isEmpty());
            Assert.True(_one.Size == 1);
            Assert.True(_two.Size == 2);
        }

        [Fact]
        public void DoesTheSetContain()
        {
            Assert.False(_empty.contains("a"));
            Assert.True(_one.contains("a"));
            Assert.True(_two.contains("b"));
        }

        [Fact]
        public void AddDuplicate()
        {
            _two.add("b");
            Assert.True(_two.Size == 2);
        }

        [Fact]
        public void AddElementStackOverflow()
        {
            _two.add("c");
            Assert.True(_two.Size == 3);
        }
    }
}
