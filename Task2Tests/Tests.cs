using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using NUnit.Framework;

namespace Task2Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[][] array = new int[][] {new []{1, 2, 3, 4},new []{2, 3, 4},new [] {4, 5, 6, 7, 432, 4}, new[] { 5, 5, 55555 }, new[] { 0, 5, 6, 7, 0, 4 } };
           MatrixFunc.BubbleSortSumUp(array);

        }
    }
}
