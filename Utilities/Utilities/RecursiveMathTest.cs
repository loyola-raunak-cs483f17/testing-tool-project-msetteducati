using System;
using Xunit;

namespace Utilities
{
    public class RecursiveMathTest
    {
        [Fact]
        public void TestRecursiveAdd()
        {
            Assert.Equal(5, RecursiveMath.RecursiveAdd(2, 3));
            Assert.Equal(3, RecursiveMath.RecursiveAdd(0, 3));
            Assert.Equal(-10, RecursiveMath.RecursiveAdd(-20, 10));
        }

        [Fact]
        public void TestRecursiveSubtract()
        {
            Assert.Equal(-1, RecursiveMath.RecursiveSubtract(2, 3));
            Assert.Equal(-3, RecursiveMath.RecursiveSubtract(0, 3));
            Assert.Equal(5, RecursiveMath.RecursiveSubtract(10, 5));
        }

        [Fact]
        public void TestRecursiveMultiply()
        {
            Assert.Equal(20, RecursiveMath.RecursiveMultiply(4, 5));
            Assert.Equal(-10, RecursiveMath.RecursiveMultiply(2, -5));
            Assert.Equal(0, RecursiveMath.RecursiveMultiply(10, 0));
        }

        [Fact]
        public void TestRecursiveDivide()
        {
            Assert.Equal(5, RecursiveMath.RecursiveDivide(20, 4));
            Assert.Equal(-4, RecursiveMath.RecursiveDivide(12, -3));
            Assert.Equal(0, RecursiveMath.RecursiveDivide(20, 0));
            Assert.Equal(0, RecursiveMath.RecursiveDivide(0, 20));
        }

        [Fact]
        public void TestRecursiveExponent()
        {
            Assert.Equal(1, RecursiveMath.RecursiveExponent(5, 0));
            Assert.Equal(5, RecursiveMath.RecursiveExponent(5, 1));
            Assert.Equal(16, RecursiveMath.RecursiveExponent(2, 4));
        }
    }
}
