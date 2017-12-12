using System;
using Xunit;

namespace Utilities
{
    public class RecursiveMathTest
    {
        /**
         * Test RecursiveAdd() function using Fact.
         */
        [Fact]
        public void TestRecursiveAdd()
        {
            Assert.Equal(5, RecursiveMath.RecursiveAdd(2, 3));
            Assert.Equal(3, RecursiveMath.RecursiveAdd(0, 3));
            Assert.Equal(-10, RecursiveMath.RecursiveAdd(-20, 10));
        }

        /**
         * Test RecursiveAdd() function using Theory and passing
         * it InlineData.
         */
        [Theory]
        [InlineData(4, 4, 8)]
        [InlineData(-1, 3, 2)]
        [InlineData(0, 4, 4)]
        public void TestRecursiveAdd(int val1, int val2, int expected)
        {
            Assert.Equal(expected, RecursiveMath.RecursiveAdd(val1, val2));
        }

        /**
         * Test RecursiveSubtract() using Fact.
         */
        [Fact]
        public void TestRecursiveSubtract()
        {
            Assert.Equal(-1, RecursiveMath.RecursiveSubtract(2, 3));
            Assert.Equal(-3, RecursiveMath.RecursiveSubtract(0, 3));
            Assert.Equal(5, RecursiveMath.RecursiveSubtract(10, 5));
        }

        /**
         * Test RecursiveSubtract() using Theory.
         */
        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        [InlineData(5, -5, 10)]
        public void TestRecursiveSubtract(int val1, int val2, int expected)
        {
            Assert.Equal(expected, RecursiveMath.RecursiveSubtract(val1, val2));
        }

        /**
         * Test RecursiveMultiply() using Fact.
         */
        [Fact]
        public void TestRecursiveMultiply()
        {
            Assert.Equal(20, RecursiveMath.RecursiveMultiply(4, 5));
            Assert.Equal(-10, RecursiveMath.RecursiveMultiply(2, -5));
            Assert.Equal(0, RecursiveMath.RecursiveMultiply(10, 0));
        }

        /**
         * Test RecursiveMultiply() using Theory.
         */
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(5, -5, -25)]
        [InlineData(0, 10, 0)]
        public void TestRecursiveMultiply(int val1, int val2, int expected)
        {
            Assert.Equal(expected, RecursiveMath.RecursiveMultiply(val1, val2));   
        }

        /**
         * Test RecursiveDivide() using Fact.
         */
        [Fact]
        public void TestRecursiveDivide()
        {
            Assert.Equal(5, RecursiveMath.RecursiveDivide(20, 4));
            Assert.Equal(-4, RecursiveMath.RecursiveDivide(12, -3));
            Assert.Equal(0, RecursiveMath.RecursiveDivide(20, 0));
            Assert.Equal(0, RecursiveMath.RecursiveDivide(0, 20));
        }

        /**
         * Test RecursiveDivide() using Theory.
         */
        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(22, 5, 4)]
        [InlineData(12, 4, 3)]
        public void TestRecursiveDivide(int dividend, int divisor, int expected)
        {
            Assert.Equal(expected, RecursiveMath.RecursiveDivide(dividend, divisor));
        }

        /**
         * Test RecursiveExponent() using Fact
         */
        [Fact]
        public void TestRecursiveExponent()
        {
            Assert.Equal(1, RecursiveMath.RecursiveExponent(5, 0));
            Assert.Equal(5, RecursiveMath.RecursiveExponent(5, 1));
            Assert.Equal(16, RecursiveMath.RecursiveExponent(2, 4));
        }

        /**
         * Test RecursiveExponent() using Theory.
         */
        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 5, 32)]
        public void TestRecursiveExponent(int num, int exponent, int expected)
        {
            Assert.Equal(expected, RecursiveMath.RecursiveExponent(num, exponent));
        }
    }
}
