using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task1
{
   /// <summary>
   /// Class-Wrapper for containing static members
   /// </summary>
    public static class EuclidsGcd

    {
        /// <summary>
        /// Method for searching the greatest common divisor with an algorithm created by Euclid
        /// </summary>
        /// <param name="time">timeSpan variable for getting duration of method</param>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <returns>GCD</returns>
        public static int GCD( out TimeSpan time, int a, int b)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Restart();
            while (b != 0)
            {
                int tmp = b;
                b = a%b;
                a = tmp;
            }
            stopwatch1.Stop();
            time=stopwatch1.Elapsed;
            return Math.Abs(a);
            

        }
        /// <summary>
        /// The same method for searching GCD, but for more then 2 numbers
        /// </summary>
        /// <param name="time"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GCD( out TimeSpan time, params int[] numbers)
        {
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Restart();
            int i = 1;
            int res=GCD( out time,numbers[0],numbers[1]);
            while (i < numbers.Length-1)
            {
                 res =  GCD( out time,res, numbers[i + 1]);
                i++;
            }
            stopwatch2.Stop();
            time = stopwatch2.Elapsed;
            return Math.Abs(res);
        }
    }
}
