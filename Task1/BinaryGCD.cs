using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class BinaryGCD
    {
        /// <summary>
        ///  Method for searching the greatest common divisor with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GCD(int a, int b)
        {
            if (a == b)
                return a;

            if (a == 0)
                return b;

            if (b == 0)
                return a;


            if (a%2 == 0) // u is even
            {
                if (b%2 == 1) // v is odd
                    return GCD(a >> 1, b);

                else // both u and v are even
                    return GCD(a >> 1, b >> 1) << 1;
            }

            if (b%2 == 0) // u is odd, v is even
                return GCD(a, b >> 1);


            if (a > b)
                return GCD((a - b) >> 1, b);

            return GCD((b - a) >> 1, a);
        }

        public static int GCD(params int[] numbers)
        {
            int i = 1;
            int res = GCD(Math.Abs(numbers[0]), Math.Abs(numbers[1]));
            while (i < numbers.Length - 1)
            {
                res = GCD(res, Math.Abs(numbers[i + 1]));
                i++;
            }

            return Math.Abs(res);

        }
    }
}
