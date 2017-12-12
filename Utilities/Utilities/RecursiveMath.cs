using System;

namespace Utilities
{
    public class RecursiveMath
    {
        /**
         * Recursively add two numbers together.
         */
        public static int RecursiveAdd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return RecursiveAdd(a + 1, b - 1);
        }

        /**
         * Recursively subtract a minus b
         */
        public static int RecursiveSubtract(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return RecursiveSubtract(a - 1, b - 1);
        }

        /**
         * Recursively multiply a times b.
         */
        public static int RecursiveMultiply(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            else if (b < 0)
                return -a + RecursiveMultiply(a, b + 1);
            else
                return a + RecursiveMultiply(a, b - 1);
        }

        /**
         * Recursively divide dividend divided by divisor.
         */
        public static int RecursiveDivide(int dividend, int divisor)
        {
            if (divisor == 0)
                return 0;
            else if (dividend - divisor == 0)
                return 1;
            else if (dividend < divisor)
                return 0;
            else
                return (1 + RecursiveDivide(dividend - divisor, divisor));
        }

        /**
         * Recursively calculate num to the power of exp.
         */
        public static int RecursiveExponent(int num, int exp)
        {
            if (exp == 0)
                return 1;
            else
                return num * RecursiveExponent(num, exp - 1);
        }
    }
}
