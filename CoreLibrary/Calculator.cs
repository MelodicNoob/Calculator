using System;

namespace CoreLibrary
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }
    }
}
