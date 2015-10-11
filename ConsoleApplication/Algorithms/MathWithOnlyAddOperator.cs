using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    public static class MathWithOnlyAddOperator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            b = (-1 ^ b) + 1;
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            bool isNegative = false;

            if (a < 0 && b < 0)
            {
                a = (-1 ^ a) + 1;
                b = (-1 ^ b) + 1;
            }
            else if (a < 0)
            {
                isNegative = true;
                a = (-1 ^ a) + 1;
            }
            else if (b < 0)
            {
                isNegative = true;
                b = (-1 ^ b) + 1;
            }

            int total = 0;
            for (int i = 0; i < b; i++)
                total += a;

            if (isNegative)
                return (-1 ^ total) + 1;
            else
                return total;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            if (a == 0)
                return 0;

            bool isNegative = false;

            if (a < 0 && b < 0)
            {
                a = (-1 ^ a) + 1;
                b = (-1 ^ b) + 1;
            }
            else if (a < 0)
            {
                isNegative = true;
                a = (-1 ^ a) + 1;
            }
            else if (b < 0)
            {
                isNegative = true;
                b = (-1 ^ b) + 1;
            }

            int total = b;

            for (int i = 1; i <= a; i++)
            {
                if (total == a)
                {
                    if (isNegative)
                        return (-1 ^ i) + 1;
                    else
                        return i;
                }
                else if (total > a)
                {
                    if (isNegative)
                        return (-1 ^ (i - 1)) + 1;
                    else
                        return i - 1;
                }
                else
                    total += b;
            }

            // Required because compiler thinks "Not all code paths return a value"
            throw new Exception("Could not find answer.");
        }
    }
}
