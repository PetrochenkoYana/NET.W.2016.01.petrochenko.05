using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;
namespace Task1Tests
{
    [TestFixture]
    class Tests
    {
        TimeSpan time = new TimeSpan();
        [Test]
        public void Test1()
        {
            
            Assert.AreEqual(21,EuclidsGcd.GCD(out time,1071, 462));
            Console.WriteLine(time.TotalMilliseconds.ToString());
            
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(21, EuclidsGcd.GCD(out time, 462, 1071));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(21, EuclidsGcd.GCD(out time, 462, 1071,21));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(21, EuclidsGcd.GCD(out time, 462, 1071,0));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(1, EuclidsGcd.GCD(out time, 462, 1071,467));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(1, EuclidsGcd.GCD(out time, 462, 1071, 21,1,5,7));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test7()
        {
            Assert.AreEqual(1, EuclidsGcd.GCD(out time, 462, 1071, 467,0,0));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test8()
        {
            Assert.AreEqual(7, EuclidsGcd.GCD(out time, 462, 1071,42,84,7));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test9()
        {
            Assert.AreEqual(3, EuclidsGcd.GCD(out time, 462, 1071,3,3,3,3,3,3,3,3,21));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(1, EuclidsGcd.GCD(out time, 462, 1071, 467,0,0,0,0,0,0,5));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }
        [Test]
        public void Test11()
        {
            Assert.AreEqual(1, EuclidsGcd.GCD(out time, -462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));
            Console.WriteLine(time.TotalMilliseconds.ToString());
        }

        /// <summary>
        /// tests 
        /// </summary>
        [Test]
        public void Test12()
        {
            Assert.AreEqual(21, BinaryGCD.GCD(462,1071));
           
        }
        [Test]
        public void Test13()
        {
            Assert.AreEqual(21, BinaryGCD.GCD(462, 1071,0));

        }
        [Test]
        public void Test14()
        {
            Assert.AreEqual(3, BinaryGCD.GCD(462, 1071, 3, 3, 3, 3, 3, 3, 3, 3, 21));

        }
        [Test]
        public void Test15()
        {
            Assert.AreEqual(1, BinaryGCD.GCD(-462, 1071, 467, 0, 0, 0, 0, 0, 0, 5));

        }

    }
}
