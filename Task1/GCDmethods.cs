using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
    /// <summary>
    /// Class-Wrapper for containing static members(different methods for searching The Greatest Common Divisor(GCD))
    /// </summary>
    public static class GcdMethods
    {
        /// <summary>
        /// Method for searching the greatest common divisor of two numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd( int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return Math.Abs(a);
        }


        /// <summary>
        /// Method for searching the greatest common divisor of two numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="time"> variable for getting duration of method</param>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd(out long time, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return Math.Abs(a);


        }

        /// <summary>
        /// Method for searching the greatest common divisor of three numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd(int a, int b,int c)
        {
           return EuclidsGcd(EuclidsGcd(a,b),c);
        }


        /// <summary>
        /// Method for searching the greatest common divisor of three numbers with an algorithm created by Euclid
        /// </summary>
        /// <param name="time"> variable for getting duration of method</param>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd(out long time, int a, int b,int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd= EuclidsGcd(EuclidsGcd(a, b), c);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd ;


        }


        /// <summary>
        /// The same method for searching GCD, but for more then 3 numbers
        /// </summary>
        /// <param name="numbers">numbers searching GCD for</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd( params int[] numbers)
        {
            int i = 1;
            int res = EuclidsGcd(numbers[0], numbers[1]);
            while (i < numbers.Length - 1)
            {
                res = EuclidsGcd( res, numbers[i + 1]);
                i++;
            }
            return res;
        }

        /// <summary>
        /// The same method for searching GCD, but for more then 3 numbers
        /// </summary>
        /// <param name="time"> variable for getting duration of method</param>
        /// <param name="numbers">numbers searching GCD for</param>
        /// <returns>int variable for GCD</returns>
        public static int EuclidsGcd(out long time, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int i = 1;
            int res = EuclidsGcd(out time, numbers[0], numbers[1]);
            while (i < numbers.Length - 1)
            {
                res = EuclidsGcd(out time, res, numbers[i + 1]);
                i++;
            }
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return res;
        }


        /// <summary>
        ///  Method for searching the greatest common divisor of two numbers with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int BinaryGcd(int a, int b)
        {
            int shift;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0) return b;
            if (b == 0) return a;

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)  /* Loop X */
                    b >>= 1;

                if (a > b)
                {
                     int t = b; b = a; a = t;
                }  
                b = b - a;                       
            } while (b != 0);

            return a << shift;
        }
        /// <summary>
        ///  Method for searching the greatest common divisor of two numbers with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="time"> variable for getting duration of method</param>
        /// <returns></returns>
        public static int BinaryGcd(out long time,int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            time = 0;

            int shift;
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0) return b;
            if (b == 0) return a;

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)  
                    b >>= 1;

                if (a > b)
                {
                    int t = b; b = a; a = t;
                }
                b = b - a;
            } while (b != 0);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;

            return a << shift;
        }

        /// <summary>
        ///  Method for searching the greatest common divisor of three numbers with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int BinaryGcd(int a, int b,int c)
        {
            var gcd = BinaryGcd(BinaryGcd(a, b), c);
            return gcd;
        }

        /// <summary>
        ///  Method for searching the greatest common divisor of three numbers with an binary algorithm created by Josef Stein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="time"> variable for getting duration of method</param>
        /// <returns></returns>
        public static int BinaryGcd(out long time, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int gcd = BinaryGcd(BinaryGcd(a, b), c);
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return gcd;
        }

        public static int BinaryGcd(params int[] numbers)
        {
            int i = 1;
            var res = BinaryGcd(Math.Abs(numbers[0]), Math.Abs(numbers[1]));
            while (i < numbers.Length - 1)
            {
                res = BinaryGcd(res, Math.Abs(numbers[i + 1]));
                i++;
            }

            return Math.Abs(res);

        }
        public static int BinaryGcd(out long time,params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();
            int i = 1;
            int res = BinaryGcd(Math.Abs(numbers[0]), Math.Abs(numbers[1]));
            while (i < numbers.Length - 1)
            {
                res = BinaryGcd(res, Math.Abs(numbers[i + 1]));
                i++;
            }
            stopwatch.Stop();
            time = stopwatch.Elapsed.Ticks;
            return Math.Abs(res);

        }
    }
}
