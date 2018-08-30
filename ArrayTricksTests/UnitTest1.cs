using System;
using Xunit;

namespace ArrayTricks
{
    public class SetUnitTest
    {
        private Set _empty;
        private Set _one;
        private Set _two;

        private Set _big;
        public SetUnitTest()
        {
            _empty = new Set();
            _one = new Set(1);
            _two = new Set(2);
            _one.add("a");

            _two.add("a");
            _two.add("b");

            _big = new Set(12);
            _big.add("a");
            _big.add("b");
            _big.add("c");
            _big.add("d");
            _big.add("e");
            _big.add("f");
            _big.add("g");
            _big.add("h");
            _big.add("i");
            _big.add("j");
            _big.add("k");
            _big.add("z");
        }

        [Fact]
        public void IsEmptyTest()
        {
            Assert.True(_empty.isEmpty());
            Assert.False(_one.isEmpty());
        }

        [Fact]
        public void Size()
        {
            Assert.True(_empty.Size == 0);
            Assert.True(_big.Size == 12);
        }

        [Fact]
        public void AddItemTest()
        {
            Assert.False(_one.isEmpty());
            Assert.False(_two.isEmpty());
            _one.add("c");
            Assert.True(_one.Size == 2);
            _two.add("d");
            Assert.True(_two.Size == 3);
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
        public void AddElementNoStackOverflow()
        {
            _two.add("c");
            Assert.True(_two.Size == 3);
        }

        [Fact]
        public void RemoveItemFromEmptyArray()
        {
            _empty.remove("a");
            Assert.True(_empty.isEmpty());
        }

        [Fact]
        public void RemoveItem()
        {
            _one.remove("a");
            Assert.True(_one.isEmpty());
            Assert.True(_one.Size == 0);

            _two.remove("a");
            Assert.False(_two.isEmpty());
            Assert.True(_two.Size == 1);
        }

        [Fact]
        public void IteratorTest()
        {
            var enumerator = _one.GetEnumerator();
            foreach (var item in enumerator)
            {
                Assert.True(item.Equals("a"));
            }
        }

        [Fact]
        public void ClearTest()
        {
            _one.clear();
            Assert.True(_one.Size == 0);
            Assert.True(_one.isEmpty());
        }
    }
}
